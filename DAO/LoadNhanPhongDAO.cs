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
            string query = $"SELECT * FROM TT_NHANPHONG";
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
