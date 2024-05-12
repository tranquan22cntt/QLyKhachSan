using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThanhToanDAO
    {
        private KetNoi ketNoi;

        public ThanhToanDAO()
        {
            ketNoi = new KetNoi();
        }

        public bool ThanhToanHoaDonTienPhong(string maHD)
        {
            try
            {
                // Chuỗi truy vấn SQL
                string query = "UPDATE HOADON SET TINHTRANGTT = 0 WHERE MAHD = @MaHD";

                // Mở kết nối và thực hiện truy vấn
                using (SqlConnection connection = ketNoi.Connect())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho truy vấn
                        command.Parameters.AddWithValue("@MaHD", maHD);

                        // Mở kết nối
                        connection.Open();

                        // Thực hiện truy vấn cập nhật
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có bản ghi nào được cập nhật không
                        if (rowsAffected > 0)
                        {
                            // Nếu có, trả về true để thông báo thanh toán thành công
                            return true;
                        }
                        else
                        {
                            // Nếu không, trả về false để thông báo lỗi không thanh toán được
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi
                throw ex;
            }
        }
    }
}

