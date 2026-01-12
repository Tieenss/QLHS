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
    public partial class FrmQuanlyThongbao : Form
    {
        #region
        string connectionString = @"Data Source= .\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;" +
            "TrustServerCertificate = True; Trusted_Connection = True";
        DataSet ds = new DataSet();
        string Status = "Reset";
        #endregion

        public FrmQuanlyThongbao()
        {
            InitializeComponent();
            dgvThongbao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            labelTieude.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;

            grbTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnTimkiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            grbDanhsachTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvThongbao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            grbThongtin.Anchor = AnchorStyles.Bottom;

            btnThem.Anchor = AnchorStyles.Bottom;
            btnSua.Anchor = AnchorStyles.Bottom;
            btnXoa.Anchor = AnchorStyles.Bottom;
            btnLuu.Anchor = AnchorStyles.Bottom;
            btnCancel.Anchor = AnchorStyles.Bottom;
        }

        private void FrmQuanlyThongbao_Load(object sender, EventArgs e)
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
                    string query = "SELECT * FROM ThongBao";

                    if (!string.IsNullOrEmpty(searchKeyword))
                    {
                        query += " WHERE MaTB LIKE @key OR TieuDe LIKE @key OR NguoiGui LIKE @key";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (!string.IsNullOrEmpty(searchKeyword))
                        cmd.Parameters.AddWithValue("@key", "%" + searchKeyword + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvThongbao.AutoGenerateColumns = false;
                    dgvThongbao.DataSource = null;
                    dgvThongbao.DataSource = dt;   

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
            txtMaTB.Text = row["MaTB"].ToString();
            txtTieude.Text = row["TieuDe"].ToString();
            txtNguoigui.Text = row["NguoiGui"].ToString();
            txtNoidung.Text = row["NoiDung"].ToString();
        }

        public void SetInterface(string status)
        {
            if(status == "Reset")
            {
                txtMaTB.Enabled = false;
                txtTieude.Enabled = false;
                txtNoidung.Enabled = false;
                txtNguoigui.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnCancel.Enabled = true;
            }
            else if(status == "Add")
            {
                txtMaTB.Enabled = false;
                txtTieude.Enabled = true;
                txtNoidung.Enabled = true;
                txtNguoigui.Enabled = true;

                txtMaTB.Text = "";
                txtTieude.Text = "";
                txtNoidung.Text = "";
                txtNguoigui.Text = "";

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnCancel.Enabled = true;
            }
            else if(status == "Edit")
            {
                txtMaTB.Enabled = false;
                txtTieude.Enabled = true;
                txtNoidung.Enabled = true;
                txtNguoigui.Enabled = true;

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
            if (string.IsNullOrEmpty(txtMaTB.Text))
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }
            Status = "Edit";
            SetInterface(Status);
            txtMaTB.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaTB.Text)) return;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xoá?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM ThongBao WHERE MaTB = @MaTB";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MaTB", txtMaTB.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Xoá thành công!");
                    GetData();
                }
                catch (Exception ex)
                {
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
                            @"INSERT INTO ThongBao (TieuDe, NguoiGui, NoiDung) 
                            VALUES (@TieuDe, @NguoiGui, @NoiDung)", conn);
                    }
                    else 
                    {
                        cmd = new SqlCommand(
                            @"UPDATE ThongBao SET TieuDe=@TieuDe, NguoiGui=@NguoiGui, NoiDung=@NoiDung 
                             WHERE MaTB=@MaTB", conn);
                    }
                    cmd.Parameters.AddWithValue("@MaTB", txtMaTB.Text.Trim());
                    cmd.Parameters.AddWithValue("@TieuDe", txtTieude.Text.Trim());
                    cmd.Parameters.AddWithValue("@NguoiGui", txtNguoigui.Text.Trim());
                    cmd.Parameters.AddWithValue("@NoiDung", txtNoidung.Text.Trim());
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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
           GetData(txtTimkiem.Text.Trim());
        }

        private void dgvThongbao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvThongbao.Rows[e.RowIndex];
                txtMaTB.Text = row.Cells[0].Value?.ToString();
                txtTieude.Text = row.Cells[1].Value?.ToString();
                txtNguoigui.Text = row.Cells[2].Value?.ToString();
                txtNoidung.Text = row.Cells[3].Value?.ToString();
            }
        }
    }
}
