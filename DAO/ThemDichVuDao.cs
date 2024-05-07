using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace DAO
    {
        public class ThemDichVuDAO
        {
            private KetNoi ketNoi;

            public ThemDichVuDAO()
            {
                ketNoi = new KetNoi();
            }

            public bool ThemDichVu(string maDichVu, string tenDichVu, decimal gia, string loaiDichVu,int soluong)
            {
                try
                {
                // Chuỗi truy vấn SQL để thêm dịch vụ vào cơ sở dữ liệu
                string query = "INSERT INTO DichVu (MADV, SANPHAM, GIATIEN, LOAIDV, SoLuong) VALUES (@MaDichVu, @TenDichVu, @Gia, @LoaiDichVu, @SoLuong)";

                // Mở kết nối và thực hiện truy vấn
                using (SqlConnection connection = ketNoi.Connect())
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Thêm các tham số vào truy vấn
                            command.Parameters.AddWithValue("@MaDichVu", maDichVu);
                            command.Parameters.AddWithValue("@TenDichVu", tenDichVu);
                            command.Parameters.AddWithValue("@Gia", gia);
                            command.Parameters.AddWithValue("@LoaiDichVu", loaiDichVu);
                            command.Parameters.AddWithValue("@SoLuong", soluong);
                        // Mở kết nối
                        connection.Open();

                            // Thực hiện truy vấn thêm dịch vụ
                            int rowsAffected = command.ExecuteNonQuery();

                            // Kiểm tra xem có dòng nào bị ảnh hưởng không
                            if (rowsAffected > 0)
                            {
                                // Nếu có, trả về true để thông báo đã thêm dịch vụ thành công
                                return true;
                            }
                            else
                            {
                                // Nếu không, trả về false để thông báo lỗi không thêm được dịch vụ
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
