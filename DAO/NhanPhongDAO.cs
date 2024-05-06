using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhanPhongDAO
    {
        private KetNoi ketNoi;

        public NhanPhongDAO()
        {
            ketNoi = new KetNoi();
        }

        public bool NhanPhong(string maPhong)
        {
            try
            {
                // Chuỗi truy vấn SQL
                string query = "UPDATE PHONG SET STA_TUS = 3 WHERE MAPHONG = @MaPhong";

                // Mở kết nối và thực hiện truy vấn
                using (SqlConnection connection = ketNoi.Connect())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho truy vấn
                        command.Parameters.AddWithValue("@MaPhong", maPhong);

                        // Mở kết nối
                        connection.Open();

                        // Thực hiện truy vấn cập nhật
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có bản ghi nào được cập nhật không
                        if (rowsAffected > 0)
                        {
                            // Nếu có, trả về true để thông báo nhận phòng thành công
                            return true;
                        }
                        else
                        {
                            // Nếu không, trả về false để thông báo lỗi không nhận phòng được
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
