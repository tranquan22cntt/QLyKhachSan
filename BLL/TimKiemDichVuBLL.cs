using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BLL
{
    public class TimKiemDichVuBLL
    {
        private TimKiemDichVuDAO timKiemDichVuDAO;

        public TimKiemDichVuBLL()
        {
            timKiemDichVuDAO = new TimKiemDichVuDAO();
        }

        public DataTable TimKiemDichVuTheoSanPham(string tenSanPham)
        {
            return timKiemDichVuDAO.TimKiemDichVuTheoSanPham(tenSanPham);
        }
    }
}
