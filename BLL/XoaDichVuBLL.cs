using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class XoaDichVuBLL
    {
        private XoaDichVuDAO xoaDichVuDAO;

        public XoaDichVuBLL()
        {
            xoaDichVuDAO = new XoaDichVuDAO();
        }

        public bool XoaDichVu(string maDichVu)
        {
           
            return xoaDichVuDAO.XoaDichVu(maDichVu);
        }
    }
}
