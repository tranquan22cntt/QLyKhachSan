using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoadDVDAO
    {
        private KetNoi ketNoi;

        public LoadDVDAO()
        {
            ketNoi = new KetNoi();
        }
        public DataTable GetDSDinhVu()
        {
            string query = $"SELECT * FROM DICHVU";
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
