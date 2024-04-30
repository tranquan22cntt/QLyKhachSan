using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThemDichVuDao
    {
        private KetNoi ketNoi;

        public ThemDichVuDao()
        {
            ketNoi = new KetNoi();
        }
        public bool ThemDichVu(string MADV, string SANPHAM, string loaidv, decimal GIATIEN, int SOLUONG)
        {
            using (SqlConnection conn = ketNoi.Connect())
            {
                try
                {
                    string query = @"INSERT INTO DICHVU (MADV, SANPHAM, loaidv, GIATIEN, SOLUONG) VALUES (@MADV, @SANPHAM, @loaidv, @GIATIEN, @SOLUONG)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MADV", MADV);
                    cmd.Parameters.AddWithValue("@SANPHAM", SANPHAM);
                    cmd.Parameters.AddWithValue("@LOAIDV", loaidv);
                    cmd.Parameters.AddWithValue("@GIATIEN", GIATIEN);
                    cmd.Parameters.AddWithValue("@SOLUONG", SOLUONG);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
