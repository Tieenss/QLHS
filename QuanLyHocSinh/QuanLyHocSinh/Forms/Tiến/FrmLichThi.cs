using System;
using System.Data;
using System.Windows.Forms;
using QuanLyHocSinh.Database;

namespace QuanLyHocSinh.Forms
{
    public partial class FrmLichThi : Form
    {
        public FrmLichThi()
        {
            InitializeComponent();
        }

        private void FrmLichThi_Load(object sender, EventArgs e)
        {
            LoadData(); // Load dữ liệu khi mở form
        }

        // --- HÀM DÙNG CHUNG ---
        private void LoadData(string condition = "")
        {
            string query = "SELECT * FROM LichThi";
            if (!string.IsNullOrEmpty(condition))
            {
                query += " WHERE " + condition;
            }

            DataTable dt = DatabaseHelper.GetData(query);
            dgvLichThi.AutoGenerateColumns = false;
            dgvLichThi.DataSource = dt;
            lblTotal.Text = "Tổng số bản ghi: " + (dt != null ? dt.Rows.Count.ToString() : "0");
        }

        private void ClearInputs()
        {
            txtMaLT.Text = "";
            cbKyThi.SelectedIndex = -1;
            cbKyThi.Text = "";
            txtMaMH.Text = "";
            dtpNgayThi.Value = DateTime.Now;
            txtGioBatDau.Text = "";
            txtGioKetThuc.Text = "";
            txtMaPhong.Text = "";
            txtSearch.Text = "";
        }

        // --- SỰ KIỆN CLICK GRID ---
        private void dgvLichThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLichThi.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dgvLichThi.Rows[e.RowIndex];

                txtMaLT.Text = row.Cells["colMaLT"].Value?.ToString();
                cbKyThi.Text = row.Cells["colTenKyThi"].Value?.ToString(); // Gán Text cho ComboBox
                txtMaMH.Text = row.Cells["colMaMH"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["colNgayThi"].Value?.ToString(), out DateTime d))
                    dtpNgayThi.Value = d;

                txtGioBatDau.Text = row.Cells["colGioBatDau"].Value?.ToString();
                txtGioKetThuc.Text = row.Cells["colGioKetThuc"].Value?.ToString();
                txtMaPhong.Text = row.Cells["colMaPhong"].Value?.ToString();
            }
        }

        // --- CÁC NÚT CHỨC NĂNG ---

        // 1. Thêm Mới
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate đơn giản
                if (string.IsNullOrEmpty(txtMaMH.Text) || string.IsNullOrEmpty(cbKyThi.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã Môn và Kỳ Thi!");
                    return;
                }

                string sql = string.Format(
                    "INSERT INTO LichThi (TenKyThi, MaMH, NgayThi, GioBatDau, GioKetThuc, MaPhong) VALUES (N'{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                    cbKyThi.Text.Trim(),
                    txtMaMH.Text.Trim(),
                    dtpNgayThi.Value.ToString("yyyy-MM-dd"),
                    txtGioBatDau.Text.Trim(),
                    txtGioKetThuc.Text.Trim(),
                    txtMaPhong.Text.Trim()
                );

                DatabaseHelper.ExecuteSql(sql);
                MessageBox.Show("Thêm mới thành công!");
                LoadData();
                ClearInputs();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 2. Cập Nhật (Sửa)
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaLT.Text))
                {
                    MessageBox.Show("Vui lòng chọn lịch thi cần cập nhật từ danh sách!");
                    return;
                }

                string sql = string.Format(
                    "UPDATE LichThi SET TenKyThi=N'{0}', MaMH='{1}', NgayThi='{2}', GioBatDau='{3}', GioKetThuc='{4}', MaPhong='{5}' WHERE MaLT={6}",
                    cbKyThi.Text.Trim(),
                    txtMaMH.Text.Trim(),
                    dtpNgayThi.Value.ToString("yyyy-MM-dd"),
                    txtGioBatDau.Text.Trim(),
                    txtGioKetThuc.Text.Trim(),
                    txtMaPhong.Text.Trim(),
                    txtMaLT.Text
                );

                DatabaseHelper.ExecuteSql(sql);
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 3. Xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaLT.Text))
                {
                    MessageBox.Show("Vui lòng chọn lịch thi cần xóa!");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc muốn xóa lịch thi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DatabaseHelper.ExecuteSql("DELETE FROM LichThi WHERE MaLT=" + txtMaLT.Text);
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 4. Làm Mới (Reset)
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        // 5. Tìm Kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(key))
            {
                // Tìm theo Tên Kỳ Thi hoặc Mã Môn
                string condition = string.Format("TenKyThi LIKE N'%{0}%' OR MaMH LIKE '%{0}%'", key);
                LoadData(condition);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
        }
    }
}