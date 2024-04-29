using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class XemPhongTrongDAO
    {
        private KetNoi ketNoi;

        public XemPhongTrongDAO()
        {
            ketNoi = new KetNoi();
        }
        public DataTable getDSphongtrong()
        {
            string query = $"SELECT * FROM PHONG WHERE STA_TUS=1";
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
