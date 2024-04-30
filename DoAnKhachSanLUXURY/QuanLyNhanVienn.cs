using BLL;
using DAO;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Model;
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
        private readonly QuanLyNVBLL bll;
        public frmQuanLyNhanVienn()
        {
            InitializeComponent();
            bll = new QuanLyNVBLL();
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

            if (string.IsNullOrEmpty(manv) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(gioitinh))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            QuanLyNVBLL quanLyNVBLL = new QuanLyNVBLL();
            string mess;
            bool check = false;

            string LoaiNhanVien;
            switch (LoaiNhanVien = txtloainhanvien.Text)
            {
                case "1":
                    check = quanLyNVBLL.Addtv(manv, ten, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh);
                    mess = check ? "Thêm nhân viên tạp vụ thành công." : "Thêm nhân viên tạp vụ không thành công.";
                    break;
                case "2":
                    check = quanLyNVBLL.Addtn(manv, ten, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh);
                    mess = check ? "Thêm nhân viên thu ngân thành công." : "Thêm nhân viên thu ngân không thành công.";
                    break;
                case "3":
                    check = quanLyNVBLL.Addtt(manv, ten, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh);
                    mess = check ? "Thêm nhân viên tiếp tân thành công." : "Thêm nhân viên tiếp tân không thành công.";
                    break;
                default:
                    mess = "Loại nhân viên không hợp lệ.";
                    break;
            }
            MessageBox.Show(mess);
            ClearAll();
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            string loainv = txtloainhanvien.Text;

            if (string.IsNullOrEmpty(manv))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên.");
                return;
            }

            if (string.IsNullOrEmpty(loainv))
            {
                MessageBox.Show("Vui lòng chọn loại nhân viên.");
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                QuanLyNVBLL quanLyNVBLL = new QuanLyNVBLL();
                bool xoaThanhCong = quanLyNVBLL.XoaNhanVien(manv, loainv);

                if (xoaThanhCong)
                {
                    MessageBox.Show("Đã xóa nhân viên thành công.");
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên không thành công. Vui lòng thử lại.");
                }
            }
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

        private void ClearAll()
        {
            txtmanv.Clear();
            txtTen.Clear();
            txtsdt.Clear();
            txtdiachi.Clear();
            txtCCCD.Clear();
            txtloainhanvien.SelectedIndex = -1;
            txtTenDangNhap.Clear();
            cbGioiTinh.SelectedIndex = -1;
        }

        private void txtloainhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string loainv = txtloainhanvien.SelectedItem.ToString();
            string loainv;
            switch (loainv = txtloainhanvien.Text)
            {
                case "1":
                    dgvDanhSachNhanVien.DataSource = bll.LoadTapVuData();
                    break;
                case "2":
                    dgvDanhSachNhanVien.DataSource = bll.LoadThuNganData();
                    break;
                case "3":
                    dgvDanhSachNhanVien.DataSource = bll.LoadTiepTanData();
                    break;
            }
        }
    }
}