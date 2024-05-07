using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TimKiemDichVuDAO
    {
        private KetNoi ketNoi;

        public TimKiemDichVuDAO()
        {
            ketNoi = new KetNoi();
        }
        public DataTable TimKiemDichVuTheoSanPham(string tenSanPham)
        {
            string query = "SELECT * FROM DichVu WHERE SANPHAM = @TenSanPham";
            using (SqlConnection conn = ketNoi.Connect())
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@TenSanPham", tenSanPham);

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
