using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HuyPhongBLL
    {
        private HuyPhongDAO huyPhongDAO;

        public HuyPhongBLL()
        {
            huyPhongDAO = new HuyPhongDAO();
        }

        public bool HuyPhong(string maPhong)
        {
            try
            {
                // Gọi phương thức từ DAO để hủy phòng
                return huyPhongDAO.HuyPhong(maPhong);
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi
                throw ex;
            }
        }
    }
}
