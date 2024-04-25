using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ChinhSachPhuThu
{
    public string MaPhuThu { get; set; }
    public string MoTa { get; set; }
    public double PhanTramPhuThu { get; set; }
}

namespace BLL
{
    public class ChinhSachPhuThuBLL
    {
        private List<ChinhSachPhuThu> DanhSachChinhSachPhuThu;

        public ChinhSachPhuThuBLL()
        {
            DanhSachChinhSachPhuThu = new List<ChinhSachPhuThu>();

            // Khởi tạo dữ liệu mẫu
            DanhSachChinhSachPhuThu.Add(new ChinhSachPhuThu() { MaPhuThu = "P001", MoTa = "Phụ thu phòng đẹp", PhanTramPhuThu = 10.0 });
            DanhSachChinhSachPhuThu.Add(new ChinhSachPhuThu() { MaPhuThu = "P002", MoTa = "Phụ thu dịch vụ cao cấp", PhanTramPhuThu = 15.0 });
            DanhSachChinhSachPhuThu.Add(new ChinhSachPhuThu() { MaPhuThu = "P003", MoTa = "Phụ thu sử dụng hồ bơi", PhanTramPhuThu = 5.0 });
            DanhSachChinhSachPhuThu.Add(new ChinhSachPhuThu() { MaPhuThu = "P004", MoTa = "Phụ thu sử dụng phòng gym", PhanTramPhuThu = 3.0 });
            DanhSachChinhSachPhuThu.Add(new ChinhSachPhuThu() { MaPhuThu = "P005", MoTa = "Phụ thu sử dụng spa", PhanTramPhuThu = 7.5 });
            // Thêm 3 chính sách phụ thu khác
        }

        public List<ChinhSachPhuThu> GetDanhSachChinhSachPhuThu()
        {
            return DanhSachChinhSachPhuThu;
        }
    }
}
