using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DangNhapDAO
    {
        private KetNoi ketNoi;

        public DangNhapDAO() {

            ketNoi = new KetNoi();
        }

        public DataTable DangNhap(string userName, string password)
        {
            string query = $"SELECT * FROM TAIKHOAN WHERE USERNAME = '{userName}' AND MATKHAU = '{password}'";
            using (SqlConnection conn = ketNoi.Connect())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet.Tables[0];
                }
                conn.Close();
            }
            
        }
    }
}
