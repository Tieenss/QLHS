using System;
using System.Data;
using System.Windows.Forms;
using QuanLyHocSinh.Database;

namespace QuanLyHocSinh.Forms
{
    public partial class FrmQuanLyHanhKiem : Form
    {
        public FrmQuanLyHanhKiem()
        {
            InitializeComponent();
        }

        private void FrmQuanLyHanhKiem_Load(object sender, EventArgs e)
        {
            
            cboLocHocKy.SelectedIndex = 0; 
            txtLocNamHoc.Text = "2024-2025"; 

            
            if (cboXepLoai.Items.Count == 0)
            {
                cboXepLoai.Items.AddRange(new string[] { "Tốt", "Khá", "Trung Bình", "Yếu", "Chưa xếp loại" });
            }

           
            LoadData();

            
            dgvHanhKiem.ReadOnly = true;
        }

        
        private void LoadData(string whereClause = "")
        {
           
            string sql = @"SELECT hk.MaHS, hs.HoTen, hk.NamHoc, hk.HocKy, hk.XepLoai, hk.NhanXet 
                           FROM HanhKiem hk
                           JOIN HocSinh hs ON hk.MaHS = hs.MaHS
                           WHERE 1=1 " + whereClause;

            DataTable dt = DatabaseHelper.GetData(sql);
            dgvHanhKiem.DataSource = dt;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string condition = "";

            
            if (!string.IsNullOrEmpty(txtLocMaLop.Text))
            {
                condition += " AND hs.MaLop = '" + txtLocMaLop.Text.Trim() + "'";
            }

            if (!string.IsNullOrEmpty(txtLocNamHoc.Text))
            {
                condition += " AND hk.NamHoc = '" + txtLocNamHoc.Text.Trim() + "'";
            }

            if (!string.IsNullOrEmpty(cboLocHocKy.Text))
            {
                condition += " AND hk.HocKy = N'" + cboLocHocKy.Text + "'";
            }

            LoadData(condition);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                string condition = string.Format(" AND (hk.MaHS LIKE '%{0}%' OR hs.HoTen LIKE N'%{0}%')", keyword);
                LoadData(condition);
            }
            else
            {
               
                btnLoc_Click(null, null);
            }
        }

        private void dgvHanhKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= dgvHanhKiem.Rows.Count - 1) return;

            try
            {
                DataGridViewRow row = dgvHanhKiem.Rows[e.RowIndex];

                txtMaHS.Text = row.Cells["colMaHS"].Value?.ToString();
                txtTenHS.Text = row.Cells["colHoTen"].Value?.ToString();

                string namHocRow = row.Cells["colNamHoc"].Value?.ToString();
                string hocKyRow = row.Cells["colHocKy"].Value?.ToString();

                cboXepLoai.Text = row.Cells["colXepLoai"].Value?.ToString();
                txtNhanXet.Text = row.Cells["colNhanXet"].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi chọn dòng: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHS.Text)) { MessageBox.Show("Vui lòng nhập hoặc chọn Mã HS"); return; }

            string maHS = txtMaHS.Text;
            string namHoc = txtLocNamHoc.Text; 
            string hocKy = cboLocHocKy.Text;

            if (string.IsNullOrEmpty(namHoc) || string.IsNullOrEmpty(hocKy))
            {
                MessageBox.Show("Vui lòng nhập Năm học và Học kỳ ở khung Lọc bên trên để xác định thời gian nhập.");
                return;
            }

            try
            {
              
                string checkSql = string.Format("SELECT COUNT(*) FROM HanhKiem WHERE MaHS='{0}' AND NamHoc='{1}' AND HocKy=N'{2}'", maHS, namHoc, hocKy);
                DataTable dtCheck = DatabaseHelper.GetData(checkSql);

                int count = 0;
                if (dtCheck.Rows.Count > 0) count = Convert.ToInt32(dtCheck.Rows[0][0]);

                string sql = "";
                if (count > 0)
                {
                  
                    sql = string.Format(@"UPDATE HanhKiem 
                                          SET XepLoai = N'{0}', NhanXet = N'{1}'
                                          WHERE MaHS = '{2}' AND NamHoc = '{3}' AND HocKy = N'{4}'",
                                          cboXepLoai.Text, txtNhanXet.Text,
                                          maHS, namHoc, hocKy);
                    DatabaseHelper.ExecuteSql(sql);
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    
                    sql = string.Format(@"INSERT INTO HanhKiem (MaHS, NamHoc, HocKy, XepLoai, NhanXet) 
                                          VALUES ('{0}', '{1}', N'{2}', N'{3}', N'{4}')",
                                          maHS, namHoc, hocKy, cboXepLoai.Text, txtNhanXet.Text);
                    DatabaseHelper.ExecuteSql(sql);
                    MessageBox.Show("Thêm mới thành công!");
                }

                btnLoc_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }

  
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHS.Text)) return;

         
            string namHoc = txtLocNamHoc.Text;
            string hocKy = cboLocHocKy.Text;

            if (MessageBox.Show($"Bạn có chắc muốn xóa Hạnh kiểm của HS {txtMaHS.Text} trong HK{hocKy} - {namHoc}?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = string.Format("DELETE FROM HanhKiem WHERE MaHS = '{0}' AND NamHoc = '{1}' AND HocKy = N'{2}'",
                                            txtMaHS.Text, namHoc, hocKy);

                DatabaseHelper.ExecuteSql(sql);
                btnLoc_Click(null, null);
                ResetInputs();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetInputs();
            txtLocMaLop.Clear();
            LoadData(); 
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng xuất Excel đang phát triển!");
        }

        private void ResetInputs()
        {
            txtMaHS.Clear();
            txtTenHS.Clear();
            txtNhanXet.Clear();
            cboXepLoai.SelectedIndex = -1;
        }
    }
}