    using BLL;
    using DAO;
    using DevExpress.Data.Svg;
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
        NhanPhongBLL nhanphong;
        HuyPhongBLL HuyPhong;
        public frmNhanPhong()
        {
            InitializeComponent();
            Loadnhanphong = new LoadNhanPhongBLL();
            XemPhongtrong = new XemPhongTrongBLL();
            themKhachHangDAO = new ThemKhachHangDAO();
            themKhachHangBLL = new ThemKhachHangBLL();
            nhanphong = new NhanPhongBLL();
            HuyPhong = new HuyPhongBLL();
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
            dgvDanhSachNhanPhongTrongNgay.DataSource = XemPhongtrong.GetDSPhongTrong();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadNP();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string maPhong = txtMaDatPhong.Text.Trim();


            if (string.IsNullOrEmpty(maPhong))
            {
                MessageBox.Show("Vui lòng nhập mã phòng cần tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            TimMaPhongBLL timMaPhongBLL = new TimMaPhongBLL();

            try
            {

                List<object> danhSachNhanPhong = timMaPhongBLL.getDSnhanphongbymaphong(maPhong);


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


                string hoVaTen = selectedRow.Cells["TENKH"].Value?.ToString();
                string ngayNhan = selectedRow.Cells["NGAYNHANPHONG"].Value?.ToString();
                string theCanCuoc = selectedRow.Cells["CCCD"].Value?.ToString();
                string ngayTra = selectedRow.Cells["NGAYDEN"].Value?.ToString();
                string tenPhong = selectedRow.Cells["SOPHONG"].Value?.ToString();
                string soLuongNguoiToiDa = selectedRow.Cells["SUCCHUA"].Value?.ToString();
                string tenLoaiPhong = selectedRow.Cells["LOAIPHONG"].Value?.ToString();
                string gia = selectedRow.Cells["GIATIEN"].Value?.ToString();
                string sdt = selectedRow.Cells["SDT"].Value?.ToString();
                string quocTich = selectedRow.Cells["QUOCTICH"].Value?.ToString();
                string maPhong = selectedRow.Cells["MAPHONG"].Value?.ToString();

                txtHoVaTen.Text = hoVaTen;
                dtpNgayNhan.Text = ngayNhan;
                txtTheCanCuoc.Text = theCanCuoc;
                dtpNgaytra.Text = ngayTra;
                txtTenPhong.Text = tenPhong;
                txtSLNguoiToiDa.Text = soLuongNguoiToiDa;
                txtTenLoaiPhong.Text = tenLoaiPhong;
                txtGia.Text = gia;
                txtSdt.Text = sdt;
                txtQuoctich.Text = quocTich;
                txtMaDatPhong.Text = maPhong;
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {

            string maxMakh = themKhachHangDAO.GetMaxMakh();


            string newMakh = themKhachHangBLL.GenerateNewMakh(maxMakh);
            if (!int.TryParse(txtSdt.Text.Trim(), out int sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            KhachHangInfo khachHangInfo = new KhachHangInfo
            {

                MaKH = newMakh,
                HoTen = txtHoVaTen.Text.Trim(),
                CCCD = txtTheCanCuoc.Text.Trim(),
                NgayNhan = dtpNgayNhan.Value,
                NgayTra = dtpNgaytra.Value,
                MaPhong = txtMaDatPhong.Text.Trim(),
                SoPhong = txtTenPhong.Text.Trim(),
                SDT = sdt,
                QuocTich = txtQuoctich.Text.Trim()
            };


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
            string maPhong = txtMaDatPhong.Text.Trim();


            if (string.IsNullOrEmpty(maPhong))
            {
                MessageBox.Show("Vui lòng nhập mã phòng cần nhận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                bool result = nhanphong.NhanPhong(maPhong);

                if (result)
                {
                    MessageBox.Show("Nhận phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadNP();
                }
                else
                {
                    MessageBox.Show("Nhận phòng không thành công. Vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi nhận phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void cbbLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimphongtrong_Click(object sender, EventArgs e)
        {
            string loaiPhong = cbbLoaiPhong.SelectedItem.ToString();
            var dataTable = XemPhongtrong.GetDSPhongTrongByLoaiPhong(loaiPhong);
            dgvDanhSachNhanPhongTrongNgay.DataSource = dataTable;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaDatPhong.Text.Trim();


            if (string.IsNullOrEmpty(maPhong))
            {
                MessageBox.Show("Vui lòng nhập mã phòng cần huỷ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                bool result = HuyPhong.HuyPhong(maPhong);

                if (result)
                {
                    MessageBox.Show("Huỷ phòng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadNP();
                }
                else
                {
                    MessageBox.Show("Huỷ phòng không thành công. Vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi huỷ phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}