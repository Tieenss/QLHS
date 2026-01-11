using System;
using System.Windows.Forms;
using QuanLyHocSinh.Database; 

namespace QuanLyHocSinh.Forms
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '*'; 
            this.StartPosition = FormStartPosition.CenterScreen; 
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            string sql = string.Format("SELECT * FROM TaiKhoan WHERE TenDangNhap = '{0}' AND MatKhau = '{1}'",
                                        txtTaiKhoan.Text, txtMatKhau.Text);

            System.Data.DataTable dt = DatabaseHelper.GetData(sql);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}