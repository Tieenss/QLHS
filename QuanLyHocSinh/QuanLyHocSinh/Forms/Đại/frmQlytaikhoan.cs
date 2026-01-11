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
using System.Xml.Linq;

namespace Baitaplon.Đại
{
    public partial class frmQlytaikhoan : Form

    {
        string connectionString = @"Data Source= .\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;" +
            "TrustServerCertificate = True; Trusted_Connection = True";
        DataSet ds = new DataSet();
        string status = "Reset";
        public frmQlytaikhoan()
        {
            InitializeComponent();
            status = "Reset";
            SetInterface(status);
            GetData();
        }

        public void GetData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM TaiKhoan";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds.Clear();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvQlytaikhoan.AutoGenerateColumns = false;
                    dgvQlytaikhoan.DataSource = ds.Tables[0];

                    txtTendangnhap.Text = ds.Tables[0].Rows[0]["TenDangNhap"].ToString();
                    txtMatkhau.Text = ds.Tables[0].Rows[0]["MatKhau"].ToString();
                    cbQuyen.Text = ds.Tables[0].Rows[0]["Quyen"].ToString();
                    txtManguoidung.Text = ds.Tables[0].Rows[0]["MaNguoiDung"].ToString();

                    

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SetInterface(string status)
        {
            if (status == "Reset")
            {
                dgvQlytaikhoan.Enabled = true;

                txtTendangnhap.Enabled = false;
                txtMatkhau.Enabled = false;
                cbQuyen.Enabled = false;
                txtManguoidung.Enabled = false;
                txtTimkiem.Enabled = true;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnTim.Enabled = true;
                btnHienthi.Enabled = true;
            }
            else if (status == "Add")
            {
                dgvQlytaikhoan.Enabled = false;

                txtTendangnhap.Enabled = true;
                txtMatkhau.Enabled = true;
                cbQuyen.Enabled = true;
                txtManguoidung.Enabled = true;
                txtTimkiem.Enabled = false;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnTim.Enabled = false;
                btnHienthi.Enabled = false;

                txtTendangnhap.Text = "";
                txtMatkhau.Text = "";
                txtManguoidung.Text = "";
                cbQuyen.SelectedIndex = 0;
                txtTendangnhap.Focus();

            }
            else if (status == "Edit")
            {
                dgvQlytaikhoan.Enabled = false;

                txtTendangnhap.Enabled = false;
                txtMatkhau.Enabled = true;
                cbQuyen.Enabled = true;
                txtManguoidung.Enabled = true;
                txtTimkiem.Enabled = false;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnTim.Enabled = false;
                btnHienthi.Enabled = false;

                txtTendangnhap.Focus();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmQlytaikhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = "Add";
            SetInterface(status);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = "Edit";
            SetInterface(status);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            status = "Reset";
            SetInterface(status);
            GetData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                        string queryDel = "delete from TaiKhoan where TenDangNhap = '" + txtTendangnhap.Text.Trim() + "'";
                        SqlCommand cmd = new SqlCommand(queryDel, conn);
                        var result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa dữ liệu thành công", "Thông báo");
                            GetData();
                            status = "Reset";
                            SetInterface(status);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi chưa xóa dữ liệu thành công", "Thông báo");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvQlytaikhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQlytaikhoan.Rows[e.RowIndex];

                txtTendangnhap.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtMatkhau.Text = row.Cells["MatKhau"].Value.ToString();
                cbQuyen.Text = row.Cells["Quyen"].Value.ToString();
                txtManguoidung.Text = row.Cells["MaNguoiDung"].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTendangnhap.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Thông báo");
                txtTendangnhap.Focus();
                return;
            }
            if(txtMatkhau.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo");
                txtMatkhau.Focus();
                return;
            }
            if (status == "Add" && CheckTenDangNhapTonTai())
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác", "Thông báo");
                txtTendangnhap.Focus();
                return;
            }
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                if (status == "Add")
                {
                    
                    string cmdAdd = "insert into TaiKhoan (TenDangNhap, MatKhau, Quyen, MaNguoiDung) " +
                        "values('" + txtTendangnhap.Text.Trim() + "', '" + txtMatkhau.Text.Trim() + "', '" +
                        cbQuyen.Text.Trim() + "', '" + txtManguoidung.Text.Trim() + "')";
                    SqlCommand cmd = new SqlCommand(cmdAdd, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
                        GetData();
                        status = "Reset";
                        SetInterface(status);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi chưa thêm dữ liệu thành công", "Thông báo");
                    }
                }
                else if (status == "Edit")
                {
                   string cmdUpdate = "update TaiKhoan set MatKhau = '" + txtMatkhau.Text.Trim() + "', Quyen = '" +
                        cbQuyen.Text.Trim() + "', MaNguoiDung = '" + txtManguoidung.Text.Trim() + "' where TenDangNhap = '" +
                        txtTendangnhap.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(cmdUpdate, conn);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật tài khoản thành công");
                        GetData();
                        status = "Reset";
                        SetInterface(status);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool CheckTenDangNhapTonTai()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = '"
                                + txtTendangnhap.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                int count = (int)cmd.ExecuteScalar();

                conn.Close();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm", "Thông báo");
                txtTimkiem.Focus();
                return;
            }

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string keyword = txtTimkiem.Text.Trim();

                string query = "SELECT * FROM TaiKhoan " +
                               "WHERE TenDangNhap LIKE N'%" + keyword + "%'";


                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                ds.Clear();
                da.Fill(ds);

                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tài khoản phù hợp", "Thông báo");
                }

                dgvQlytaikhoan.AutoGenerateColumns = false;
                dgvQlytaikhoan.DataSource = ds.Tables[0];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            txtTimkiem.Text = "";
            GetData();
        }
    }
}
