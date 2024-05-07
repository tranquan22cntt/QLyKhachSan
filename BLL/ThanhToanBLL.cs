using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThanhToanBLL
    {
        private ThanhToanDAO thanhToanDAO;

        public ThanhToanBLL()
        {
            thanhToanDAO = new ThanhToanDAO();
        }

        public bool ThanhToanHoaDonTienPhong(string maHD)
        {
            return thanhToanDAO.ThanhToanHoaDonTienPhong(maHD);
        }

        public bool ThanhToanHoaDonDichVu(string maDV)
        {
            return thanhToanDAO.ThanhToanHoaDonDichVu(maDV);
        }
    }
}
