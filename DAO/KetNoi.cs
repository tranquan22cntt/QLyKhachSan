using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KetNoi
    {
        private const string ConnectionString = @"Data Source=DESKTOP-JK7J6BR\SQLEXPRESS;Initial Catalog=DoAnKhachSan;Integrated Security=True";

        public SqlConnection Connect()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                //MessageBox.Show("Không kết nối được CSDL: " + e.Message, "Thông báo",
                //MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close  ();
            return conn;
        }
    }
}
