using System;
using System.Data;
using System.Windows.Forms;
using QuanLyHocSinh.Database;

namespace QuanLyHocSinh.Forms
{
    public partial class FrmLichThi : Form
    {
     
        public FrmLichThi()
        {
            InitializeComponent();
        }
  

       
        private void FrmLichThi_Load(object sender, EventArgs e)
        {
            LoadComboboxData(); 
            LoadData(); 
        }

        private void LoadComboboxData()
        {
            try
            {
                
                DataTable dtMon = DatabaseHelper.GetData("SELECT MaMH, TenMH FROM MonHoc");
                cbMonHoc.DataSource = dtMon;
                cbMonHoc.DisplayMember = "TenMH"; 
                cbMonHoc.ValueMember = "MaMH";    

                
                DataTable dtPhong = DatabaseHelper.GetData("SELECT MaPhong, TenPhong FROM PhongHoc");
                cbMaPhong.DataSource = dtPhong;
                cbMaPhong.DisplayMember = "TenPhong";
                cbMaPhong.ValueMember = "MaPhong";

                
                DataTable dtLop = DatabaseHelper.GetData("SELECT MaLop, TenLop FROM Lop");
                cbTenLop.DataSource = dtLop;
                cbTenLop.DisplayMember = "TenLop";
                cbTenLop.ValueMember = "MaLop";

               
                DataTable dtGV = DatabaseHelper.GetData("SELECT MaGV, HoTen FROM GiaoVien");
                cbGiamThi.DataSource = dtGV;
                cbGiamThi.DisplayMember = "HoTen"; 
                cbGiamThi.ValueMember = "MaGV";    

                
                if (cbKyThi.Items.Count == 0)
                {
                    cbKyThi.Items.Add("Giữa Kỳ 1");
                    cbKyThi.Items.Add("Cuối Kỳ 1");
                    cbKyThi.Items.Add("Giữa Kỳ 2");
                    cbKyThi.Items.Add("Cuối Kỳ 2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load danh mục: " + ex.Message);
            }
        }


        private void LoadData(string condition = "")
        {

            string query = @"SELECT lt.*, mh.TenMH, ph.TenPhong, l.TenLop, gv.HoTen AS TenGiamThi 
                     FROM LichThi lt
                     LEFT JOIN MonHoc mh ON lt.MaMH = mh.MaMH
                     LEFT JOIN PhongHoc ph ON lt.MaPhong = ph.MaPhong
                     LEFT JOIN Lop l ON lt.MaLop = l.MaLop
                     LEFT JOIN GiaoVien gv ON lt.MaGT = gv.MaGV";


            query += string.IsNullOrEmpty(condition) ? "" : " WHERE " + condition;
            query += " ORDER BY lt.NgayThi DESC, lt.GioBatDau ASC";

            DataTable dt = DatabaseHelper.GetData(query);
            dgvLichThi.DataSource = dt;
            
        }
       

       
        private void ClearInputs()
        {
            txtMaLT.Text = "";
            cbKyThi.SelectedIndex = -1;

            cbMonHoc.SelectedIndex = -1;
            cbMaPhong.SelectedIndex = -1;
            cbTenLop.SelectedIndex = -1;
            cbGiamThi.SelectedIndex = -1;

            dtpNgayThi.Value = DateTime.Now;
            
            dtpGioBatDau.Value = DateTime.Parse("07:30");
            dtpGioKetThuc.Value = DateTime.Parse("09:00");

            txtSearch.Text = "";
        }


        private void dgvLichThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                DataGridViewRow row = dgvLichThi.Rows[e.RowIndex];

                txtMaLT.Text = row.Cells["colMaLT"].Value?.ToString();
                cbKyThi.Text = row.Cells["colTenKyThi"].Value?.ToString();

                cbMonHoc.SelectedValue = row.Cells["colMaMH"].Value;
                cbMaPhong.SelectedValue = row.Cells["colMaPhong"].Value;

                cbTenLop.Text = row.Cells["colTenLop"].Value?.ToString();

                cbGiamThi.Text = row.Cells["colGiamThi"].Value?.ToString();

                if (row.Cells["colNgayThi"].Value != DBNull.Value)
                {
                    dtpNgayThi.Value = Convert.ToDateTime(row.Cells["colNgayThi"].Value);
                }
                dtpGioBatDau.Text = row.Cells["colGioBatDau"].Value?.ToString();
                dtpGioKetThuc.Text = row.Cells["colGioKetThuc"].Value?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị: " + ex.Message);
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbMonHoc.SelectedValue == null || cbMaPhong.SelectedValue == null ||
                    cbTenLop.SelectedValue == null || cbGiamThi.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ Môn, Phòng, Lớp và Giám thị!");
                    return;
                }

                string ngay = dtpNgayThi.Value.ToString("yyyy-MM-dd");
                string gioBD = dtpGioBatDau.Value.ToString("HH:mm");
                string gioKT = dtpGioKetThuc.Value.ToString("HH:mm");
                string maMH = cbMonHoc.SelectedValue.ToString();
                string maPhong = cbMaPhong.SelectedValue.ToString();
                string maLop = cbTenLop.SelectedValue.ToString();
                string maGT = cbGiamThi.SelectedValue.ToString();

                if (string.Compare(gioKT, gioBD) <= 0)
                {
                    MessageBox.Show("Giờ kết thúc phải lớn hơn giờ bắt đầu!");
                    return;
                }

                string checkResult = CheckTrungLich(ngay, gioBD, gioKT, maPhong, maLop, maGT, "NULL");
                if (checkResult != "OK")
                {
                    MessageBox.Show(checkResult, "Trùng lịch!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                string sql = string.Format(
                    "INSERT INTO LichThi (TenKyThi, MaMH, NgayThi, GioBatDau, GioKetThuc, MaPhong, MaLop, MaGT) VALUES (N'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                    cbKyThi.Text, maMH, ngay, gioBD, gioKT, maPhong, maLop, maGT
                );

                DatabaseHelper.ExecuteSql(sql);
                MessageBox.Show("Thêm mới thành công!");
                LoadData();
                ClearInputs();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

  
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaLT.Text))
                {
                    MessageBox.Show("Vui lòng chọn lịch thi cần cập nhật từ danh sách!");
                    return;
                }

                string maLT = txtMaLT.Text;
                string ngay = dtpNgayThi.Value.ToString("yyyy-MM-dd");
                string gioBD = dtpGioBatDau.Value.ToString("HH:mm");
                string gioKT = dtpGioKetThuc.Value.ToString("HH:mm");
                             
                string maMH = cbMonHoc.SelectedValue.ToString();
                string maPhong = cbMaPhong.SelectedValue.ToString();
                string maLop = cbTenLop.SelectedValue.ToString();
                string maGT = cbGiamThi.SelectedValue.ToString();

                if (maMH == null || maPhong == null || maLop == null || maGT == null)
                {
                    MessageBox.Show("Dữ liệu chọn không hợp lệ!"); return;
                }

                if (string.Compare(gioKT, gioBD) <= 0)
                {
                    MessageBox.Show("Giờ lỗi: Kết thúc phải sau Bắt đầu");
                    return;
                }

                string checkResult = CheckTrungLich(ngay, gioBD, gioKT, maPhong, maLop, maGT, maLT);
                if (checkResult != "OK")
                {
                    MessageBox.Show(checkResult, "Không thể cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string sql = string.Format(
                    "UPDATE LichThi SET TenKyThi=N'{0}', MaMH='{1}', NgayThi='{2}', GioBatDau='{3}', GioKetThuc='{4}', MaPhong='{5}', MaLop='{6}', MaGT='{7}' WHERE MaLT={8}",
                    cbKyThi.Text, maMH, ngay, gioBD, gioKT, maPhong, maLop, maGT, maLT
                );

                
                DatabaseHelper.ExecuteSql(sql);
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

      
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaLT.Text))
                {
                    MessageBox.Show("Vui lòng chọn lịch thi cần xóa!");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc muốn xóa lịch thi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DatabaseHelper.ExecuteSql("DELETE FROM LichThi WHERE MaLT=" + txtMaLT.Text);
                    MessageBox.Show("Xóa thành công!");
                    LoadData();
                    ClearInputs();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

  
        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(key))
            {
             
                string condition = string.Format("TenKyThi LIKE N'%{0}%' OR MaMH LIKE '%{0}%'", key);
                LoadData(condition);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData();
        }



        
        private string CheckTrungLich(string ngayThi, string gioBD, string gioKT, string maPhong, string maLop, string maGT, string maLT_HienTai = "NULL")
        {
            
            string sql = string.Format("EXEC sp_CheckTrungLichThi '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}",
                ngayThi, gioBD, gioKT, maPhong, maLop, maGT, maLT_HienTai);

            DataTable dt = DatabaseHelper.GetData(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return dt.Rows[0][0].ToString();
            }
            return "Lỗi kết nối cơ sở dữ liệu hoặc không có phản hồi!";
        }
      
        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportToExcel(dgvLichThi, "DanhSachLichThi");
        }
    }
}