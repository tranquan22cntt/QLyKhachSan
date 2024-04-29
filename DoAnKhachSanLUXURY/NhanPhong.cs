    using BLL;
    using DAO;
    using DevExpress.XtraEditors;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
using System.Data.SqlClient;
using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static DAO.ThemKhachHangDAO;
    namespace DoAnKhachSanLUXURY
    {
    public partial class frmNhanPhong : DevExpress.XtraEditors.XtraForm
    {
        LoadNhanPhongBLL Loadnhanphong;
        XemPhongTrongBLL XemPhongtrong;
        ThemKhachHangDAO themKhachHangDAO;
        ThemKhachHangBLL themKhachHangBLL;

        public frmNhanPhong()
        {
            InitializeComponent();
            Loadnhanphong = new LoadNhanPhongBLL();
            XemPhongtrong = new XemPhongTrongBLL();
            themKhachHangDAO = new ThemKhachHangDAO();
            themKhachHangBLL = new ThemKhachHangBLL();

        }

        private void frmNhanPhong_Load(object sender, EventArgs e)
        {
            LoadNP();
        }
        private void LoadNP()
        {
            dgvDanhSachNhanPhongTrongNgay.DataSource = Loadnhanphong.getDSnhanphong();
        }
        private void LoadPhongtrong()
        {
            dgvDanhSachNhanPhongTrongNgay.DataSource = XemPhongtrong.getDSphongtrong();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadNP();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Lấy mã phòng từ ô nhập liệu
            string maPhong = txtMaDatPhong.Text.Trim();

            // Kiểm tra xem mã phòng có được nhập hay không
            if (string.IsNullOrEmpty(maPhong))
            {
                MessageBox.Show("Vui lòng nhập mã phòng cần tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Khởi tạo đối tượng BLL
            TimMaPhongBLL timMaPhongBLL = new TimMaPhongBLL();

            try
            {
                // Gọi phương thức để lấy danh sách nhận phòng dựa trên mã phòng
                List<object> danhSachNhanPhong = timMaPhongBLL.getDSnhanphongbymaphong(maPhong);

                // Hiển thị danh sách lên DataGridView
                dgvDanhSachNhanPhongTrongNgay.DataSource = danhSachNhanPhong;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvDanhSachNhanPhongTrongNgay_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSachNhanPhongTrongNgay.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDanhSachNhanPhongTrongNgay.SelectedRows[0];

                // Lấy dữ liệu từ các ô của dòng được chọn
                string hoVaTen = selectedRow.Cells["TENKH"].Value?.ToString();
                string ngayNhan = selectedRow.Cells["NGAYNHANPHONG"].Value?.ToString();
                string theCanCuoc = selectedRow.Cells["CCCD"].Value?.ToString();
                string ngayTra = selectedRow.Cells["NGAYDEN"].Value?.ToString();
                string tenPhong = selectedRow.Cells["MAPHONG"].Value?.ToString(); // Đổi tên cột nếu cần
                string soLuongNguoiToiDa = selectedRow.Cells["SUCCHUA"].Value?.ToString(); // Đổi tên cột nếu cần
                string tenLoaiPhong = selectedRow.Cells["LOAIPHONG"].Value?.ToString();
                string gia = selectedRow.Cells["GIATIEN"].Value?.ToString();

                // Cập nhật giá trị của các điều khiển khác
                txtHoVaTen.Text = hoVaTen;
                dtpNgayNhan.Text = ngayNhan;
                txtTheCanCuoc.Text = theCanCuoc;
                dtpNgaytra.Text = ngayTra;
                txtTenPhong.Text = tenPhong;
                txtSLNguoiToiDa.Text = soLuongNguoiToiDa;
                txtTenLoaiPhong.Text = tenLoaiPhong;
                txtGia.Text = gia;
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            
            string maxMakh = themKhachHangDAO.GetMaxMakh();

            // Tạo Makh mới dựa trên Makh lớn nhất
            string newMakh = themKhachHangBLL.GenerateNewMakh(maxMakh);

            KhachHangInfo khachHangInfo = new KhachHangInfo
            {
                // Gán Makh mới cho thông tin khách hàng
                MaKH = newMakh,
                HoTen = txtHoVaTen.Text.Trim(),
                CCCD = txtTheCanCuoc.Text.Trim(),
                NgayNhan = dtpNgayNhan.Value,
                NgayTra = dtpNgaytra.Value,
                MaPhong = txtMaDatPhong.Text.Trim(),
                SoPhong = txtTenPhong.Text.Trim()
            };
            
            // Thêm khách hàng và cập nhật phòng
            try
            {
                themKhachHangBLL.ThemKhachHangVaCapNhatPhong(khachHangInfo);
                MessageBox.Show("Customer added and room updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNP();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LoadPhongtrong();
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}