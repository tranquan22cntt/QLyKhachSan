using BLL;
using DAO;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAnKhachSanLUXURY
{
    public partial class frmQuanLyNhanVienn : DevExpress.XtraEditors.XtraForm
    {
        //QuanLyNVDAO qlnv = new QuanLyNVDAO();
        //String query;
        private QuanLyNVBLL qlnv;
        public frmQuanLyNhanVienn()
        {
            InitializeComponent();
            qlnv = new QuanLyNVBLL();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            string ten = txtTen.Text;
            int sdt = int.Parse(txtsdt.Text);
            string cccd = txtCCCD.Text;
            string diachi = txtdiachi.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;
            DateTime ngayvaolam = dtpNgayVaoLam.Value;
            string gioitinh = cbGioiTinh.Text;

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(cccd))
            {
                MessageBox.Show("Vui lòng nhập tên và số cccd");
                return;
            }

            QuanLyNVBLL quanLyNVBLL = new QuanLyNVBLL();
            string message;
            bool success = false;

            string LoaiNhanVien;
            switch (LoaiNhanVien = txtloainhanvien.Text)
            {
                case "1":
                    success = quanLyNVBLL.Addtv(manv, ten, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh);
                    message = success ? "Thêm nhân viên tạp vụ thành công." : "Thêm nhân viên tạp vụ không thành công.";
                    break;
                case "2":
                    success = quanLyNVBLL.Addtn(manv, ten, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh);
                    message = success ? "Thêm nhân viên thu ngân thành công." : "Thêm nhân viên thu ngân không thành công.";
                    break;
                case "3":
                    success = quanLyNVBLL.Addtt(manv, ten, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh);
                    message = success ? "Thêm nhân viên tiếp tân thành công." : "Thêm nhân viên tiếp tân không thành công.";
                    break;
                default:
                    message = "Loại nhân viên không hợp lệ.";
                    break;
            }
            MessageBox.Show(message);
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {

        }

        //public void setEmployee(DataGridView dgv)
        //{
        //    query = "select * from tapvu";
        //    DataSet ds = qlnv.GetData(query);
        //    dgv.DataSource = ds.Tables[0];
        //}

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}