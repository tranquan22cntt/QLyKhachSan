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
            using (SqlConnection conn = ketNoi.Connect())
            {
                try
                {
                    string query = "UPDATE HOADON SET TINHTRANGTT = 0 WHERE MAHD = @MaHD";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHD", maHD);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        /*public bool ThanhToanHoaDonDichVu(string maDV)
        {
            using (SqlConnection conn = ketNoi.Connect())
            {
                try
                {
                    string query = "UPDATE DICHVU SET TINHTRANGTT = 1 WHERE MADV = @MaDV";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaDV", maDV);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }*/
    }
}

