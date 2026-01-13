using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaiKTcuoiky;
using Baitaplon;
using QuanLyHocSinh.Forms;
using QuanLyHocSinh;
using QuanLyHocSinh.zMainForm;


namespace QuanLyHocSinh
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
