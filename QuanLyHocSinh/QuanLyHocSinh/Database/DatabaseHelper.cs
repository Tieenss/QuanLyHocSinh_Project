using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyHocSinh.Database
{
    public class DatabaseHelper
    {
        // CHUỖI KẾT NỐI ĐẾN SMARTERASP.NET
        // Lưu ý: Thay thế các thông tin bên dưới bằng thông tin thực tế từ Control Panel của bạn
        private static string strCon = @"Server=SQL1003.site4now.net;Database=db_ac36c5_quanlyhocsinh;User Id=db_ac36c5_quanlyhocsinh_admin;Password=tien@362005;TrustServerCertificate=True;";

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
                // In ra chi tiết lỗi để dễ debug
                MessageBox.Show("Lỗi kết nối CSDL Online: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lỗi thực thi lệnh Online: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}