using DAO;
using System;
using System.Data;

namespace BLL
{
    public class XemPhongTrongBLL
    {
        private XemPhongTrongDAO xemPhongTrongDAO;

        public XemPhongTrongBLL()
        {
            xemPhongTrongDAO = new XemPhongTrongDAO();
        }

        public DataTable GetDSPhongTrong()
        {
            return xemPhongTrongDAO.GetDSPhongTrong();
        }

        public DataTable GetDSPhongTrongByLoaiPhong(string loaiPhong)
        {
            return xemPhongTrongDAO.GetDSPhongTrongByLoaiPhong(loaiPhong);
        }
    }
}
