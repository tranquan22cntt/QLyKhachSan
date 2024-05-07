using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public DataTable GetDSPhongTrong()
        {
            string query = "SELECT * FROM PHONG WHERE STA_TUS = 1";
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

        public DataTable GetDSPhongTrongByLoaiPhong(string loaiPhong)
        {
            string query = "SELECT * FROM PHONG WHERE STA_TUS = 1 AND LOAIPHONG = @LoaiPhong";
            using (SqlConnection conn = ketNoi.Connect())
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@LoaiPhong", loaiPhong);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        return dataSet.Tables[0];
                    }
                }
            }
        }
    }
}
