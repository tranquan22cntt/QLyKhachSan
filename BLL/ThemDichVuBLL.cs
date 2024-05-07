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
        private ThemDichVuDAO themDichVuDAO;

        public ThemDichVuBLL()
        {
            themDichVuDAO = new ThemDichVuDAO();
        }

        public bool ThemDichVu(string maDichVu, string tenDichVu, string loaiDichVu, decimal gia,int soluong)
        {
            // Kiểm tra xem các thông tin đầu vào có hợp lệ không
            if (string.IsNullOrEmpty(maDichVu) || string.IsNullOrEmpty(tenDichVu) || string.IsNullOrEmpty(loaiDichVu) || gia <= 0)
            {
                throw new ArgumentException("Thông tin dịch vụ không hợp lệ.");
            }

            // Gọi phương thức trong DAO để thêm dịch vụ vào cơ sở dữ liệu
            return themDichVuDAO.ThemDichVu(maDichVu, tenDichVu, gia, loaiDichVu,soluong);
        }
    }
}
