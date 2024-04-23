using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DangNhapBLL
    {
        private readonly DangNhapDAO dao;

        public DangNhapBLL()
        {
            dao = new DangNhapDAO();
        }

        public bool DangNhap(string userName, string password)
        {
            var data = dao.DangNhap(userName, password);     
            return data.Rows.Count > 0;
        }
    }
}
