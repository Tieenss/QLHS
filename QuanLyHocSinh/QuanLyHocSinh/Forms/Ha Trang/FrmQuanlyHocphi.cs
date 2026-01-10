using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BaiKTcuoiky
{
    public partial class FrmQuanlyHocphi : Form
    {
        #region
        string connectionString = "Data source = .\\SQLEXPRESS; Initial Catalog = QuanLyHocSinh; TrustServerCertificate=True;Integrated Security=True";
        DataSet ds = new DataSet();
        string Status = "Reset";
        #endregion

        public FrmQuanlyHocphi()
        {
            InitializeComponent();
           
            dgvHocphi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 1. Tiêu đề: Luôn nằm giữa phía trên và dãn theo chiều ngang
            labelTieude.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;

            // 2. Vùng Tìm kiếm: Bám trên và dãn ngang (để ô tìm kiếm dài ra khi phóng to)
            grbTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom ;
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // 3. Bảng dữ liệu: Dãn ra cả 4 hướng để chiếm trọn phần giữa Form
            grbDanhsachHP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHocphi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // 4. Vùng Thông tin chi tiết: Luôn bám sát đáy và dãn ngang
            grbThongtin.Anchor = AnchorStyles.Bottom ;

            // 5. Căn giữa các nút bấm: 
            btnThem.Anchor = AnchorStyles.Bottom;
            btnSua.Anchor = AnchorStyles.Bottom;
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnLuu.Anchor = AnchorStyles.Bottom;
            btnCancel.Anchor = AnchorStyles.Bottom;

        }

        #region Public functions

        public void GetData(string searchKeyword = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM HocPhi"; 

                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        query += " WHERE MaHS LIKE @key OR TrangThai LIKE @key";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(searchKeyword))
                        cmd.Parameters.AddWithValue("@key", "%" + searchKeyword + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvHocphi.AutoGenerateColumns = false;
                    dgvHocphi.DataSource = null; // Xóa nguồn cũ
                    dgvHocphi.DataSource = dt;   // Gán nguồn mới

                    if (dt.Rows.Count > 0)
                    {
                        DisplayData(dt.Rows[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu: " + ex.Message);
            }
        }

        private void DisplayData(DataRow row)
        {
            txtMaHP.Text = row["MaHP"].ToString();
            txtMhs.Text = row["MaHS"].ToString();
            cboTrangthai.Text = row["TrangThai"].ToString();
            txtTongtien.Text = row["TongTien"].ToString();
            txtMiengiam.Text = row["MienGiam"].ToString();
            txtPhaidong.Text = row["PhaiDong"].ToString();
        }

        public void SetInterface(string status)
        {
            // Vô hiệu hóa/Kích hoạt các ô nhập liệu
            bool isEditing = (status == "Add" || status == "Edit");

            txtMaHP.Enabled = false;
            txtMhs.Enabled = isEditing;
            cboTrangthai.Enabled = isEditing;
            txtTongtien.Enabled = isEditing;
            txtMiengiam.Enabled = isEditing;
            txtPhaidong.Enabled = false; // Phải đóng thường là ô tính toán tự động

            btnThem.Enabled = !isEditing;
            btnSua.Enabled = !isEditing;
            btnXoa.Enabled = !isEditing;
            btnLuu.Enabled = isEditing;
            btnCancel.Enabled = true;

            if (status == "Add")
            {
                ClearFields();
                txtMhs.Focus();
            }
        }

        private void ClearFields()
        {
            txtMaHP.Clear();
            txtMhs.Clear();
            txtTongtien.Clear();
            txtMiengiam.Clear();
            txtPhaidong.Clear();
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmQuanlyHocphi_Load(object sender, EventArgs e)
        {
            Status = "Reset";
            SetInterface(Status);
            GetData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Status = "Add";
            SetInterface(Status);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMhs.Text))
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }
            Status = "Edit";
            SetInterface(Status);
            //txtMhs.Enabled = false; // Không cho sửa Mã học sinh (Khóa chính)
        }

        // Tự động tính số tiền phải đóng khi nhập Tổng tiền hoặc Miễn giảm
        private void txtCalculate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tongTien = string.IsNullOrEmpty(txtTongtien.Text) ? 0 : decimal.Parse(txtTongtien.Text);
                decimal mienGiam = string.IsNullOrEmpty(txtMiengiam.Text) ? 0 : decimal.Parse(txtMiengiam.Text);
                txtPhaidong.Text = (tongTien - mienGiam).ToString();
            }
            catch
            {
                // Tránh lỗi khi người dùng nhập chữ vào ô số
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMhs.Text)) return;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM HocPhi WHERE MaHP = @MaHP";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaHP", txtMaHP.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xóa thành công!");
                    GetData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Status = "Reset";
            SetInterface(Status);
            GetData();
            txtTimkiem.Clear();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            GetData(txtTimkiem.Text.Trim());
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd;

                    if (Status == "Add")
                    {
                        cmd = new SqlCommand(
                            @"INSERT INTO HocPhi (MaHS, TrangThai, TongTien, MienGiam, PhaiDong) 
                      VALUES (@MaHS, @TrangThai, @TongTien, @MienGiam, @PhaiDong)", conn);
                    }
                    else if (Status == "Edit")
                    {
                        cmd = new SqlCommand(
                            @"UPDATE HocPhi SET 
                          TrangThai=@TrangThai, TongTien=@TongTien, 
                          MienGiam=@MienGiam, PhaiDong=@PhaiDong,MaHS=@MaHS 
                          WHERE MaHP=@MaHP", conn);
                    }
                    else return;

                    // Gán tham số
                    cmd.Parameters.AddWithValue("@MaHP", txtMaHP.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaHS", txtMhs.Text.Trim());
                    cmd.Parameters.AddWithValue("@TrangThai", cboTrangthai.Text.Trim());
                    cmd.Parameters.AddWithValue("@TongTien", decimal.Parse(txtTongtien.Text));
                    cmd.Parameters.AddWithValue("@MienGiam", decimal.Parse(txtMiengiam.Text));
                    cmd.Parameters.AddWithValue("@PhaiDong", decimal.Parse(txtPhaidong.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Lưu dữ liệu thành công!");

                    Status = "Reset";
                    SetInterface(Status);
                    GetData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void dgvHocphi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHocphi.Rows[e.RowIndex];
                txtMaHP.Text = row.Cells["MaHP"].Value?.ToString()??"";
                txtMhs.Text = row.Cells["MaHS"].Value?.ToString()??"";
                cboTrangthai.Text = row.Cells["TrangThai"].Value?.ToString() ?? "";
                txtTongtien.Text = row.Cells["TongTien"].Value?.ToString() ?? "";
                txtMiengiam.Text = row.Cells["MienGiam"].Value?.ToString() ?? "";
                txtPhaidong.Text = row.Cells["PhaiDong"].Value?.ToString() ?? "";
            }
        }
    }
}
