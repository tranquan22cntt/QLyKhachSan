using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BLL
{
    public class NhanPhongBLL
    {
        private NhanPhongDAO nhanPhongDAO;

        public NhanPhongBLL()
        {
            nhanPhongDAO = new NhanPhongDAO();
        }

        public bool NhanPhong(string maPhong)
        {
            try
            {
                // Gọi phương thức từ DAO để cập nhật trạng thái nhận phòng
                bool success = nhanPhongDAO.NhanPhong(maPhong);

                if (success)
                {
                    // Nếu nhận phòng thành công, bạn có thể thực hiện các hoạt động khác ở đây
                    // Ví dụ: Thông báo nhận phòng thành công, gửi email xác nhận, cập nhật giao diện người dùng, vv.

                    Console.WriteLine("Nhận phòng thành công.");
                }
                else
                {
                    // Xử lý trường hợp không nhận phòng được
                    Console.WriteLine("Không thể nhận phòng.");
                }

                return success;
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi
                Console.WriteLine("Đã xảy ra lỗi khi nhận phòng: " + ex.Message);
                return false;
            }
        }
    }
}
