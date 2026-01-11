using BaiKTcuoiky;
using Baitaplon.Đại;
using qlhocsinh;

using QuanLyHocSinh;
using QuanLyHocSinh.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyHocSinh.zMainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.Hide();

            
            FrmDangNhap frmLogin = new FrmDangNhap();
            DialogResult result = frmLogin.ShowDialog();

            if (result == DialogResult.OK)
            {
                
                this.Show();
            }
            else
            {
                
                Application.Exit();
            }
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void hệThốngVàChínhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //dai
        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQlyhocsinh f = new frmQlyhocsinh();
            f.Show();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQlytaikhoan f = new frmQlytaikhoan();
            f.Show();
        }

        private void quảnLýĐốiTượngƯuTiênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQlydoituong f = new frmQlydoituong();
            f.Show();
        }

        //dat
        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlylop f = new quanlylop();
            f.Show();
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanLyGiaoVien f = new FrmQuanLyGiaoVien();
            f.Show();
        }

        private void quảnLýTổBộMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmToBoMon f = new FrmToBoMon();  
            f.Show();
        }
        
        //thu trang
        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMonHoc f = new FrmMonHoc();
            f.Show();
        }

        private void thờiKhóaBiểuVàLịchDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTKB f = new FrmTKB();
            f.Show();
        }

        private void phòngHọcVàThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhonghoc f = new FrmPhonghoc();
            f.Show();
        }

        //Tien
        private void quảnLýĐiểmSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanLyDiem f = new FrmQuanLyDiem();
            f.Show();
        }

        private void hạnhKiểmVàRènLuyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanLyHanhKiem f = new FrmQuanLyHanhKiem();
            f.Show();
        }

        private void lịchThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLichThi f = new FrmLichThi();
            f.Show();
        }

        private void quảnLýHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanlyHocphi f = new FrmQuanlyHocphi();
            f.Show();
        }

        private void quảnLýThôngBáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanlyThongbao f = new FrmQuanlyThongbao();
            f.Show();
        }

        private void quảnLýPhúcKhảoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuanlyPhuckhao f = new FrmQuanlyPhuckhao();
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide(); 
                FrmDangNhap frmLogin = new FrmDangNhap();
                DialogResult result = frmLogin.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.Show(); 
                }
                else
                {
                    Application.Exit(); 
                }
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
