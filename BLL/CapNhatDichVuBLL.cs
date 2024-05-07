using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BLL
{
    public class CapNhatDichVuBLL
    {
        private CapNhatDichVuDAO capNhatDichVuDAO;

        public CapNhatDichVuBLL()
        {
            capNhatDichVuDAO = new CapNhatDichVuDAO();
        }

        public bool CapNhatDichVu(string maDichVu, string tenDichVu, decimal gia, string loaiDichVu, int soLuong)
        {
            try
            {
                return capNhatDichVuDAO.CapNhatDichVu(maDichVu, tenDichVu, gia, loaiDichVu, soLuong);
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi
                throw ex;
            }
        }
    }
}

