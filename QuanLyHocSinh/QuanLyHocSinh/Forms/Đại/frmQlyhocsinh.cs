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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Baitaplon.Đại
{
    public partial class frmQlyhocsinh : Form
    {
        string connectionString = @"Data Source= .\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;" +
            "TrustServerCertificate = True; Trusted_Connection = True";
        DataSet ds = new DataSet();
        string status = "Reset";
        public frmQlyhocsinh()
        {
            InitializeComponent();
            status = "Reset";
            SetInterface(status);
            GetMaLop();
            GetMaDT();
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
                string query = "SELECT * FROM HocSinh";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds.Clear();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvQlyhocsinh.AutoGenerateColumns = false;
                    dgvQlyhocsinh.DataSource = ds.Tables[0];

                    txtMaHS.Text = ds.Tables[0].Rows[0]["MaHS"].ToString();
                    txtHoTen.Text = ds.Tables[0].Rows[0]["HoTen"].ToString();
                    txtDiachi.Text = ds.Tables[0].Rows[0]["DiaChi"].ToString();
                    txtSDT.Text = ds.Tables[0].Rows[0]["SDT"].ToString();
                    txtTenphuhuynh.Text = ds.Tables[0].Rows[0]["TenPhuHuynh"].ToString();
                    txtCCCD.Text = ds.Tables[0].Rows[0]["CCCD"].ToString();

                    cbMaLop.SelectedValue = ds.Tables[0].Rows[0]["MaLop"].ToString();
                    cbMaDT.SelectedValue = ds.Tables[0].Rows[0]["MaDT"].ToString();

                    dtpNgaySinh.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["NgaySinh"]);


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
            if(status == "Reset")
            {
                dgvQlyhocsinh.Enabled = true;

                txtMaHS.Enabled = false;
                txtHoTen.Enabled = false;
                txtDiachi.Enabled = false;
                txtSDT.Enabled = false;
                txtTenphuhuynh.Enabled = false;
                txtCCCD.Enabled = false;
                txtTimkiem.Enabled = true;
                cbMaLop.Enabled = false;
                cbMaDT.Enabled = false;
                cbGioiTinh.Enabled = false;
                dtpNgaySinh.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnTim.Enabled = true;
                btnHienthi.Enabled = true;
            }
            else if(status == "Add")
            {
                dgvQlyhocsinh.Enabled = false;

                txtMaHS.Enabled = true;
                txtHoTen.Enabled = true;
                txtDiachi.Enabled = true;
                txtSDT.Enabled = true;
                txtTenphuhuynh.Enabled = true;
                txtCCCD.Enabled = true;
                txtTimkiem.Enabled = false;
                cbMaLop.Enabled = true;
                cbMaDT.Enabled = true;
                cbGioiTinh.Enabled = true;
                dtpNgaySinh.Enabled = true;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnTim.Enabled = false;
                btnHienthi.Enabled = false;

                txtMaHS.Text = "";
                txtHoTen.Text = "";
                txtDiachi.Text = "";
                txtSDT.Text = "";
                txtTenphuhuynh.Text = "";
                txtCCCD.Text = "";
                //cbMaLop.SelectedValue = "";
                //cbMaDT.SelectedValue = "";
                cbGioiTinh.SelectedIndex = 0;
                dtpNgaySinh.MaxDate = DateTime.Now.AddYears(-15);
                dtpNgaySinh.MinDate = DateTime.Now.AddYears(-18); 
                dtpNgaySinh.Value = DateTime.Now.AddYears(-15);

                txtMaHS.Focus();
            }
            else if(status == "Edit")
            {
                dgvQlyhocsinh.Enabled = false;

                txtMaHS.Enabled = false;
                txtHoTen.Enabled = true;
                txtDiachi.Enabled = true;
                txtSDT.Enabled = true;
                txtTenphuhuynh.Enabled = true;
                txtCCCD.Enabled = true;
                txtTimkiem.Enabled = false;
                cbMaLop.Enabled = true;
                cbMaDT.Enabled = true;
                cbGioiTinh.Enabled = true;
                dtpNgaySinh.Enabled = true;


                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnTim.Enabled = false;
                btnHienthi.Enabled = false;

                txtHoTen.Focus();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmQlyhocsinh_Load(object sender, EventArgs e)
        {

        }

        private void dgvQlyhocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQlyhocsinh.Rows[e.RowIndex];

                txtMaHS.Text = row.Cells["MaHS"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtDiachi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtTenphuhuynh.Text = row.Cells["TenPhuHuynh"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
                cbMaLop.SelectedValue = row.Cells["MaLop"].Value.ToString();
                cbMaDT.SelectedValue = row.Cells["MaDT"].Value.ToString();
                cbGioiTinh.Text = row.Cells["GioiTinh"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = "Add";
            SetInterface(status);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            status = "Reset";
            SetInterface(status);
            GetData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = "Edit";
            SetInterface(status);
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
                        string queryDel = "delete from HocSinh where MaHS = '" + txtMaHS.Text.Trim() + "'";
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

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (!ValidateInput()) return;

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if(conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                if(status == "Add")
                {
                    string cmdAdd = "INSERT INTO HocSinh(MaHS, HoTen, NgaySinh, GioiTinh, DiaChi, MaLop, MaDT, SDT, TenPhuHuynh, CCCD) VALUES (" +
                    "'" + txtMaHS.Text.Trim() + "'," +
                    "N'" + txtHoTen.Text.Trim() + "'," +
                    "'" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "'," +
                    "N'" + cbGioiTinh.Text + "'," +
                    "N'" + txtDiachi.Text.Trim() + "'," +
                    "'" + cbMaLop.SelectedValue + "'," +
                    "'" + cbMaDT.SelectedValue + "'," +
                    "'" + txtSDT.Text.Trim() + "'," +
                    "N'" + txtTenphuhuynh.Text.Trim() + "'," +
                    "'" + txtCCCD.Text.Trim() + "')";
                    SqlCommand cmd = new SqlCommand(cmdAdd, conn);
                    var result = cmd.ExecuteNonQuery();
                    if(result > 0)
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
                else if(status == "Edit")
                {
                     string cmdUpdate = "UPDATE HocSinh SET " +
                    "HoTen = N'" + txtHoTen.Text.Trim() + "'," +
                    "NgaySinh = '" + dtpNgaySinh.Value.ToString("yyyy-MM-dd") + "'," +
                    "GioiTinh = N'" + cbGioiTinh.Text + "'," +
                    "DiaChi = N'" + txtDiachi.Text.Trim() + "'," +
                    "MaLop = '" + cbMaLop.SelectedValue + "'," +
                    "MaDT = '" + cbMaDT.SelectedValue + "'," +
                    "SDT = '" + txtSDT.Text.Trim() + "'," +
                    "TenPhuHuynh = N'" + txtTenphuhuynh.Text.Trim() + "'," +
                    "CCCD = '" + txtCCCD.Text.Trim() + "' " +
                    "WHERE MaHS = '" + txtMaHS.Text.Trim() + "'";

                    SqlCommand cmd = new SqlCommand(cmdUpdate, conn);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật học sinh thành công");
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

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void GetMaLop()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MaLop FROM Lop";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbMaLop.DataSource = dt;
                    cbMaLop.DisplayMember = "MaLop";
                    cbMaLop.ValueMember = "MaLop";
                    cbMaLop.SelectedIndex =0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetMaDT()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MaDT FROM DoiTuongUuTien";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbMaDT.DataSource = dt;
                    cbMaDT.DisplayMember = "MaDT";
                    cbMaDT.ValueMember = "MaDT";
                    cbMaDT.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool CheckMaHSTonTai()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                string query = "SELECT COUNT(*) FROM HocSinh WHERE MaHS = '" + txtMaHS.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                int count = (int)cmd.ExecuteScalar();
                conn.Close();

                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private bool ValidateInput()
        {
            if (txtMaHS.Text.Trim() == "")
            {
                MessageBox.Show("Mã học sinh không được để trống");
                txtMaHS.Focus();
                return false;
            }

            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Họ tên không được để trống");
                txtHoTen.Focus();
                return false;
            }

            if (txtDiachi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được để trống");
                txtDiachi.Focus();
                return false;
            }

            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được để trống");
                txtSDT.Focus();
                return false;
            }

            if (txtTenphuhuynh.Text.Trim() == "")
            {
                MessageBox.Show("Tên phụ huynh không được để trống");
                txtTenphuhuynh.Focus();
                return false;
            }

            if (txtCCCD.Text.Trim() == "")
            {
                MessageBox.Show("CCCD không được để trống");
                txtCCCD.Focus();
                return false;
            }

            if (CheckMaHSTonTai() && status == "Add")
            {
                MessageBox.Show("Mã học sinh đã tồn tại, vui lòng nhập mã khác", "Thông báo");
                txtMaHS.Focus();
                return false;
            }

            return true;
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

                string query = "SELECT * FROM HocSinh " +
                               "WHERE MaHS LIKE N'%" + keyword + "%' " +
                               "OR HoTen LIKE N'%" + keyword + "%' " +
                               "OR MaLop LIKE N'%" + keyword + "%' " +
                               "OR MaDT LIKE N'%" + keyword + "%' ";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                ds.Clear();
                da.Fill(ds);

                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy học sinh phù hợp", "Thông báo");
                }

                dgvQlyhocsinh.AutoGenerateColumns = false;
                dgvQlyhocsinh.DataSource = ds.Tables[0];

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
