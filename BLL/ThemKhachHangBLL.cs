using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using static DAO.ThemKhachHangDAO;

namespace BLL
{
    public class ThemKhachHangBLL
    {
        private KetNoi ketNoi;

        public ThemKhachHangBLL()
        {
            ketNoi = new KetNoi();
        }

        public void ThemKhachHangVaCapNhatPhong(KhachHangInfo khachHangInfo)
        {
            using (SqlConnection conn = ketNoi.Connect())
            {
                conn.Open();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {
                        ThemKhachHangDAO themKhachHangDAO = new ThemKhachHangDAO();
                        themKhachHangDAO.ThemKhachHangVaCapNhatPhong(conn, transaction, khachHangInfo);

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Lỗi khi thêm khách hàng và cập nhật phòng: " + ex.Message);
                    }
                }
            }
        }



        public string GenerateNewMakh(string maxMakh)
        {
            string newMakh = string.Empty;

            if (!string.IsNullOrEmpty(maxMakh))
            {
                string prefix = maxMakh.Substring(0, 2); // Lấy phần prefix (ví dụ: "KH")
                int lastNumber = int.Parse(maxMakh.Substring(2)); // Lấy phần số (ví dụ: 010)
                lastNumber++; // Tăng số lên 1
                newMakh = prefix + lastNumber.ToString("000"); // Kết hợp lại thành Makh mới
            }
            else
            {
                newMakh = "KH001"; // Trường hợp không có Makh nào trong cơ sở dữ liệu
            }

            return newMakh;
        }

    }
}