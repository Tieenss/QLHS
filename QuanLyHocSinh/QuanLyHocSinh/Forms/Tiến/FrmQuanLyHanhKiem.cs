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
            LoadData();
            // Cài đặt combo box nếu chưa có item
            if (cboXepLoai.Items.Count == 0)
            {
                cboXepLoai.Items.AddRange(new string[] { "Tốt", "Khá", "Trung Bình", "Yếu", "Chưa xếp loại" });
            }
        }

        // --- LOAD DỮ LIỆU ---
        private void LoadData(string whereClause = "")
        {
            // SỬA: Dùng đúng tên cột XepLoai và NhanXet
            string sql = @"SELECT hk.MaHS, hs.HoTen, hk.HocKy, hk.NamHoc, hk.XepLoai, hk.NhanXet 
                           FROM HanhKiem hk
                           JOIN HocSinh hs ON hk.MaHS = hs.MaHS
                           WHERE 1=1 " + whereClause;

            DataTable dt = DatabaseHelper.GetData(sql);
            dgvHanhKiem.DataSource = dt;
        }

        // --- CLICK VÀO LƯỚI ---
        private void dgvHanhKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.RowIndex >= dgvHanhKiem.Rows.Count - 1) return;

            try
            {
                DataGridViewRow row = dgvHanhKiem.Rows[e.RowIndex];

                txtMaHS.Text = GetString(row, "MaHS");
                txtTenHS.Text = GetString(row, "HoTen");
                txtNamHoc.Text = GetString(row, "NamHoc");

                // SỬA: Lấy dữ liệu từ cột NhanXet và XepLoai
                txtNhanXet.Text = GetString(row, "NhanXet");

                string hocKy = GetString(row, "HocKy");
                string xepLoai = GetString(row, "XepLoai");

                if (!string.IsNullOrEmpty(hocKy)) cboHocKy.Text = hocKy;
                if (!string.IsNullOrEmpty(xepLoai)) cboXepLoai.Text = xepLoai;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị: " + ex.Message);
            }
        }

        private string GetString(DataGridViewRow row, string colName)
        {
            if (row.Cells[colName].Value != null && row.Cells[colName].Value != DBNull.Value)
                return row.Cells[colName].Value.ToString();
            return "";
        }

        // --- THÊM ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHS.Text)) { MessageBox.Show("Vui lòng nhập Mã HS"); return; }

            // SỬA: Insert vào cột XepLoai, NhanXet
            string sql = string.Format(@"INSERT INTO HanhKiem (MaHS, HocKy, NamHoc, XepLoai, NhanXet) 
                                         VALUES ('{0}', N'{1}', '{2}', N'{3}', N'{4}')",
                                         txtMaHS.Text, cboHocKy.Text, txtNamHoc.Text, cboXepLoai.Text, txtNhanXet.Text);

            DatabaseHelper.ExecuteSql(sql);
            LoadData();
            ResetControls();
        }

        // --- SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHS.Text)) return;

            // SỬA: Update cột XepLoai, NhanXet
            string sql = string.Format(@"UPDATE HanhKiem 
                                         SET XepLoai = N'{0}', NhanXet = N'{1}'
                                         WHERE MaHS = '{2}' AND HocKy = N'{3}' AND NamHoc = '{4}'",
                                         cboXepLoai.Text, txtNhanXet.Text,
                                         txtMaHS.Text, cboHocKy.Text, txtNamHoc.Text);

            DatabaseHelper.ExecuteSql(sql);
            MessageBox.Show("Cập nhật thành công!");
            LoadData();
        }

        // --- XÓA ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHS.Text)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = string.Format("DELETE FROM HanhKiem WHERE MaHS = '{0}' AND HocKy = N'{1}' AND NamHoc = '{2}'",
                                            txtMaHS.Text, cboHocKy.Text, txtNamHoc.Text);

                DatabaseHelper.ExecuteSql(sql);
                LoadData();
                ResetControls();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                LoadData(string.Format(" AND (hk.MaHS LIKE '%{0}%' OR hs.HoTen LIKE N'%{0}%')", keyword));
            }
            else LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetControls();
            LoadData();
        }

        private void ResetControls()
        {
            txtMaHS.Clear();
            txtTenHS.Clear();
            txtNamHoc.Clear();
            txtNhanXet.Clear();
            txtTimKiem.Clear();
            cboXepLoai.SelectedIndex = -1;
            cboHocKy.SelectedIndex = -1;
        }
    }
}