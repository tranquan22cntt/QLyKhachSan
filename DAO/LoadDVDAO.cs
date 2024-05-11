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

        public void Export(string filePath)
        {
            var result = new List<object>();
            var data = GetDSDinhVu();
            foreach (DataRow row in data.Rows)
            {
                result.Add(new
                {
                    MADV = row["MADV"].ToString(),
                    SANPHAM = row["SANPHAM"].ToString(),
                    LOAIDV = row["loaidv"].ToString(),
                    GIATIEN = double.Parse(row["GIATIEN"].ToString()),
                    SOLUONG = int.Parse(row["SOLUONG"].ToString())
                });
            }
            FileHelper<object> cSVFileHelper = new FileHelper<object>();
            cSVFileHelper.WriteJsonFile(filePath, result);
        }

        public List<object> ReadFile(string filePath)
        {
            FileHelper<object> helper = new FileHelper<object>();
            return helper.ReadJsonFile(filePath);
        }
    }
}
