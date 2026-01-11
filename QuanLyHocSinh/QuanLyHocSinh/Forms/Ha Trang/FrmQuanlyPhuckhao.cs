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

namespace BaiKTcuoiky
{
    public partial class FrmQuanlyPhuckhao : Form
    {
        #region
        string connectionString = @"Data Source= .\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;" +
            "TrustServerCertificate = True; Trusted_Connection = True";
        DataSet ds = new DataSet();
        string Status = "Reset";
        #endregion

        public FrmQuanlyPhuckhao()
        {
            InitializeComponent();
            dgvPhuckhao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            labelTieude.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;

            grbTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            grbDanhsachPK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhuckhao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            grbThongtin.Anchor = AnchorStyles.Bottom;

            btnThem.Anchor = AnchorStyles.Bottom;
            btnSua.Anchor = AnchorStyles.Bottom;
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnLuu.Anchor = AnchorStyles.Bottom;
            btnCancel.Anchor = AnchorStyles.Bottom;
        }

        private void FrmQuanlyPhuckhao_Load(object sender, EventArgs e)
        {
            Status = "Reset";
            SetInterface(Status);
            GetData();
        }

        #region Public functions

        public void GetData(string searchKeyword = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM PhucKhao"; 

                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        query += " WHERE MaHS LIKE @key OR MaMH LIKE @key";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(searchKeyword))
                        cmd.Parameters.AddWithValue("@key", "%" + searchKeyword + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvPhuckhao.AutoGenerateColumns = false;
                    dgvPhuckhao.DataSource = null; // Xóa nguồn cũ
                    dgvPhuckhao.DataSource = dt;   // Gán nguồn mới

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
            txtMhs.Text = row["MaHS"].ToString();
            cboTrangThai.Text = row["TrangThai"].ToString();
            cboMaMH.Text = row["MaMH"].ToString();
            txtLydo.Text = row["LyDo"].ToString();
        }

        public void SetInterface(string status)
        {
            if (status == "Reset")
            {
                cboMaMH.Enabled = false;
                txtLydo.Enabled = false;
                txtMhs.Enabled = false;
                cboTrangThai.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnCancel.Enabled = true;
            }
            else if (status == "Add")
            {
                cboMaMH.Enabled = true;
                txtLydo.Enabled = true;
                txtMhs.Enabled = true;
                cboTrangThai.Enabled = true;

                txtMhs.Text = "";
                txtLydo.Text = "";
                cboTrangThai.Text = "";
                cboTrangThai.SelectedIndex = -1;
                cboMaMH.SelectedIndex = -1;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnCancel.Enabled=true;
            }
            else if(status == "Edit")
            {
                cboMaMH.Enabled = false;
                txtLydo.Enabled = true;
                txtMhs.Enabled = true;
                cboTrangThai.Enabled = true;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnCancel.Enabled = true;
            }
        }

        #endregion

        private void btnThem_Click(object sender, EventArgs e)
        {
            Status = "Add";
            SetInterface(Status);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMhs.Text)) {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }
            Status = "Edit";
            SetInterface(Status);
            txtMhs.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMhs.Text)) return;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM PhucKhao WHERE MaHS = @MaHS";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaHS", txtMhs.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xoá thành công!");
                    GetData();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
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
                            @"INSERT INTO PhucKhao (MaHS, MaMH, LyDo, TrangThai)
                            VALUES (@MaHS, @MaMH, @LyDo,@TrangThai)", conn);
                    }
                    else if (Status == "Edit")
                    {
                        cmd = new SqlCommand(@"UPDATE PhucKhao SET
                        MaMH = @MaMH, LyDo = @LyDo, TrangThai = @TrangThai
                        Where MaHS = @MaHS", conn);
                    }
                    else return;

                    cmd.Parameters.AddWithValue("@MaHS", txtMhs.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaMH",cboMaMH.Text.Trim());
                    cmd.Parameters.AddWithValue("@LyDo",txtLydo.Text.Trim());
                    cmd.Parameters.AddWithValue("@TrangThai",cboTrangThai.Text.Trim());
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Status = "Reset";
            SetInterface(Status);
            GetData();
            txtTimkiem.Clear();
        }

        private void dgvPhuckhao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPhuckhao.Rows[e.RowIndex];
                txtMhs.Text = row.Cells["MaHS"].Value?.ToString() ?? "";
                cboMaMH.Text = row.Cells["MaMH"].Value?.ToString() ?? "";
                txtLydo.Text = row.Cells["LyDo"].Value?.ToString() ?? "";
                cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString() ?? "";
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimkiem.Text.Trim();
            GetData(keyword);
        }
    }
}
