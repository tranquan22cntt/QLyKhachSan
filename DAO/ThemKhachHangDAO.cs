using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThemKhachHangDAO
    {
        private KetNoi ketNoi;

        public ThemKhachHangDAO()
        {
            ketNoi = new KetNoi();
        }

        public void ThemKhachHangVaCapNhatPhong(SqlConnection conn, SqlTransaction transaction, KhachHangInfo khachHangInfo)
        {
            string query = "EXEC ThemKhachHangVaCapNhatPhong @MAKH, @CCCD, @TENKH, @NGAYDEN, @NGAYNHANPHONG, @MAPHONG, @SOPHONG";

            using (SqlCommand command = new SqlCommand(query, conn, transaction))
            {
                command.Parameters.AddWithValue("@MAKH", khachHangInfo.MaKH);
                command.Parameters.AddWithValue("@CCCD", khachHangInfo.CCCD);
                command.Parameters.AddWithValue("@TENKH", khachHangInfo.HoTen);
                command.Parameters.AddWithValue("@NGAYDEN", khachHangInfo.NgayTra);
                command.Parameters.AddWithValue("@NGAYNHANPHONG", khachHangInfo.NgayNhan);
                command.Parameters.AddWithValue("@MAPHONG", khachHangInfo.MaPhong);
                command.Parameters.AddWithValue("@SOPHONG", khachHangInfo.SoPhong);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi thêm khách hàng và cập nhật phòng: " + ex.Message);
                }
            }
        }

        public string GetMaxMakh()
        {
            string maxMakh = string.Empty;
            string query = "SELECT MAX(MAKH) FROM KHACHHANG";
            using (SqlConnection conn = ketNoi.Connect())
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        maxMakh = command.ExecuteScalar()?.ToString();
                    }
                }
                else
                {
                    // Đã mở rồi, không cần mở lại
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        maxMakh = command.ExecuteScalar()?.ToString();
                    }
                }
                
            }
            return maxMakh;
        }
        public string GenerateNewMakh(string maxMakh)
        {
            string newMakh = "KH001"; // Mã khách hàng mặc định nếu không có dữ liệu trong bảng

            if (!string.IsNullOrEmpty(maxMakh))
            {
                // Extract the numeric part of the maxMakh string
                string numericPart = maxMakh.Substring(2);

                // Convert numeric part to integer and increment by 1
                int newNumericPart = int.Parse(numericPart) + 1;

                // Format the newMakh string with leading zeros and concatenate with "KH"
                newMakh = "KH" + newNumericPart.ToString("D3");
            }

            return newMakh;
        }

        public class KhachHangInfo
        {
            public string MaKH { get; set; }
            public string MaPhong { get; set; }
            public string SoPhong { get; set; }
            public string HoTen { get; set; }
            public string CCCD { get; set; }
            public DateTime NgayNhan { get; set; }
            public DateTime NgayTra { get; set; }
        }
    }
}