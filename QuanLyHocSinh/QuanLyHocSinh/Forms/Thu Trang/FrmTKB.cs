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

namespace QuanLyHocSinh
{
    public partial class FrmTKB : Form
    {
        #region Variables
        string connectionString = @"Data Source= .\MSSQLSERVER2025;Initial Catalog=QuanLyHocSinh;" +
            "TrustServerCertificate = True; Trusted_Connection = True";
        DataSet dsTKB = new DataSet();
        string Status = "Reset";
        #endregion
        public FrmTKB()
        {
            InitializeComponent();
            dgvTKB.AutoGenerateColumns = true;
            dgvTKB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTKB.RowHeadersVisible = true;
            dgvTKB.RowHeadersWidth = 30;
            Status = "Reset";
            SetInterface(Status);
            GetData();
            LoadComboPhongHoc();
            LoadComboMonHoc();
        }
        #region Public functions
        private void LoadComboMonHoc()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            {
                string sql = "SELECT MaMH FROM MonHoc";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbMMH.DataSource = dt;
                cbMMH.DisplayMember = "MaMH";
                cbMMH.ValueMember = "MaMH";
                cbMMH.SelectedIndex = -1; // không chọn sẵn
            }
        }
        private void LoadComboPhongHoc()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            {
                string sql = "SELECT MaPhong FROM PhongHoc";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cbMP.DataSource = dt;
                cbMP.DisplayMember = "MaPhong";
                cbMP.ValueMember = "MaPhong";
                cbMP.SelectedIndex = -1;
            }
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
                string query = "SELECT * FROM ThoiKhoaBieu";
                SqlCommand cmd = new SqlCommand(query, conn);
                dsTKB.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTKB, "ThoiKhoaBieu");
                if (dsTKB != null && dsTKB.Tables.Count > 0 && dsTKB.Tables["ThoiKhoaBieu"].Rows.Count > 0)
                {
                    dgvTKB.AutoGenerateColumns = true;
                    dgvTKB.DataSource = dsTKB.Tables[0];
                    dgvTKB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    txtTKB.Text = dsTKB.Tables[0].Rows[0]["MaTKB"].ToString();
                    txtMClass.Text = dsTKB.Tables[0].Rows[0]["MaLop"].ToString();
                    txtMGV.Text = dsTKB.Tables[0].Rows[0]["MaGV"].ToString();
                    cbMMH.SelectedValue = dsTKB.Tables[0].Rows[0]["MaMH"].ToString();
                    cbMP.SelectedValue = dsTKB.Tables[0].Rows[0]["MaPhong"].ToString();
                    cbThu.Text = dsTKB.Tables[0].Rows[0]["Thu"].ToString();
                    cbTBD.Text = dsTKB.Tables[0].Rows[0]["TietBatDau"].ToString();
                    cbTKT.Text = dsTKB.Tables[0].Rows[0]["TietKetThuc"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void SetInterface(string status)
        {
            if (Status == "Reset")
            {
                txtTKB.Enabled = false;
                txtMClass.Enabled = false;
                txtMGV.Enabled = false;
                cbMMH.Enabled = false;
                cbMP.Enabled = false;
                cbThu.Enabled = false;
                cbTBD.Enabled = false;
                cbTKT.Enabled = false;
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
                txtTKB.Enabled = false;
                txtMClass.Enabled = true;
                txtMGV.Enabled = true;
                cbMMH.Enabled = true;
                cbMP.Enabled = true;
                cbThu.Enabled = true;
                cbTBD.Enabled = true;
                cbTKT.Enabled = true;
                txtTim.Enabled = true;

                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnXoa.Enabled = false;
                btnSave.Enabled = true;
                btnHuy.Enabled = true;
                btnTim.Enabled = true;
                txtMClass.Text = "";
                txtMGV.Text = "";
            }
            else if (Status == "Edit")
            {
                txtTKB.Enabled = false;
                txtMClass.Enabled = true;
                txtMGV.Enabled = true;
                cbMMH.Enabled = true;
                cbMP.Enabled = true;
                cbThu.Enabled = true;
                cbTBD.Enabled = true;
                cbTKT.Enabled = true;
                txtTim.Enabled = true;

                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnXoa.Enabled = false;
                btnSave.Enabled = true;
                btnHuy.Enabled = true;
                btnTim.Enabled = true;
            }
        }
        private bool CheckTrungTKB(SqlConnection conn)
        {
            string maGV = txtMGV.Text.Trim();
            string maPhong = cbMP.Text.Trim();
            string thu = cbThu.Text.Trim();

            if (!int.TryParse(cbTBD.Text.Trim(), out int tietBD) ||
                !int.TryParse(cbTKT.Text.Trim(), out int tietKT))
            {
                MessageBox.Show("Tiết bắt đầu / kết thúc không hợp lệ!");
                return true; 
            }

            int? maTKB = null;
            if (Status == "Edit")
            {
                maTKB = int.Parse(txtTKB.Text);
            }

            SqlCommand cmd = new SqlCommand("sp_CheckTrungTKB", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MaTKB", (object)maTKB ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@MaGV", maGV);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);
            cmd.Parameters.AddWithValue("@Thu", thu);
            cmd.Parameters.AddWithValue("@TietBatDau", tietBD);
            cmd.Parameters.AddWithValue("@TietKetThuc", tietKT);

            string ketQua = cmd.ExecuteScalar().ToString();

            if (ketQua != "OK")
            {
                MessageBox.Show(ketQua, "Lỗi trùng lịch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }
        #endregion

        #region Events
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
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    string query = "DELETE FROM ThoiKhoaBieu WHERE MaTKB = @MaTKB";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaTKB", txtTKB.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa thời khoá biểu thành công!");
                        GetData();
                        Status = "Reset";
                        SetInterface(Status);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thời khoá biểu thất bại!");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
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
                    if (CheckTrungTKB(conn))
                        return;
                    if (Status == "Add")
                    {
                        string cmdInsert = "INSERT INTO ThoiKhoaBieu (MaLop, MaGV, MaMH, MaPhong, Thu, TietBatDau, TietKetThuc) VALUES (" +
                             "'" + txtMClass.Text.Trim() + "', " +
                             "'" + txtMGV.Text.Trim() + "', " +
                             "'" + cbMMH.SelectedValue + "', " +
                             "'" + cbMP.SelectedValue + "', " +
                             "N'" + cbThu.Text.Trim() + "', " +
                             "'" + cbTBD.Text.Trim() + "', " +
                             "'" + cbTKT.Text.Trim() + "')";
                        SqlCommand cmdInsertCommand = new SqlCommand(cmdInsert, conn);
                        var result = cmdInsertCommand.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm thời khoá biểu thành công!");
                            GetData();
                            Status = "Reset";
                            SetInterface(Status);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thời khoá biểu thất bại!");
                        }
                    }
                    else if (Status == "Edit")
                    {
                        string cmdUpdate = "UPDATE ThoiKhoaBieu SET MaLop = @MaLop, MaGV = @MaGV, MaMH = @MaMH, " +
                            "MaPhong = @MaPhong, Thu = @Thu, TietBatDau = @TietBD, TietKetThuc = @TietKT WHERE MaTKB = @MaTKB";
                        SqlCommand cmdUpdateCommand = new SqlCommand(cmdUpdate, conn);
                        cmdUpdateCommand.Parameters.AddWithValue("@MaLop", txtMClass.Text);
                        cmdUpdateCommand.Parameters.AddWithValue("@MaGV", txtMGV.Text);
                        cmdUpdateCommand.Parameters.AddWithValue("@MaMH", cbMMH.SelectedValue);
                        cmdUpdateCommand.Parameters.AddWithValue("@MaPhong", cbMP.SelectedValue);
                        cmdUpdateCommand.Parameters.AddWithValue("@Thu", cbThu.Text);
                        cmdUpdateCommand.Parameters.AddWithValue("@TietBD", cbTBD.Text);
                        cmdUpdateCommand.Parameters.AddWithValue("@TietKT", cbTKT.Text);
                        cmdUpdateCommand.Parameters.AddWithValue("@MaTKB", txtTKB.Text);
                        var result = cmdUpdateCommand.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Cập nhật thời khoá biểu thành công!");
                            GetData();
                            Status = "Reset";
                            SetInterface(Status);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thời khoá biểu thất bại!");
                        }
                    }
                    conn.Close();
                }
            } catch (Exception ex)
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

        private void dgvTKB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvTKB.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvTKB.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvTKB.Rows[selectedrowindex];
                txtTKB.Text = Convert.ToString(selectedRow.Cells["MaTKB"].Value);
                txtMClass.Text = Convert.ToString(selectedRow.Cells["MaLop"].Value);
                txtMGV.Text = Convert.ToString(selectedRow.Cells["MaGV"].Value);
                cbMMH.SelectedValue = Convert.ToString(selectedRow.Cells["MaMH"].Value);
                cbMP.SelectedValue = Convert.ToString(selectedRow.Cells["MaPhong"].Value);
                cbThu.Text = Convert.ToString(selectedRow.Cells["Thu"].Value);
                cbTBD.Text = Convert.ToString(selectedRow.Cells["TietBatDau"].Value);
                cbTKT.Text = Convert.ToString(selectedRow.Cells["TietKetThuc"].Value);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string sql = "SELECT * FROM ThoiKhoaBieu WHERE MaLop LIKE @search OR MaGV LIKE @search";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@search", "%" + txtTim.Text.Trim() + "%");
                dsTKB.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsTKB, "ThoiKhoaBieu");

                dgvTKB.AutoGenerateColumns = true;
                dgvTKB.DataSource = dsTKB.Tables["ThoiKhoaBieu"];

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
