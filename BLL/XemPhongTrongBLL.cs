using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BLL
{
    public class XemPhongTrongBLL
    {
        DAO.XemPhongTrongDAO xemPhongtrong;
        public XemPhongTrongBLL()
        {
            xemPhongtrong = new DAO.XemPhongTrongDAO();
        }
        public List<object> getDSphongtrong()
        {
            var list = new List<object>();
            var data = xemPhongtrong.getDSphongtrong();
            foreach (var item in data.Rows)
            {
                list.Add(new
                {
                    MAPHONG = ((DataRow)item)["MAPHONG"]?.ToString(),
                    SOPHONG = int.Parse(((DataRow)item)["SOPHONG"]?.ToString()),
                    LOAIPHONG = ((DataRow)item)["LOAIPHONG"]?.ToString(),
                    GIATIEN = ((DataRow)item)["GIATIEN"] != DBNull.Value ? decimal.Parse(((DataRow)item)["GIATIEN"].ToString()) : 0,
                    SUCCHUA = int.Parse(((DataRow)item)["SUCCHUA"]?.ToString()),
                    MOTA = ((DataRow)item)["MOTA"]?.ToString(),
                    STATUS=int.Parse(((DataRow)item)["STA_TUS"]?.ToString())
                });
            }
            return list;
        }
    }
}
