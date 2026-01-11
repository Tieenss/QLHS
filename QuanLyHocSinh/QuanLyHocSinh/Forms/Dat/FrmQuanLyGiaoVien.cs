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

namespace QuanLyHocSinh.Forms
{
    public partial class FrmQuanLyGiaoVien : Form
    {
        string connectionString = @"Data Source= .\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;" +
            "TrustServerCertificate = True; Trusted_Connection = True";
        DataSet ds = new DataSet();
        string status = "Reset";
        public FrmQuanLyGiaoVien()
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

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = @"
                                        SELECT gv.*, th.TenToHop
                                        FROM GiaoVien gv
                                        LEFT JOIN ToHopMon th 
                                            ON gv.MaToHop = th.MaToHop;
                                    ";

                        SqlDataAdapter da = new SqlDataAdapter(query, conn);
                        da.Fill(ds);
                    }

                    if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    {
                        dgvgiaovien.AutoGenerateColumns = false;
                        dgvgiaovien.DataSource = ds.Tables[0];

                        DataRow row = ds.Tables[0].Rows[0];

                        txtMaGV.Text = row["MaGV"].ToString();
                        txtHoTen.Text = row["HoTen"].ToString();
                        txtSĐT.Text = row["SDT"].ToString();

                        if (row["NgaySinh"] != DBNull.Value)
                            dtpNgaySinh.Value = Convert.ToDateTime(row["NgaySinh"]);

                        if (ds.Tables[0].Rows[0]["GioiTinh"].ToString() == "0")
                    {
                        rdNam.Checked = true;
                    }
                        else
                    {
                        rdNu.Checked = true;
                    }    
                        cbToBoMon.SelectedValue = row["MaToHop"];   
                        txtDiaChi.Text = row["DiaChi"].ToString();  
                }
                    else
                    {
                        dgvgiaovien.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi load dữ liệu giáo viên: " + ex.Message);
                }
            
            }

        public void SetInterface(string status)
        {
            if(status == "Reset")
            {
                txtHoTen.Enabled = false;
                txtMaGV.Enabled = false;
                txtSĐT.Enabled = false;
                txtDiaChi.Enabled = false;
                rdNam.Enabled = false;
                rdNu.Enabled = false;
                dtpNgaySinh.Enabled = false;
                cbToBoMon.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                loadcombobox();
            }

            else if(status == "Add")
            {
                txtHoTen.Enabled = true;
                txtMaGV.Enabled = true;
                txtSĐT.Enabled = true;
                dtpNgaySinh.Enabled = true;
                cbToBoMon.Enabled = true;
                txtDiaChi.Enabled = true;
                rdNam.Enabled = true;   
                rdNu.Enabled = true;    
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;

                loadcombobox();
                ClearData(); 


            }
            else if (status == "Edit")
            {
                txtHoTen.Enabled = true;
                txtMaGV.Enabled = true;
                txtSĐT.Enabled = true;
                dtpNgaySinh.Enabled = true;
                cbToBoMon.Enabled = true;
                txtDiaChi.Enabled = true;
                rdNam.Enabled = true;
                rdNu.Enabled = true;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
        }
        public void ClearData()
        {
            txtHoTen.Text = "";
            txtMaGV.Text = "";
            txtSĐT.Text = "";
            txtDiaChi.Text = "";
            rdNam.Checked = true;
            rdNu.Checked = false;
            dtpNgaySinh.Value = DateTime.Now;
            cbToBoMon.SelectedIndex = -1;
        }
        public void loadcombobox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaToHop, TenToHop FROM ToHopMon";

                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cbToBoMon.DataSource = dt;
                        cbToBoMon.DisplayMember = "TenToHop";
                        cbToBoMon.ValueMember = "MaToHop";
                        cbToBoMon.SelectedIndex = -1; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load tổ bộ môn: " + ex.Message);
            }
        }

        private void quanlygiaovien_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa Giáo Viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                        string query = "delete from GiaoVien where MaGV= '" + txtMaGV.Text.Trim() + "'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        var result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Xóa giáo viên thành công!", "Thông báo");
                            GetData();
                            status = "Reset";
                            SetInterface(status);
                        }
                        else
                        {
                            MessageBox.Show("Xóa giáo viên thất bại!", "Thông báo");
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

                    string gioitinh = rdNam.Checked ? "Nam" : "Nữ";

                    if (status == "Add")
                    {
                        string sql = "INSERT INTO GiaoVien (MaGV, HoTen, NgaySinh, GioiTinh, SDT, MaToHop, DiaChi) " +
                                     "VALUES (@MaGV, @HoTen, @NgaySinh, @GioiTinh, @SDT, @MaToHop, @DiaChi)";

                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@MaGV", txtMaGV.Text);
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
                        cmd.Parameters.AddWithValue("@SDT", txtSĐT.Text);
                        cmd.Parameters.AddWithValue("@MaToHop", cbToBoMon.SelectedValue);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);

                        int kq = cmd.ExecuteNonQuery();
                        if(kq > 0)
                        {
                            MessageBox.Show("Thêm giáo viên thành công");
                            GetData();
                            status = "Reset";
                            SetInterface(status);
                        }

                        else
                        {
                            MessageBox.Show("Thêm giáo viên thất bại");
                        }
                    }

                    else if(status == "Edit")
                    {
                        string sql = "UPDATE GiaoVien " +
                                     "SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, " +
                                     "SDT = @SDT, MaToHop = @MaToHop, DiaChi = @DiaChi " +
                                     "WHERE MaGV = @MaGV";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@MaGV", txtMaGV.Text);
                        cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                        cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
                        cmd.Parameters.AddWithValue("@SDT", txtSĐT.Text);
                        cmd.Parameters.AddWithValue("@MaToHop", cbToBoMon.SelectedValue);
                        cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                        int kq = cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Cập nhật giáo viên thành công");
                            GetData();
                            status = "Reset";
                            SetInterface(status);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật giáo viên thất bại");
                        }
                    }   
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu!" + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            status = "Reset";   
            SetInterface(status);
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
                                    SELECT gv.*, th.TenToHop
                                    FROM GiaoVien gv
                                    LEFT JOIN ToHopMon th 
                                        ON gv.MaToHop = th.MaToHop
                                    WHERE gv.HoTen     LIKE N'%' + @keyword + '%'
                                       OR gv.MaGV      LIKE N'%' + @keyword + '%'
                                       OR gv.SDT       LIKE N'%' + @keyword + '%'
                                       OR th.MaToHop   LIKE N'%' + @keyword + '%'
                                       OR gv.DiaChi    LIKE N'%' + @keyword + '%'
                                       OR gv.GioiTinh  LIKE N'%' + @keyword + '%'
                                ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@keyword", keyword); 

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvgiaovien.AutoGenerateColumns = false;
                    dgvgiaovien.DataSource = ds.Tables[0];

                    DataRow row = ds.Tables[0].Rows[0];
                    txtMaGV.Text = row["MaGV"].ToString();
                    txtHoTen.Text = row["HoTen"].ToString();
                    txtSĐT.Text = row["SDT"].ToString();
                    txtDiaChi.Text = row["DiaChi"].ToString();

                    if (row["NgaySinh"] != DBNull.Value)
                        dtpNgaySinh.Value = Convert.ToDateTime(row["NgaySinh"]);

                    cbToBoMon.SelectedValue = row["MaToHop"];

                    
                    string gioiTinh = row["GioiTinh"].ToString();
                    rdNam.Checked = gioiTinh == "Nam";
                    rdNu.Checked = gioiTinh == "Nữ";
                }
                else
                {
                    dgvgiaovien.DataSource = null;
                    MessageBox.Show("Không tìm thấy giáo viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 

            DataGridViewRow row = dgvgiaovien.Rows[e.RowIndex];
            txtMaGV.Text = row.Cells["MaGV"].Value.ToString();
            txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
            txtSĐT.Text = row.Cells["SDT"].Value.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            if (row.Cells["NgaySinh"].Value != DBNull.Value)
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            string gioitinh = row.Cells["GioiTinh"].Value.ToString();

            if (gioitinh == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            cbToBoMon.SelectedValue = row.Cells["MaToHop"].Value;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            status = "Reset";
            SetInterface(status);
            GetData();
        }
    }
}
