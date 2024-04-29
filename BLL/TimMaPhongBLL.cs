using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BLL
{
    public class TimMaPhongBLL
    {
        
        DAO.TimMaPhongDAO TimMaPhong;
        public TimMaPhongBLL()
        {
            TimMaPhong = new DAO.TimMaPhongDAO();
        }
        public List<object> getDSnhanphongbymaphong(String maphong)
        {
            var list = new List<object>();
            var data = TimMaPhong.GetDSNPbyMaphong(maphong);
            foreach (var item in data.Rows)
            {
                list.Add(new
                {
                    MAPHONG = ((DataRow)item)["MAPHONG"]?.ToString(),
                    SOPHONG = int.Parse(((DataRow)item)["SOPHONG"]?.ToString()),
                    MAKH = ((DataRow)item)["MAKH"]?.ToString(),
                    TENKH = ((DataRow)item)["TENKH"]?.ToString(),
                    CCCD = ((DataRow)item)["CCCD"]?.ToString(),
                    LOAIPHONG = ((DataRow)item)["LOAIPHONG"]?.ToString(),
                    GIATIEN = decimal.Parse(((DataRow)item)["GIATIEN"]?.ToString()),
                    SUCCHUA = int.Parse(((DataRow)item)["SUCCHUA"]?.ToString()),
                    SDT = int.Parse(((DataRow)item)["SDT"]?.ToString()), // Cột SDT đến từ bảng KHACHHANG
                    NGAYDEN = ((DataRow)item)["NGAYDEN"]?.ToString(), // Cột NGAYDEN đến từ bảng KHACHHANG
                    NGAYNHANPHONG = ((DataRow)item)["NGAYNHANPHONG"]?.ToString()
                });

            }
            return list;
        }
    }
 
}
