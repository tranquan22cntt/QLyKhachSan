using BLL;
using DAO;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnKhachSanLUXURY
{
    public partial class frmQuanLyHoaDon : DevExpress.XtraEditors.XtraForm
    {
        private int quantity = 0;
        LoadDVBLL themDichVuBLL;
        HoaDonTienPhongBLL HoaDonTienPhongBLL;
        ThanhToanBLL ThanhToanBLL;
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
            themDichVuBLL = new LoadDVBLL();
            HoaDonTienPhongBLL = new HoaDonTienPhongBLL();
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            quantity++;
            UpdateQuantity(); // Cập nhật hiển thị số lượng
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (quantity > 0)
            {
                quantity--;
                UpdateQuantity(); // Cập nhật hiển thị số lượng
            }

        }
        private void UpdateQuantity()
        {
            txtSoLuong.Text = quantity.ToString(); // Hiển thị số lượng trong TextBox
        }

        private void dgvHoaDonDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadDV();
            HoaDonTienPhong();

            ChinhSachPhuThuBLL chinhSachPhuThuBLL = new ChinhSachPhuThuBLL();
            List<ChinhSachPhuThu> danhSach = chinhSachPhuThuBLL.GetDanhSachChinhSachPhuThu();

            dgvChinhSachPhuThu.Rows.Clear();

            if (dgvChinhSachPhuThu.Columns.Count == 0)
            {
                dgvChinhSachPhuThu.Columns.Add("MaPhuThu", "Mã Phụ Thu");
                dgvChinhSachPhuThu.Columns.Add("MoTa", "Mô Tả");
                dgvChinhSachPhuThu.Columns.Add("PhanTramPhuThu", "Phần Trăm Phụ Thu");
            }

            foreach (ChinhSachPhuThu chinhSachPhuThu in danhSach)
            {
                dgvChinhSachPhuThu.Rows.Add(chinhSachPhuThu.MaPhuThu, chinhSachPhuThu.MoTa, chinhSachPhuThu.PhanTramPhuThu);
            }
        }

        private void LoadDV()
        {
            dgvHoaDonDichVu.DataSource = themDichVuBLL.GetDichVu();
        }
        private void HoaDonTienPhong()
        {
            dgvHoaDonTienPhong.DataSource = HoaDonTienPhongBLL.GetHoaDon();
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            
            string MADV = txtMaDV.Text;
            string SANPHAM = cbSanPham.Text;
            string loaidv = cbLoaiDichVu.Text;
            decimal GIATIEN = Convert.ToDecimal(txtGia.Text);
            int SOLUONG = int.Parse(txtSoLuong.Text);

            ThemDichVuBLL dvBLL = new ThemDichVuBLL();
            bool isSuccess = dvBLL.ThemDichVu(MADV, SANPHAM, loaidv, GIATIEN, SOLUONG);

            if (isSuccess)
            {
                MessageBox.Show("Thêm dịch vụ thành công!");
                LoadDV();
            }
            else
                MessageBox.Show("Thêm dịch vụ thất bại!");
        }

        private void dgvChinhSachPhuThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTongTien.Text))
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để thanh toán.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem người dùng đã nhập giảm giá chưa
            if (string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                MessageBox.Show("Vui lòng nhập giảm giá.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem người dùng đã nhập giảm giá hợp lệ chưa
            if (!decimal.TryParse(txtGiamGia.Text, out decimal giamGia) || giamGia < 0 || giamGia >= Convert.ToDecimal(txtTongTien.Text))
            {
                MessageBox.Show("Giảm giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tính tổng tiền cần thanh toán sau khi áp dụng giảm giá
            decimal tongTien = Convert.ToDecimal(txtTongTien.Text) - giamGia;

            // Hiển thị thông báo
            MessageBox.Show("Đã thanh toán thành công. Tổng tiền cần thanh toán là: " + tongTien.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Sau khi thanh toán xong, đặt lại giá trị của TextBox tổng tiền và TextBox giảm giá
            txtTongTien.Text = "";
            txtGiamGia.Text = "";
        }

        private DataGridViewRow selectedTienPhongRow;
        private DataGridViewRow selectedDichVuRow;

        private void dgvHoaDonTienPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDonTienPhong.Rows[e.RowIndex];
                string TONGTHANHTOAN = row.Cells["TONGTHANHTOAN"].Value.ToString();
                txtTongTien.Text = TONGTHANHTOAN;

            }
        }

        private void dgvHoaDonDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDonDichVu.Rows[e.RowIndex];
                string TONGTHANHTOAN = row.Cells["GIATIEN"].Value.ToString();
                txtTongTien.Text = TONGTHANHTOAN;
            }
        }
    }
}