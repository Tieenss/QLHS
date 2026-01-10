using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class FrmMonHoc : Form
    {
        #region Variables
        string connectionString = @"Data Source= .\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;" +
            "TrustServerCertificate = True; Trusted_Connection = True";
        DataSet dsMonHoc = new DataSet();
        string Status = "Reset";
        #endregion
        public FrmMonHoc()
        {
            InitializeComponent();
            dgvMon.AutoGenerateColumns = true;
            dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMon.RowHeadersVisible = true;
            dgvMon.RowHeadersWidth = 30;
            Status = "Reset";
            SetInterface(Status);
            GetData();
        }
        #region Public functions
        public void GetData()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                string query = "SELECT * FROM MonHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                dsMonHoc.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMonHoc);
                if (dsMonHoc != null && dsMonHoc.Tables.Count > 0 && dsMonHoc.Tables[0].Rows.Count > 0)
                {
                    dgvMon.AutoGenerateColumns = true;
                    dgvMon.DataSource = dsMonHoc.Tables[0];
                    dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    txtMa.Text = dsMonHoc.Tables[0].Rows[0]["MaMH"].ToString();
                    txtTen.Text = dsMonHoc.Tables[0].Rows[0]["TenMH"].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void SetInterface(string Status)
        {
            if (Status == "Reset")
            {
                txtMa.Enabled = false;
                txtTen.Enabled = false;
                txtTim.Enabled = true;

                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnXoa.Enabled = true;
                btnSave.Enabled = false;
                btnHuy.Enabled = true;
                btnTim.Enabled = true;
            }
            else if (Status == "Add")
            {
                txtMa.Enabled = true;
                txtTen.Enabled = true;
                txtTim.Enabled = true;

                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnXoa.Enabled = false;
                btnSave.Enabled = true;
                btnHuy.Enabled = true;
                btnTim.Enabled = true;
                txtMa.Text = "";
                txtTen.Text = "";
                txtMa.Focus();
            }
            else if (Status == "Edit")
            {
                txtMa.Enabled = true;
                txtTen.Enabled = true;
                txtTim.Enabled = true;

                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnXoa.Enabled = false;
                btnSave.Enabled = true;
                btnHuy.Enabled = true;
                btnTim.Enabled = true;
            }
        }
        #endregion
        #region Event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Status = "Add";
            SetInterface(Status);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Status = "Edit";
            SetInterface(Status);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes) {
                    SqlConnection conn = new SqlConnection(connectionString);
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    string query = "DELETE FROM MonHoc WHERE MaMH = '" + txtMa.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa môn học thành công!");
                        GetData();
                        Status = "Reset";
                        SetInterface(Status);
                    }
                    else
                    {
                        MessageBox.Show("Xóa môn học thất bại!");
                    }
                    conn.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    if (Status == "Add")
                    {
                        string cmdInsert =
                            "INSERT INTO MonHoc (MaMH, TenMH) VALUES (" +
                            "N'" + txtMa.Text.Trim() + "'," +
                            "N'" + txtTen.Text.Trim() + "')";
                        SqlCommand cmdInsertCommand = new SqlCommand(cmdInsert, conn);
                        var Insertresult = cmdInsertCommand.ExecuteNonQuery();
                        if (Insertresult > 0)
                        {
                            MessageBox.Show("Thêm môn học thành công!");
                            GetData();
                            Status = "Reset";
                            SetInterface(Status);
                        }
                        else
                        {
                            MessageBox.Show("Thêm môn học thất bại!");
                        }
                    }
                    else if (Status == "Edit")
                    {
                        string cmdUpdate = "UPDATE MonHoc SET TenMH = @TenMH WHERE MaMH = @MaMH";
                        SqlCommand cmd = new SqlCommand(cmdUpdate, conn);
                        cmd.Parameters.AddWithValue("@TenMH", txtTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaMH", txtMa.Text.Trim());
                        var result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Cập nhật môn học thành công!");
                            GetData();
                            Status = "Search";
                            SetInterface(Status);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật môn học thất bại!");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Status = "Reset";
            SetInterface(Status);
            GetData();
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvMon.SelectedCells.Count > 0)
            {
                int selectedIndex = dgvMon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvMon.Rows[selectedIndex];
                txtMa.Text = Convert.ToString(selectedRow.Cells["MaMH"].Value);
                txtTen.Text = Convert.ToString(selectedRow.Cells["TenMH"].Value);
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string sql = "SELECT * FROM MonHoc WHERE MaMH LIKE @search OR TenMH LIKE @search";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@search", "%" + txtTim.Text.Trim() + "%");
                dsMonHoc.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsMonHoc);
                
                dgvMon.AutoGenerateColumns = true;
                dgvMon.DataSource = dsMonHoc.Tables[0];

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion
    }
}