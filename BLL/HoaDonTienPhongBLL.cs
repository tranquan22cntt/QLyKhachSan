using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonTienPhongBLL
    {
        DAO.HoaDonTienPhongDAO HoaDonTienPhongDAO;
        public HoaDonTienPhongBLL()
        {
            HoaDonTienPhongDAO = new DAO.HoaDonTienPhongDAO();
        }
        public List<object> GetHoaDon()
        {
            var list = new List<object>();
            var data = HoaDonTienPhongDAO.GetDSHoaDonTienPhong();
            foreach (var item in data.Rows)
            {
                list.Add(new
                {
                    MAHD = ((DataRow)item)["MAHD"]?.ToString(),
                    TONGTHANHTOAN = double.Parse(((DataRow)item)["TONGTHANHTOAN"]?.ToString()),
                    LOAITHANHTOAN = ((DataRow)item)["LOAITHANHTOAN"]?.ToString(),
                    TINHTRANGTT = bool.Parse(((DataRow)item)["TINHTRANGTT"]?.ToString()),
                    MAKH = ((DataRow)item)["MAKH"]?.ToString(),
                });
            }
            return list;
        }
    }
}
