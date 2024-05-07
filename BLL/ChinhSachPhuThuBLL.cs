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

            DanhSachChinhSachPhuThu.Add(new ChinhSachPhuThu() { MaPhuThu = "P001", MoTa = "Phu thu phong dep", PhanTramPhuThu = 10.0 });
            DanhSachChinhSachPhuThu.Add(new ChinhSachPhuThu() { MaPhuThu = "P002", MoTa = "Phu thu dich vu cao cap", PhanTramPhuThu = 15.0 });
            DanhSachChinhSachPhuThu.Add(new ChinhSachPhuThu() { MaPhuThu = "P003", MoTa = "Phu thu su dung ho boi", PhanTramPhuThu = 5.0 });
            DanhSachChinhSachPhuThu.Add(new ChinhSachPhuThu() { MaPhuThu = "P004", MoTa = "Phu thu su dung phong gym", PhanTramPhuThu = 3.0 });
            DanhSachChinhSachPhuThu.Add(new ChinhSachPhuThu() { MaPhuThu = "P005", MoTa = "Phu thu su dung spa", PhanTramPhuThu = 7.5 });
        }

        public List<ChinhSachPhuThu> GetDanhSachChinhSachPhuThu()
        {
            return DanhSachChinhSachPhuThu;
        }
    }
}
