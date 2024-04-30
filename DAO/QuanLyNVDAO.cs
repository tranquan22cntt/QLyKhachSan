    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DAO
    {
        public class QuanLyNVDAO
        {
            private KetNoi ketNoi;

            public QuanLyNVDAO()
            {

                ketNoi = new KetNoi();
            }
        //string connectionString = "Data Source=LAPTOP-GA9J10NA\\SQLEXPRESS;Initial Catalog=DoAnKhachSan;Integrated Security=True;";

        //public SqlConnection Connect()
        //{
        //    SqlConnection conn = new SqlConnection(connectionString);
        //    return conn;
        //}

        //public DataSet GetData(String query)
        //{
        //    SqlConnection con = Connect();
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    cmd.Connection = con;
        //    cmd.CommandText = query;
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    return ds;
        //}

        //public void SetData(String query)
        //{
        //    SqlConnection con = Connect();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    con.Open();
        //    cmd.CommandText = query;
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}


        public void Addtv(string matv, string ten, int sdt, string cccd, string diachi, DateTime ngaysinh, DateTime ngayvaolam, string gioitinh)
        {
            string query = $"INSERT INTO tapvu (matv, tentv, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh) VALUES ('{matv}','{ten}', '{sdt}', '{cccd}', '{diachi}', '{ngaysinh}', '{ngayvaolam}', '{gioitinh}')";
            using (SqlConnection conn = ketNoi.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void Addtn(string matn, string ten, int sdt, string cccd, string diachi, DateTime ngaysinh, DateTime ngayvaolam, string gioitinh)
        {
            string query = $"INSERT INTO thungan (matn, tentn, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh) VALUES ('{matn}','{ten}', '{sdt}', '{cccd}', '{diachi}', '{ngaysinh}', '{ngayvaolam}', '{gioitinh}')";
            using (SqlConnection conn = ketNoi.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void Addtt(string matt, string ten, int sdt, string cccd, string diachi, DateTime ngaysinh, DateTime ngayvaolam, string gioitinh)
        {
            string query = $"INSERT INTO tieptan (matt, tentt, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh) VALUES ('{matt}', '{ten}', '{sdt}', '{cccd}', '{diachi}', '{ngaysinh}', '{ngayvaolam}', '{gioitinh}')";
            using (SqlConnection conn = ketNoi.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        }
    }
