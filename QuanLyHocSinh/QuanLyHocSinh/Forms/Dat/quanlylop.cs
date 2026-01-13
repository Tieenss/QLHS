using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlhocsinh
{
    public partial class quanlylop : Form
    {
        string connectionString = @"Data Source= .\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;" +
            "TrustServerCertificate = True; Trusted_Connection = True";
        DataSet ds = new DataSet();
        string status = "Reset";
        public quanlylop()
        {
            InitializeComponent();
            status = "Reset";
            SetInterFace(status);
            GetData();
        }
        public void GetData()
        {
            try
            {
                ds.Clear();
                loadGVCN();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = @"
                SELECT l.MaLop, l.TenLop, l.NienKhoa, l.MaGVCN, gv.HoTen
                FROM Lop l
                LEFT JOIN GiaoVien gv ON l.MaGVCN = gv.MaGV
            ";

                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    da.Fill(ds);

                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dgvLop.AutoGenerateColumns = false;
                        dgvLop.DataSource = ds.Tables[0];

                        DataRow row = ds.Tables[0].Rows[0];

                        txtMaLop.Text = row["MaLop"].ToString();
                        txtTenLop.Text = row["TenLop"].ToString();
                        txtNienKhoa.Text = row["NienKhoa"].ToString();

                        cbGVCN.SelectedValue = row["MaGVCN"]; 
                    }
                    else
                    {
                        dgvLop.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu lớp: " + ex.Message);
            }
        }


        public void SetInterFace(String status)
        {
            if (status == "Reset")
            {
                txtMaLop.Enabled = false;
                txtTenLop.Enabled = false;
                txtNienKhoa.Enabled = false;
                cbGVCN.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnTai.Enabled = true;
            }

            else if (status == "Add")
            {
                txtMaLop.Enabled = true;
                txtTenLop.Enabled = true;
                txtNienKhoa.Enabled = true;
                cbGVCN.Enabled = true;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
                txtMaLop.Focus();
                enableTextBox(true);
               
                btnTai.Enabled = false;


            }
            else if (status == "Edit")
            {
                txtMaLop.Enabled = true;
                txtTenLop.Enabled = true;
                txtNienKhoa.Enabled = true;
                cbGVCN.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;

                loadGVCN();

            }
        }

        public void enableTextBox(bool enable)
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtNienKhoa.Text = "";
            loadGVCN();
        }
        private void quanlylop_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = "Add";
            SetInterFace(status);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = "Edit";
            SetInterFace(status);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muôn xoá lớp này không", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "DELETE FROM Lop WHERE MaLop = @MaLop";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Xóa lớp thành công!", "Thông báo");
                            GetData();
                            status = "Reset";
                            SetInterFace(status);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy lớp để xóa!", "Thông báo");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu! " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "";

                    if (status == "Add")
                    {
                        sql = @"INSERT INTO Lop (MaLop, TenLop, NienKhoa, MaGVCN)
                        VALUES (@MaLop, @TenLop, @NienKhoa, @MaGVCN)";
                    }
                    else if (status == "Edit")
                    {
                        sql = @"UPDATE Lop
                        SET TenLop = @TenLop,
                            NienKhoa = @NienKhoa,
                            MaGVCN = @MaGVCN
                        WHERE MaLop = @MaLop";
                    }
                    else
                    {
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                        cmd.Parameters.AddWithValue("@TenLop", txtTenLop.Text.Trim());
                        cmd.Parameters.AddWithValue("@NienKhoa", txtNienKhoa.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaGVCN", cbGVCN.SelectedValue);

                        int kq = cmd.ExecuteNonQuery();

                        if (kq > 0)
                        {
                            MessageBox.Show(status == "Add" ? "Thêm lớp thành công!" : "Cập nhật lớp thành công!");
                            GetData();
                            status = "Reset";
                            SetInterFace(status);
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu nào được lưu!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            status = "Reset";
            SetInterFace(status);
        }

        private void cbGVCN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void loadGVCN()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string sql = "SELECT MaGV, HoTen FROM GiaoVien";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbGVCN.DataSource = dt;
                    cbGVCN.DisplayMember = "HoTen";
                    cbGVCN.ValueMember = "MaGV";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu giáo viên: " + ex.Message);
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status == "Add") return;
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvLop.Rows[e.RowIndex];

            txtMaLop.Text = row.Cells["MaLop"].Value?.ToString();
            txtTenLop.Text = row.Cells["TenLop"].Value?.ToString();
            txtNienKhoa.Text = row.Cells["NienKhoa"].Value?.ToString();

            // loadGVCN();
            cbGVCN.Text = row.Cells["Hoten"].Value?.ToString(); 

            status = "Edit";
            

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                ds.Clear();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string keyword = txtTim.Text.Trim();

                    string query = @"
                                    SELECT l.*, gv.HoTen
                                    FROM Lop l
                                    LEFT JOIN GiaoVien gv ON l.MaGVCN = gv.MaGV
                                    WHERE l.MaLop LIKE @kw
                                       OR l.TenLop LIKE @kw
                                       OR gv.HoTen LIKE @kw
                                ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@kw", "%" + keyword + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);

                    dgvLop.AutoGenerateColumns = false;
                    dgvLop.DataSource = ds.Tables[0];
                }
            }
            catch
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp");
            }
        }

        private void btnTai_Click(object sender, EventArgs e)
        {
            GetData();
            status = "Reset";
        }
    }
}
