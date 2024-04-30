using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThemDichVuBLL
    {
        DAO.ThemDichVuDao ThemDichVuDAO;
        public ThemDichVuBLL()
        {
            ThemDichVuDAO = new DAO.ThemDichVuDao();
        }
        public bool ThemDichVu(string MADV, string SANPHAM, string loaidv, decimal GIATIEN, int SOLUONG)
        {
            return ThemDichVuDAO.ThemDichVu(MADV, SANPHAM, loaidv, GIATIEN, SOLUONG);
        }
    }
}
