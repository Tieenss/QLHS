using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyHocSinh.Database
{
    public class DatabaseHelper
    {
        // CẤU HÌNH KẾT NỐI 
        // Lưu ý: Đảm bảo SQL Server của bạn cho phép đăng nhập bằng tài khoản sa
        private static string strCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;User ID=sa;Password=123456";

        // Hàm lấy dữ liệu (SELECT) -> Trả về DataTable
        public static DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
            }
            return dt;
        }

        // Hàm thực thi lệnh (INSERT, UPDATE, DELETE) -> Không trả về dữ liệu
        public static void ExecuteSql(string sql)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi lệnh: " + ex.Message);
            }
        }
    }
}