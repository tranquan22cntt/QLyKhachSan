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
                    CCCD = ((DataRow)item)["CCCD"]?.ToString(),
                    SDT = int.Parse(((DataRow)item)["SDT"]?.ToString()),
                    MAKH = ((DataRow)item)["MAKH"]?.ToString()
                });
            }
            return list;
        }
    }
}
