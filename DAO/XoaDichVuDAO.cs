using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class XoaDichVuDAO
    {
        private KetNoi ketNoi;

        public XoaDichVuDAO()
        {
            ketNoi = new KetNoi();
        }

        public bool XoaDichVu(string maDichVu)
        {
            try
            {
                string query = "DELETE  DichVu WHERE MADV = @MaDichVu";
                using (SqlConnection conn = ketNoi.Connect())
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@MaDichVu", maDichVu);

                        conn.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                Console.WriteLine("Lỗi xảy ra khi xóa dịch vụ: " + ex.Message);
                return false;
            }
        }
    }
}
