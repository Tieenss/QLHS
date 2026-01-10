using System;
using System.CodeDom;
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
    public partial class FrmPhonghoc : Form
    {
        #region Variables
        string connectionString = @"Data Source= .\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;" +
            "TrustServerCertificate = True; Trusted_Connection = True";
        DataSet dsPhong = new DataSet();
        string Status = "Reset";
        #endregion
        public FrmPhonghoc()
        {
            InitializeComponent();
            dgvPhong.AutoGenerateColumns = true;
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.RowHeadersVisible = true;
            dgvPhong.RowHeadersWidth = 30;
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
                string query = "SELECT * FROM PhongHoc";
                SqlCommand cmd = new SqlCommand(query, conn);
                dsPhong.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPhong);
                if (dsPhong != null && dsPhong.Tables.Count > 0 && dsPhong.Tables[0].Rows.Count > 0)
                {
                    dgvPhong.AutoGenerateColumns = true;
                    dgvPhong.DataSource = dsPhong.Tables[0];
                    dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    txtMa.Text = dsPhong.Tables[0].Rows[0]["MaPhong"].ToString();
                    txtTen.Text = dsPhong.Tables[0].Rows[0]["TenPhong"].ToString();
                    txtSC.Text = dsPhong.Tables[0].Rows[0]["SucChua"].ToString();
                    cbLoaip.Text = Convert.ToString(dsPhong.Tables[0].Rows[0]["LoaiPhong"]);
                    cbTinht.Text = Convert.ToString(dsPhong.Tables[0].Rows[0]["TinhTrang"]);
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
                txtMa.Enabled = false;
                txtTen.Enabled = false;
                txtSC.Enabled = false;
                cbLoaip.Enabled = false;
                cbTinht.Enabled = false;
                txtTim.Enabled = true;
                cbLoai.Enabled = true;
                cbTinh.Enabled = true;
                 
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
                txtSC.Enabled = true;
                cbLoaip.Enabled = true;
                cbTinht.Enabled = true;
                txtTim.Enabled = true;
                cbLoai.Enabled = true;
                cbTinh.Enabled = true;

                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnXoa.Enabled = false;
                btnSave.Enabled = true;
                btnHuy.Enabled = true;
                btnTim.Enabled = true;
                txtMa.Text = "";
                txtTen.Text = "";
                txtSC.Text = "";
                txtMa.Focus();
            }
            else if (Status == "Edit")
            {
                txtMa.Enabled = false;
                txtTen.Enabled = true;
                txtSC.Enabled = true;
                cbLoaip.Enabled = true;
                cbTinht.Enabled = true;
                txtTim.Enabled = true;
                cbLoai.Enabled = true;
                cbTinh.Enabled = true;

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
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng học này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    string query = "DELETE FROM PhongHoc WHERE MaPhong = '" + txtMa.Text.Trim() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa phòng học thành công!");
                        GetData();
                        Status = "Reset";
                        SetInterface(Status);
                    }
                    else
                    {
                        MessageBox.Show("Xóa phòng học thất bại!");
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
                    if (Status == "Add")
                    {
                        string cmdInsert = "INSERT INTO PhongHoc (MaPhong, TenPhong, SucChua, LoaiPhong, TinhTrang) VALUES (" +
                            "'" + txtMa.Text.Trim() + "', " +
                            "N'" + txtTen.Text.Trim() + "', " +
                            "'" + txtSC.Text.Trim() + "', " +
                            "N'" + cbLoaip.SelectedItem.ToString() + "', " +
                            "N'" + cbTinht.SelectedItem.ToString() + "')";
                        SqlCommand cmdInsertCommand = new SqlCommand(cmdInsert, conn);
                        var resultInsert = cmdInsertCommand.ExecuteNonQuery();
                        if (resultInsert > 0)
                        {
                            MessageBox.Show("Thêm phòng học thành công!");
                            GetData();
                            Status = "Add";
                            SetInterface(Status);
                        }
                        else
                        {
                            MessageBox.Show("Thêm phòng học thất bại!");
                        }
                    }
                    else if (Status == "Edit")
                    {
                        string cmdUpdate = "UPDATE PhongHoc SET TenPhong = @TenPH, SucChua = @SucChua, LoaiPhong = @LoaiPhong, TinhTrang = @TinhTrang WHERE MaPhong = @MaPH";
                        SqlCommand cmdUpdateCommand = new SqlCommand(cmdUpdate, conn);
                        cmdUpdateCommand.Parameters.AddWithValue("@TenPH", txtTen.Text.Trim());
                        cmdUpdateCommand.Parameters.AddWithValue("@SucChua", txtSC.Text.Trim());
                        cmdUpdateCommand.Parameters.AddWithValue("@LoaiPhong", cbLoaip.Text.Trim());
                        cmdUpdateCommand.Parameters.AddWithValue("@TinhTrang", cbTinht.Text.Trim());
                        cmdUpdateCommand.Parameters.AddWithValue("@MaPH", txtMa.Text.Trim());
                        var resultUpdate = cmdUpdateCommand.ExecuteNonQuery();
                        if (resultUpdate > 0)
                        {
                            MessageBox.Show("Cập nhật phòng học thành công!");
                            GetData();
                            Status = "Reset";
                            SetInterface(Status);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật phòng học thất bại!");
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

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPhong.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPhong.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPhong.Rows[selectedrowindex];
                txtMa.Text = Convert.ToString(selectedRow.Cells["MaPhong"].Value);
                txtTen.Text = Convert.ToString(selectedRow.Cells["TenPhong"].Value);
                txtSC.Text = Convert.ToString(selectedRow.Cells["SucChua"].Value);
                cbLoaip.Text = Convert.ToString(selectedRow.Cells["LoaiPhong"].Value);
                cbTinht.Text= Convert.ToString(selectedRow.Cells["TinhTrang"].Value);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string sql = "SELECT * FROM PhongHoc WHERE 1=1";
                if (!string.IsNullOrEmpty(txtTim.Text.Trim()))
                {
                    sql += " AND (MaPhong LIKE '%" + txtTim.Text.Trim() + "%' OR TenPhong LIKE N'%" + txtTim.Text.Trim() + "%')";
                }
                if (cbLoai.SelectedItem != null && !string.IsNullOrEmpty(cbLoai.Text))
                {
                    sql += " AND LoaiPhong = N'" + cbLoai.Text.Trim() + "'";
                }
                if (cbTinh.SelectedItem != null && !string.IsNullOrEmpty(cbTinh.Text))
                {
                    sql += " AND TinhTrang = N'" + cbTinh.Text.Trim() + "'";
                }
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsPhong.Clear();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dsPhong);
                if (dsPhong != null && dsPhong.Tables.Count > 0 && dsPhong.Tables[0].Rows.Count > 0)
                {
                    dgvPhong.AutoGenerateColumns = true;
                    dgvPhong.DataSource = dsPhong.Tables[0];
                    dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    dgvPhong.DataSource = null;
                    MessageBox.Show("Không tìm thấy phòng học phù hợp!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        #endregion
    }
}