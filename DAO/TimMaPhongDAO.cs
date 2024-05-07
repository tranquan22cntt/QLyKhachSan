using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TimMaPhongDAO
    {
        private KetNoi ketNoi;

        public TimMaPhongDAO()
        {
            ketNoi = new KetNoi();
        }
        public DataTable GetDSNPbyMaphong(String maPhong)
        {

            string query = $"SELECT TT_NHANPHONG.MAPHONG, TT_NHANPHONG.SOPHONG,PHONG.LOAIPHONG,PHONG.GIATIEN,PHONG.SUCCHUA, TT_NHANPHONG.MAKH, KHACHHANG.TENKH,KHACHHANG.CCCD,KHACHHANG.SDT," +
                $"KHACHHANG.NGAYDEN,KHACHHANG.NGAYNHANPHONG FROM TT_NHANPHONG,KHACHHANG,PHONG WHERE TT_NHANPHONG.MAPHONG =@MAPHONG " +
                $"AND TT_NHANPHONG.MAPHONG = PHONG.MAPHONG  AND TT_NHANPHONG.MAKH=KHACHHANG.MAKH";
               
            using (SqlConnection conn = ketNoi.Connect())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MAPHONG", maPhong);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
    }
}
