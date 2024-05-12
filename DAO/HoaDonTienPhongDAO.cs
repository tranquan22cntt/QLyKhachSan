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
            string query = $"SELECT * FROM HOADON where TINHTRANGTT = 1";

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
            var data = GetDSHoaDonTienPhong();
            foreach (DataRow row in data.Rows)
            {
                result.Add(new
                {
                    MAHD = row["MAHD"].ToString(),
                    TONGTHANHTOAN = double.Parse(row["TONGTHANHTOAN"].ToString()),
                    LOAITHANHTOAN = row["LOAITHANHTOAN"].ToString(),
                    TINHTRANGTT = bool.Parse(row["TINHTRANGTT"].ToString()),
                    MAKH = row["MAKH"].ToString(),
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
