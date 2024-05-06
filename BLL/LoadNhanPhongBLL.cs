using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class LoadNhanPhongBLL
    {

        DAO.loadNhanPhongDAO LoadNhanPhong;
        public LoadNhanPhongBLL()
        {
            LoadNhanPhong = new DAO.loadNhanPhongDAO();
        }
        public List<object> getDSnhanphong()
        {
            var list = new List<object>();
            var data = LoadNhanPhong.GetDSnhanphong();
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
                    QUOCTICH= ((DataRow)item)["QUOCTICH"]?.ToString(),
                    NGAYDEN = ((DataRow)item)["NGAYDEN"]?.ToString(), // Cột NGAYDEN đến từ bảng KHACHHANG
                    NGAYNHANPHONG = ((DataRow)item)["NGAYNHANPHONG"]?.ToString()
                });
            }
            return list;
        }
    }
}
