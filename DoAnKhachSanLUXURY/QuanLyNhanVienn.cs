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
using System.Windows.Media;
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
            string sdt = txtsdt.Text;
            string cccd = txtCCCD.Text;
            string diachi = txtdiachi.Text;
            DateTime ngaysinh = dtpNgaySinh.Value;
            DateTime ngayvaolam = dtpNgayVaoLam.Value;
            string gioitinh = cbGioiTinh.Text;

            if (string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(manv) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(gioitinh))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            QuanLyNVBLL quanLyNVBLL = new QuanLyNVBLL();
            string thongbao;
            bool check = false;

            switch (txtloainhanvien.Text)
            {
                case "Tạp vụ":
                    check = quanLyNVBLL.Addtv(manv, ten, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh);
                    thongbao = check ? "Thêm nhân viên tạp vụ thành công." : "Thêm nhân viên tạp vụ không thành công.";
                    dgvDanhSachNhanVien.DataSource = bll.LoadTapVuData();
                    break;
                case "Thu ngân":
                    check = quanLyNVBLL.Addtn(manv, ten, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh);
                    thongbao = check ? "Thêm nhân viên thu ngân thành công." : "Thêm nhân viên thu ngân không thành công.";
                    dgvDanhSachNhanVien.DataSource = bll.LoadThuNganData();
                    break;
                case "Tiếp tân":
                    check = quanLyNVBLL.Addtt(manv, ten, sdt, cccd, diachi, ngaysinh, ngayvaolam, gioitinh);
                    thongbao = check ? "Thêm nhân viên tiếp tân thành công." : "Thêm nhân viên tiếp tân không thành công.";
                    dgvDanhSachNhanVien.DataSource = bll.LoadTiepTanData(); ;
                    break;
                default:
                    thongbao = "Loại nhân viên không hợp lệ.";
                    break;
            }
            MessageBox.Show(thongbao);
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

            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                QuanLyNVBLL quanLyNVBLL = new QuanLyNVBLL();
                //bool xoaThanhCong = quanLyNVBLL.XoaNhanVien(manv, loainv);

                if (quanLyNVBLL.XoaNhanVien(manv, loainv))
                {
                    MessageBox.Show("Đã xóa nhân viên thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    switch (loainv)
                    {
                        case "Tạp vụ":
                            dgvDanhSachNhanVien.DataSource = quanLyNVBLL.LoadTapVuData();
                            break;
                        case "Thu ngân":
                            dgvDanhSachNhanVien.DataSource = quanLyNVBLL.LoadThuNganData();
                            break;
                        case "Tiếp tân":
                            dgvDanhSachNhanVien.DataSource = quanLyNVBLL.LoadTiepTanData();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên không thành công. Vui lòng thử lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            //txtloainhanvien.SelectedIndex = -1;
            txtTenDangNhap.Clear();
            cbGioiTinh.SelectedIndex = -1;
        }

        private void txtloainhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string loainv = txtloainhanvien.SelectedItem.ToString();
            switch (txtloainhanvien.Text)
            {
                case "Tạp vụ":
                    dgvDanhSachNhanVien.DataSource = bll.LoadTapVuData();
                    break;
                case "Thu ngân":
                    dgvDanhSachNhanVien.DataSource = bll.LoadThuNganData();
                    break;
                case "Tiếp tân":
                    dgvDanhSachNhanVien.DataSource = bll.LoadTiepTanData();
                    break;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tk = txtTimKiem.Text.Trim();

            if (string.IsNullOrEmpty(tk))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (bll.TimKiemTapVu(tk).Rows.Count > 0)
            {
                dgvDanhSachNhanVien.DataSource = bll.TimKiemTapVu(tk);
                txtTimKiem.Clear();
            }
            else if (bll.TimKiemThuNgan(tk).Rows.Count > 0)
            {
                dgvDanhSachNhanVien.DataSource = bll.TimKiemThuNgan(tk);
                txtTimKiem.Clear();
            }
            else if (bll.TimKiemTiepTan(tk).Rows.Count > 0)
            {
                dgvDanhSachNhanVien.DataSource = bll.TimKiemTiepTan(tk);
                txtTimKiem.Clear();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin cho từ khóa đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCapNhatNhanVien_Click(object sender, EventArgs e)
        {
            string maNV = txtmanv.Text.Trim();
            string tenNV = txtTen.Text.Trim();
            string sdt = txtsdt.Text;
            string cccd = txtCCCD.Text.Trim();
            string diaChi = txtdiachi.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value;
            DateTime ngayVaoLam = dtpNgayVaoLam.Value;
            string gioiTinh = cbGioiTinh.Text;
            //string loaiNV = txtloainhanvien.Text.Trim();      


            QuanLyNVBLL quanLyNVBLL = new QuanLyNVBLL();
            string thongbao;
            bool check = false;
            switch (txtloainhanvien.Text)
            {
                case "Tạp vụ":
                    check  = quanLyNVBLL.CapNhatNhanVienTapVu(maNV, tenNV, sdt, cccd, diaChi, ngaySinh, ngayVaoLam, gioiTinh);
                    thongbao = check ? "Cập nhật nhân viên tạp vụ thành công." : "Cập nhật nhân viên tạp vụ không thành công.";
                    break;
                case "Thu ngân":
                    check = quanLyNVBLL.CapNhatNhanVienThuNgan(maNV, tenNV, sdt, cccd, diaChi, ngaySinh, ngayVaoLam, gioiTinh);
                    thongbao = check ? "Cập nhật nhân viên thu ngân thành công." : "Cập nhật nhân viên thu ngân không thành công.";
                    break;
                case "Tiếp tân":
                    check = quanLyNVBLL.CapNhatNhanVienTiepTan(maNV, tenNV, sdt, cccd, diaChi, ngaySinh, ngayVaoLam, gioiTinh);
                    thongbao = check ? "Cập nhật nhân viên tiếp tân thành công." : "Cập nhật nhân viên tiếp tân không thành công.";
                    break;
                default:
                    MessageBox.Show("Loại nhân viên không hợp lệ.");
                    break;
            }
        }
    }
}