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

namespace QuanLyHocSinh.Forms
{
    public partial class FrmToBoMon : Form
    {
        string connectionString = @"Data Source= .\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;" +
            "TrustServerCertificate = True; Trusted_Connection = True";
        DataSet ds = new DataSet();
        string status = "Reset";
        public FrmToBoMon()
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
                ds.Clear();
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                String query = "select * from ToHopMon";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0)
                {
                    dgvTBM.AutoGenerateColumns = false;
                    dgvTBM.DataSource = ds.Tables[0];
                    txtMaToHop.Text = ds.Tables[0].Rows[0]["MaToHop"].ToString();
                    txtTenToHop.Text = ds.Tables[0].Rows[0]["TenToHop"].ToString();
                    
                }

                else
                {
                    dgvTBM.DataSource = null;

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }   

        public void SetInterface(string status)
        {
            if(status == "Reset")
            {
                txtMaToHop.Enabled = false;
                txtTenToHop.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

            }
            else if(status == "Add")
            {
                txtMaToHop.Enabled = true;
                txtTenToHop.Enabled = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;

                ClearInterface();

                txtMaToHop.Focus();
            }
            else if(status == "Update")
            {
                txtMaToHop.Enabled = true;
                txtTenToHop.Enabled = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;

                txtMaToHop.Focus();
            }
        }

        public void ClearInterface()
        {
            txtMaToHop.Text = "";
            txtTenToHop.Text = "";
        }
        private void quanlytobomon_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn Tổ hợp môn này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        string query = "delete from ToHopMon where MaToHop '" + txtMaToHop.Text.Trim() + "'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        var result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo");
                            GetData();
                            status = "Reset";
                            SetInterface(status);
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại!", "Thông báo");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu! " + ex.Message);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = "Add";
            SetInterface(status);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = "Update";
            SetInterface(status);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    if (status == "Add")
                    {
                        cmd.CommandText = "INSERT INTO ToHopMon (MaToHop, TenToHop) VALUES (@MaToHop, @TenToHop)";
                        int kq = cmd.ExecuteNonQuery();

                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm Môn thành công!");
                            GetData();
                            status = "Reset";
                            SetInterface(status);
                        }

                        else
                        {
                            MessageBox.Show("Thêm Môn thất bại!");
                        }

                    }
                    else if (status == "Update")
                    {
                        cmd.CommandText = "UPDATE ToHopMon SET TenToHop = @TenToHop WHERE MaToHop = @MaToHop";
                    }
                    cmd.Parameters.AddWithValue("@MaToHop", txtMaToHop.Text);
                    cmd.Parameters.AddWithValue("@TenToHop", txtTenToHop.Text);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật thành công");
                        GetData();
                        status = "Reset";
                        SetInterface(status);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu! " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            status = "Reset";
            SetInterface(status);   
        }

        private void dgvTBM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status == "Add") return;
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvTBM.Rows[e.RowIndex];

            txtMaToHop.Text = row.Cells["MaToHop"].Value?.ToString();
            txtTenToHop.Text = row.Cells["TenToHop"].Value?.ToString();
            status = "Edit";
        }
    }
}
