using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuanLyNVBLL
    {
        private readonly QuanLyNVDAO dao;

        public QuanLyNVBLL()
        {
            dao = new QuanLyNVDAO();
        }

        public bool Addtv(string matv, string ten, int sdt, string cccd, string diachi, DateTime ngaysinh, DateTime ngayvaolam, string gioitinh)
        {
            dao.Addtv(matv, ten, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh);
            return true;
        }

        public bool Addtn(string matn, string ten, int sdt, string cccd, string diachi, DateTime ngaysinh, DateTime ngayvaolam, string gioitinh)
        {
            dao.Addtn(matn, ten, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh);
            return true;
        }
        public bool Addtt(string matt, string ten, int sdt, string cccd, string diachi, DateTime ngaysinh, DateTime ngayvaolam, string gioitinh)
        {
            dao.Addtt(matt, ten, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh);
            return true;
        }

        public bool XoaNhanVien(string maNhanVien, string loaiNhanVien)
        {
            switch (loaiNhanVien)
            {
                case "Tạp vụ":
                    return dao.XoaNhanVienTapVu(maNhanVien);
                case "Thu ngân":
                    return dao.XoaNhanVienThuNgan(maNhanVien);
                case "Tiếp tân":
                    return dao.XoaNhanVienTiepTan(maNhanVien);
                default:
                    return false;
            }
        }

        //load data

        public DataTable LoadTapVuData()
        {
            return dao.LoadTapVuData();
        }

        public DataTable LoadThuNganData()
        {
            return dao.LoadThuNganData();
        }

        public DataTable LoadTiepTanData()
        {
            return dao.LoadTiepTanData();
        }


        public DataTable TimKiemTapVu(string tukhoa)
        {
            return dao.TimKiemTapVu(tukhoa);
        }

        public DataTable TimKiemThuNgan(string tukhoa)
        {
            return dao.TimKiemThuNgan(tukhoa);
        }

        public DataTable TimKiemTiepTan(string tukhoa)
        {
            return dao.TimKiemTiepTan(tukhoa);
        }


    }
}
