using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoadDVBLL
    {
        DAO.LoadDVDAO themDichVuDAO;
        public LoadDVBLL()
        {
            themDichVuDAO = new DAO.LoadDVDAO();
        }
        public List<object> GetDichVu() { 
            var list = new List<object>();
            var data = themDichVuDAO.GetDSDinhVu();
            foreach (var item in data.Rows)
            {
                list.Add(new {
                    MADV = ((DataRow)item)["MADV"]?.ToString(),
                    SANPHAM = ((DataRow)item)["SANPHAM"]?.ToString(),
                    LOAIDV = ((DataRow)item)["loaidv"]?.ToString(),
                    GIATIEN = double.Parse(((DataRow)item)["GIATIEN"]?.ToString()),
                    SOLUONG = int.Parse(((DataRow)item)["SOLUONG"]?.ToString())
                });
            }
            return list;
        }
    }
}