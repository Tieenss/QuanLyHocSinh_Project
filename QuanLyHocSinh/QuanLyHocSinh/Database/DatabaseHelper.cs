using System;
using System.Data;
using System.Data.SqlClient; // Nếu báo lỗi dòng này thì cài NuGet System.Data.SqlClient
using System.Windows.Forms;

namespace QuanLyHocSinh.Database
{
    public class DatabaseHelper
    {
        // CẤU HÌNH KẾT NỐI (Dành cho bản SQL Server Express)
        // Lưu ý: Thay '123456' bằng mật khẩu tài khoản sa của bạn
        private static string strCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyHocSinh;User ID=sa;Password=123456";

        // Hàm lấy dữ liệu (SELECT)
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

        // Hàm thực thi lệnh (INSERT, UPDATE, DELETE)
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