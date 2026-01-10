using System;
using System.Data;
using System.Windows.Forms;
using QuanLyHocSinh.Database;

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
            //cb môn học
            DataTable dt = DatabaseHelper.GetData("SELECT MaMH, TenMH FROM MonHoc");
            cbMonFilter.DataSource = dt;
            cbMonFilter.DisplayMember = "TenMH";
            cbMonFilter.ValueMember = "MaMH";
        }

        private void LoadData(string whereClause = "")
        {
            // JOIN bảng Diem và HocSinh để lấy Họ Tên
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

                
                txtMaHS.Text = row.Cells["colMaHS"].Value?.ToString();
                txtTenHS.Text = row.Cells["colHoTen"].Value?.ToString();

                txtDiemMieng.Text = row.Cells["colDiemMieng"].Value?.ToString();
                txtDiem15p.Text = row.Cells["colDiem15p"].Value?.ToString();
                txtDiem1Tiet.Text = row.Cells["colDiem1Tiet"].Value?.ToString();
                txtDiemThi.Text = row.Cells["colDiemThi"].Value?.ToString();
            }
        }

       
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string condition = "";

            // Lọc theo lớp
            if (!string.IsNullOrEmpty(txtLopFilter.Text))
            {
                condition += " AND hs.MaLop = '" + txtLopFilter.Text.Trim() + "'";
            }

            // Lọc theo Môn
            if (cbMonFilter.SelectedValue != null)
            {
                condition += " AND d.MaMH = '" + cbMonFilter.SelectedValue.ToString() + "'";
            }

            // Lọc theo Học Kỳ
            if (!string.IsNullOrEmpty(cbHocKyFilter.Text))
            {
                condition += " AND d.HocKy = " + cbHocKyFilter.Text;
            }

            LoadData(condition);
        }

        // Nút Tìm Kiếm
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
                LoadData(); // Load lại tất cả
            }
        }

        // Nút Lưu / Cập nhật điểm
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaHS.Text))
                {
                    MessageBox.Show("Vui lòng chọn học sinh cần nhập điểm!");
                    return;
                }

                // Lấy giá trị điểm, nếu rỗng thì coi là 0
                float diemMieng = string.IsNullOrEmpty(txtDiemMieng.Text) ? 0 : float.Parse(txtDiemMieng.Text);
                float diem15p = string.IsNullOrEmpty(txtDiem15p.Text) ? 0 : float.Parse(txtDiem15p.Text);
                float diem1Tiet = string.IsNullOrEmpty(txtDiem1Tiet.Text) ? 0 : float.Parse(txtDiem1Tiet.Text);
                float diemThi = string.IsNullOrEmpty(txtDiemThi.Text) ? 0 : float.Parse(txtDiemThi.Text);

                // Tính điểm TB: (Miệng + 15p + 1Tiết*2 + Thi*3) / 7
                float diemTB = (diemMieng + diem15p + diem1Tiet * 2 + diemThi * 3) / 7;
                diemTB = (float)Math.Round(diemTB, 2);

                // Lấy thông tin môn và học kỳ đang chọn ở trên bộ lọc để cập nhật
                // (Giả sử đang nhập điểm cho môn và học kỳ đang lọc)
                string maMH = cbMonFilter.SelectedValue.ToString();
                int hocKy = int.Parse(cbHocKyFilter.Text);

                // SQL Update
                // Lưu ý: Dùng dấu chấm (.) cho số thập phân trong SQL
                string sql = string.Format(
                    "UPDATE Diem SET DiemMieng={0}, Diem15p={1}, Diem1Tiet={2}, DiemThi={3}, DiemTB={4} " +
                    "WHERE MaHS='{5}' AND MaMH='{6}' AND HocKy={7}",
                    diemMieng.ToString().Replace(',', '.'),
                    diem15p.ToString().Replace(',', '.'),
                    diem1Tiet.ToString().Replace(',', '.'),
                    diemThi.ToString().Replace(',', '.'),
                    diemTB.ToString().Replace(',', '.'),
                    txtMaHS.Text,
                    maMH,
                    hocKy
                );

                DatabaseHelper.ExecuteSql(sql);
                MessageBox.Show("Cập nhật thành công! Điểm TB mới: " + diemTB);

                // Refresh lại lưới
                btnFilter_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Chức năng này sẽ code sau khi bạn thêm thư viện Excel (ví dụ EPPlus)
            MessageBox.Show("Chức năng xuất Excel đang phát triển!");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}