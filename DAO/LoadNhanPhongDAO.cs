using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class loadNhanPhongDAO
    {
        private KetNoi ketNoi;

        public loadNhanPhongDAO()
        {
            ketNoi = new KetNoi();
        }
        public DataTable GetDSnhanphong()
        {
            string query = $"SELECT TT_NHANPHONG.MAPHONG, TT_NHANPHONG.SOPHONG,PHONG.LOAIPHONG,PHONG.GIATIEN,PHONG.SUCCHUA, TT_NHANPHONG.MAKH, KHACHHANG.TENKH,KHACHHANG.QUOCTICH,KHACHHANG.CCCD,KHACHHANG.SDT," +
                $"KHACHHANG.NGAYDEN,KHACHHANG.NGAYNHANPHONG FROM TT_NHANPHONG,KHACHHANG,PHONG WHERE  " +
                $"TT_NHANPHONG.MAPHONG = PHONG.MAPHONG  AND TT_NHANPHONG.MAKH=KHACHHANG.MAKH and PHONG.STA_TUS=2";
            using (SqlConnection conn = ketNoi.Connect())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet.Tables[0];
                }
            }
        }
    }
}
