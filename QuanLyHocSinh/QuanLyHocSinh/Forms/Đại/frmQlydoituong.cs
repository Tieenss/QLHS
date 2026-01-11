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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Baitaplon.Đại
{
    public partial class frmQlydoituong : Form
    {
        string connectionString = @"Data Source= .\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;" +
            "TrustServerCertificate = True; Trusted_Connection = True";
        DataSet ds = new DataSet();
        string status = "Reset";
        public frmQlydoituong()
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
                string query = "SELECT * FROM DoiTuongUuTien";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ds.Clear();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvQlydoituong.AutoGenerateColumns = false;
                    dgvQlydoituong.DataSource = ds.Tables[0];

                    txtMaDT.Text = ds.Tables[0].Rows[0]["MaDT"].ToString();
                    txtTenDT.Text = ds.Tables[0].Rows[0]["TenDT"].ToString();
                    txtTilegiam.Text = ds.Tables[0].Rows[0]["TiLeGiamHocPhi"].ToString();



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
                dgvQlydoituong.Enabled = true;

                txtMaDT.Enabled = false;
                txtTenDT.Enabled = false;
                txtTilegiam.Enabled = false;
                txtTimkiem.Enabled = true;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnHienthi.Enabled = true;
                btnTim.Enabled = true;
            }
            else if (status == "Add")
            {
                dgvQlydoituong.Enabled = false;

                txtMaDT.Enabled = true;
                txtTenDT.Enabled = true;
                txtTilegiam.Enabled = true;
                txtTimkiem.Enabled = false;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnHienthi.Enabled = false;
                btnTim.Enabled = false;

                txtMaDT.Text = "";
                txtTenDT.Text = "";
                txtTilegiam.Text = "";

                txtMaDT.Focus();
            }
            else if (status == "Edit")
            {
                dgvQlydoituong.Enabled = false;

                txtMaDT.Enabled = false;
                txtTenDT.Enabled = true;
                txtTilegiam.Enabled = true;
                txtTimkiem.Enabled = false;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                btnHienthi.Enabled = false;
                btnTim.Enabled = false;

                txtTenDT.Focus();
            }
        }


        private void frmQlydoituong_Load(object sender, EventArgs e)
        {

        }

        private void dgvQlydoituong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvQlydoituong.Rows[e.RowIndex];
                txtMaDT.Text = row.Cells["MaDT"].Value.ToString();
                txtTenDT.Text = row.Cells["TenDT"].Value.ToString();
                txtTilegiam.Text = row.Cells["TiLeGiamHocPhi"].Value.ToString();
            }
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();

                    string sql = "DELETE FROM DoiTuongUuTien WHERE MaDT = '" + txtMaDT.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Xóa thành công");
                        GetData();
                        status = "Reset";
                        SetInterface(status);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaDT.Text.Trim() == "")
            {
                MessageBox.Show("Mã đối tượng không được để trống");
                txtMaDT.Focus();
                return;
            }

            if (txtTenDT.Text.Trim() == "")
            {
                MessageBox.Show("Tên đối tượng không được để trống");
                txtTenDT.Focus();
                return;
            }

            if (txtTilegiam.Text.Trim() == "")
            {
                MessageBox.Show("Tỉ lệ giảm không được để trống");
                txtTilegiam.Focus();
                return;
            }

            float tiLeGiam;
            if (!float.TryParse(txtTilegiam.Text.Trim(), out tiLeGiam))
            {
                MessageBox.Show("Tỉ lệ giảm phải là số");
                txtTilegiam.Focus();
                return;
            }

            if (tiLeGiam < 0.1f || tiLeGiam > 1f)
            {
                MessageBox.Show("Tỉ lệ giảm phải nằm trong khoảng từ 0.1 đến 1");
                txtTilegiam.Focus();
                return;
            }

            if (status == "Add" && CheckMaDTTonTai())
            {
                MessageBox.Show("Mã đối tượng đã tồn tại");
                txtMaDT.Focus();
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
                    string sqlAdd =
                        "INSERT INTO DoiTuongUuTien(MaDT, TenDT, TiLeGiamHocPhi) VALUES (" +
                        "'" + txtMaDT.Text.Trim() + "'," +
                        "N'" + txtTenDT.Text.Trim() + "'," +
                        tiLeGiam + ")";

                    SqlCommand cmd = new SqlCommand(sqlAdd, conn);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Thêm đối tượng thành công");
                        GetData();
                        status = "Reset";
                        SetInterface(status);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else if (status == "Edit")
                {
                    string sqlUpdate =
                        "UPDATE DoiTuongUuTien SET " +
                        "TenDT = N'" + txtTenDT.Text.Trim() + "'," +
                        "TiLeGiamHocPhi = " + tiLeGiam +
                        " WHERE MaDT = '" + txtMaDT.Text.Trim() + "'";

                    SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật đối tượng thành công");
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


        private void btnHuy_Click(object sender, EventArgs e)
        {
            status = "Reset";
            SetInterface(status);
            GetData();
        }

        public bool CheckMaDTTonTai()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = "SELECT COUNT(*) FROM DoiTuongUuTien WHERE MaDT = '" + txtMaDT.Text.Trim() + "'";
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

                string query = "SELECT * FROM DoiTuongUuTien " +
                               "WHERE MaDT LIKE N'%" + keyword + "%' " +
                               "OR TenDT LIKE N'%" + keyword + "%'";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                ds.Clear();
                da.Fill(ds);

                if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy đối tượng phù hợp", "Thông báo");
                }

                dgvQlydoituong.AutoGenerateColumns = false;
                dgvQlydoituong.DataSource = ds.Tables[0];

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
