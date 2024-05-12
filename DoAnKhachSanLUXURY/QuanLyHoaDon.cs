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
        public string MAHD="";
        private int quantity = 0;
        LoadDVBLL themDichVuBLL;
        HoaDonTienPhongBLL HoaDonTienPhongBLL;
        ThanhToanBLL Thanhtoan;

        private readonly HoaDonTienPhongDAO _HoaDonTienPhongDAO = new HoaDonTienPhongDAO();
        private readonly LoadDVDAO _LoadDVDAO = new LoadDVDAO();

        public frmQuanLyHoaDon()
        {
            InitializeComponent();
            themDichVuBLL = new LoadDVBLL();
            HoaDonTienPhongBLL = new HoaDonTienPhongBLL();
            Thanhtoan = new ThanhToanBLL();
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

            if (dgvHoaDonTienPhong.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvHoaDonTienPhong.SelectedRows[0];
                MAHD = row.Cells["MAHD"].Value.ToString();
                string TONGTHANHTOAN = row.Cells["TONGTHANHTOAN"].Value.ToString();
                txtTongTien.Text = TONGTHANHTOAN;
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

        }
        private void dgvHoaDonTienPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDonTienPhong.Rows[e.RowIndex];
                string TONGTHANHTOAN = row.Cells["TONGTHANHTOAN"].Value.ToString();
                txtTongTien.Text = TONGTHANHTOAN;
                MAHD = row.Cells["MAHD"].Value.ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Thanhtoan.ThanhToanHoaDonTienPhong(MAHD);
            if (string.IsNullOrEmpty(txtTongTien.Text))
            {
                //MessageBox.Show("Vui lòng chọn một hóa đơn để thanh toán.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          

            if (!decimal.TryParse(txtGiamGia.Text, out decimal giamGia) || giamGia < 0 || giamGia >= Convert.ToDecimal(txtTongTien.Text))
            {
                MessageBox.Show("Giảm giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal tongTien = Convert.ToDecimal(txtTongTien.Text) - giamGia;

            MessageBox.Show("Đã thanh toán thành công. Tổng tiền cần thanh toán là: " + tongTien.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTongTien.Text = "";
            txtGiamGia.Text = "";
        }

        private DataGridViewRow selectedTienPhongRow;
        /*private DataGridViewRow selectedDichVuRow;*/
        //hihi
        
        /*private void dgvHoaDonDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvHoaDonDichVu.Rows[e.RowIndex];
                string TONGTHANHTOAN = row.Cells["GIATIEN"].Value.ToString();
                txtTongTien.Text = TONGTHANHTOAN;
            }
        }*/

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                _HoaDonTienPhongDAO.Export(saveFileDialog.FileName);

                _LoadDVDAO.Export(saveFileDialog.FileName);
            }
        }
    }
}