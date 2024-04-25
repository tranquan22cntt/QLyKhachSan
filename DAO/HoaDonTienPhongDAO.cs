using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonTienPhongDAO
    {
        private KetNoi ketNoi;

        public HoaDonTienPhongDAO()
        {
            ketNoi = new KetNoi();
        }
        public DataTable GetDSHoaDonTienPhong()
        {
            string query = $"SELECT * FROM HOADON";
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
