using System;
using System.Data;
using System.Windows.Forms;
using QuanLyHocSinh.Database;
using System.Globalization;

namespace QuanLyHocSinh.Forms
{
    public partial class FrmQuanLyDiem : Form
    {
        public FrmQuanLyDiem()
        {
            InitializeComponent();
        }

        private void FrmQuanLyDiem_Load(object sender, EventArgs e)
        {
            LoadMonHoc();
            LoadData();
        }

        private void LoadMonHoc()
        {
            //cbox môn học
            DataTable dt = DatabaseHelper.GetData("SELECT MaMH, TenMH FROM MonHoc");
            cbMonFilter.DataSource = dt;
            cbMonFilter.DisplayMember = "TenMH";
            cbMonFilter.ValueMember = "MaMH";
        }

        private void LoadData(string whereClause = "")
        {
            
            string query = @"SELECT d.MaHS, hs.HoTen, d.MaMH, d.HocKy, d.DiemMieng, d.Diem15p, d.Diem1Tiet, d.DiemThi, d.DiemTB 
                             FROM Diem d 
                             JOIN HocSinh hs ON d.MaHS = hs.MaHS 
                             WHERE 1=1 " + whereClause;

            DataTable dt = DatabaseHelper.GetData(query);
            dgvDiem.AutoGenerateColumns = false;
            dgvDiem.DataSource = dt;
        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDiem.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dgvDiem.Rows[e.RowIndex];

                
                txtMaHS.Text = row.Cells["colMaHS"].Value.ToString();
                txtTenHS.Text = row.Cells["colHoTen"].Value.ToString();

                txtDiemMieng.Text = row.Cells["colDiemMieng"].Value.ToString();
                txtDiem15p.Text = row.Cells["colDiem15p"].Value.ToString();
                txtDiem1Tiet.Text = row.Cells["colDiem1Tiet"].Value.ToString();
                txtDiemThi.Text = row.Cells["colDiemThi"].Value.ToString();
                txtMonHoc.Text = row.Cells["colMaMH"].Value.ToString();
                txtHocKy.Text = row.Cells["colHocKy"].Value.ToString();
            }
        }

       
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string condition = "";
           if (!string.IsNullOrEmpty(txtLopFilter.Text))
            {
                condition += " AND hs.MaLop = '" + txtLopFilter.Text.Trim() + "'";
            }

            
            if (cbMonFilter.SelectedValue != null)
            {
                condition += " AND d.MaMH = '" + cbMonFilter.SelectedValue.ToString() + "'";
            }

           
            if (!string.IsNullOrEmpty(cbHocKyFilter.Text))
            {
                condition += " AND d.HocKy = " + cbHocKyFilter.Text;
            }

            LoadData(condition);
        }

        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                string condition = " AND (d.MaHS LIKE '%" + keyword + "%' OR hs.HoTen LIKE N'%" + keyword + "%')";
                LoadData(condition);
            }
            else
            {
                LoadData(); 
            }
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaHS.Text))
                {
                    MessageBox.Show("Vui lòng chọn học sinh cần nhập điểm!");
                    return;
                }


                float diemMieng = GetValidScore(txtDiemMieng.Text, "Điểm Miệng");
                float diem15p = GetValidScore(txtDiem15p.Text, "Điểm 15p");
                float diem1Tiet = GetValidScore(txtDiem1Tiet.Text, "Điểm 1 Tiết");
                float diemThi = GetValidScore(txtDiemThi.Text, "Điểm Thi");


                float diemTB = (diemMieng + diem15p + diem1Tiet * 2 + diemThi * 3) / 7;
                diemTB = (float)Math.Round(diemTB, 2);

                
                string maMH = cbMonFilter.SelectedValue.ToString();
                int hocKy = int.Parse(cbHocKyFilter.Text);


                string sql = string.Format(
            @"UPDATE Diem 
              SET DiemMieng={0}, Diem15p={1}, Diem1Tiet={2}, DiemThi={3}, DiemTB={4} 
              WHERE MaHS='{5}' AND MaMH='{6}' AND HocKy={7}",
            diemMieng.ToString(CultureInfo.InvariantCulture),
            diem15p.ToString(CultureInfo.InvariantCulture),
            diem1Tiet.ToString(CultureInfo.InvariantCulture),
            diemThi.ToString(CultureInfo.InvariantCulture),
            diemTB.ToString(CultureInfo.InvariantCulture),
            txtMaHS.Text, maMH, hocKy
        );

                DatabaseHelper.ExecuteSql(sql);
                MessageBox.Show("Cập nhật thành công! Điểm TB mới: " + diemTB);

                
                btnFilter_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Nhập Liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Chức năng xuất Excel đang phát triển!");
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {

            ExcelHelper.ExportToExcel(dgvDiem, "QuanLyDiem");
        }

        private float GetValidScore(string input, string tenTruong)
        {
            if (string.IsNullOrEmpty(input)) return 0; 

            
            if (input.Contains("."))
            {
                throw new Exception($"Lỗi tại ô '{tenTruong}': Vui lòng dùng dấu phẩy (,) để nhập số thập phân. Không dùng dấu chấm!");
            }

           
            CultureInfo vietNamParams = new CultureInfo("vi-VN");

            if (float.TryParse(input, NumberStyles.Any, vietNamParams, out float ketQua))
            {
               
                if (ketQua < 0 || ketQua > 10)
                {
                    throw new Exception($"Điểm '{tenTruong}' không hợp lệ (Phải từ 0 - 10).");
                }
                return ketQua;
            }
            else
            {
                throw new Exception($"Dữ liệu tại '{tenTruong}' không phải là số hợp lệ.");
            }
        }

        
    }

}