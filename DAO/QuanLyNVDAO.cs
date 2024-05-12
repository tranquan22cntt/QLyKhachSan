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



        // them nhan vien
        public void Addtv(string matv, string ten, string sdt, string cccd, string diachi, DateTime ngaysinh, DateTime ngayvaolam, string gioitinh)
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

        public void Addtn(string matn, string ten, string sdt, string cccd, string diachi, DateTime ngaysinh, DateTime ngayvaolam, string gioitinh)
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
        public void Addtt(string matt, string ten, string sdt, string cccd, string diachi, DateTime ngaysinh, DateTime ngayvaolam, string gioitinh)
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

        public bool Addtk(string matk, string username, string matkhau)
        {
            string query = $"INSERT INTO TAIKHOAN (MATK, USERNAME, MATKHAU) VALUES ('{matk}', '{username}', '{matkhau}')";
            using (SqlConnection conn = ketNoi.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0;
            }
        }

        //xoa nhan vien

        public bool XoaNhanVienTapVu(string matv)
        {
            string query = $"DELETE FROM tapvu WHERE matv = '{matv}'";
            return ExecuteNonQuery(query);
        }

        public bool XoaNhanVienThuNgan(string matn)
        {
            string query = $"DELETE FROM thungan WHERE matn = '{matn}'";
            return ExecuteNonQuery(query);
        }

        public bool XoaNhanVienTiepTan(string matt)
        {
            string query = $"DELETE FROM tieptan WHERE matt = '{matt}'";
            return ExecuteNonQuery(query);
        }

        private bool ExecuteNonQuery(string query)
        {
            using (SqlConnection conn = ketNoi.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
                return rowsAffected > 0;
            }
        }


        // load data
        public DataTable LoadTapVuData()
        {
            string query = "SELECT * FROM tapvu";
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

        public DataTable LoadThuNganData()
        {
            string query = "SELECT * FROM thungan";
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

        public DataTable LoadTiepTanData()
        {
            string query = "SELECT * FROM tieptan";
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

        public DataTable TimKiemTapVu(string tukhoa)
        {
            string query = $"SELECT * FROM TapVu WHERE MaTV LIKE '%{tukhoa}%' OR TenTV LIKE '%{tukhoa}%' OR SDT LIKE '%{tukhoa}%' OR CCCD LIKE '%{tukhoa}%'";

            using (SqlConnection conn = ketNoi.Connect())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                return dt;
            }
        }


        public DataTable TimKiemThuNgan(string tukhoa)
        {
            string query = $"SELECT * FROM ThuNgan WHERE MaTN LIKE '%{tukhoa}%' OR TenTN LIKE '%{tukhoa}%' OR SDT LIKE '%{tukhoa}%' OR CCCD LIKE '%{tukhoa}%'";

            using (SqlConnection conn = ketNoi.Connect())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                return dt;
            }
        }

        public DataTable TimKiemTiepTan(string tukhoa)
        {
            string query = $"SELECT * FROM TiepTan WHERE MaTT LIKE '%{tukhoa}%' OR TenTT LIKE '%{tukhoa}%' OR SDT LIKE '%{tukhoa}%' OR CCCD LIKE '%{tukhoa}%'";

            using (SqlConnection conn = ketNoi.Connect())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                return dt;
            }
        }

        public bool CapNhatNhanVienTapVu(string maNV, string tenNV, string sdt, string cccd, string diaChi, DateTime ngaySinh, DateTime ngayVaoLam, string gioiTinh)
        {
            string query = $"UPDATE TapVu SET Tentv = '{tenNV}', SDT = {sdt}, CCCD = '{cccd}', DiaChi = '{diaChi}', NgaySinh = '{ngaySinh}', NgayVaoLam = '{ngayVaoLam}', GioiTinh = '{gioiTinh}' WHERE Matv = '{maNV}'";

            using (SqlConnection conn = ketNoi.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
        }

        public bool CapNhatNhanVienThuNgan(string maNV, string tenNV, string sdt, string cccd, string diaChi, DateTime ngaySinh, DateTime ngayVaoLam, string gioiTinh)
        {
            string query = $"UPDATE ThuNgan SET Tentn = '{tenNV}', SDT = {sdt}, CCCD = '{cccd}', DiaChi = '{diaChi}', NgaySinh = '{ngaySinh}', NgayVaoLam = '{ngayVaoLam}', GioiTinh = '{gioiTinh}' WHERE Matn = '{maNV}'";

            using (SqlConnection conn = ketNoi.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
        }

        public bool CapNhatNhanVienTiepTan(string maNV, string tenNV, string sdt, string cccd, string diaChi, DateTime ngaySinh, DateTime ngayVaoLam, string gioiTinh)
        {
            string query = $"UPDATE TiepTan SET Tentt = '{tenNV}', SDT = {sdt}, CCCD = '{cccd}', DiaChi = '{diaChi}', NgaySinh = '{ngaySinh}', NgayVaoLam = '{ngayVaoLam}', GioiTinh = '{gioiTinh}' WHERE Matt = '{maNV}'";

            using (SqlConnection conn = ketNoi.Connect())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
        }


    }
}
