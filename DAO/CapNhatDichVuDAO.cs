using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CapNhatDichVuDAO
    {
        private KetNoi ketNoi;

        public CapNhatDichVuDAO()
        {
            ketNoi = new KetNoi();
        }

        public bool CapNhatDichVu(string maDichVu, string tenDichVu, decimal gia, string loaiDichVu, int soLuong)
        {
            try
            {
                string query = "UPDATE DichVu SET SANPHAM = @TenDichVu, GIATIEN = @Gia, LOAIDV = @LoaiDichVu, SoLuong = @SoLuong WHERE MADV = @MaDichVu";

                using (SqlConnection connection = ketNoi.Connect())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaDichVu", maDichVu);
                        command.Parameters.AddWithValue("@TenDichVu", tenDichVu);
                        command.Parameters.AddWithValue("@Gia", gia);
                        command.Parameters.AddWithValue("@LoaiDichVu", loaiDichVu);
                        command.Parameters.AddWithValue("@SoLuong", soLuong);

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
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
