using BLL;
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
    public partial class frmQuanLyDichVu : DevExpress.XtraEditors.XtraForm
    {
        LoadDVBLL loaddv;
        TimKiemDichVuBLL TimKiemdv;
        ThemDichVuBLL themDv;
        CapNhatDichVuBLL capnhatDv;
        XoaDichVuBLL xoaDv;
        public frmQuanLyDichVu()
        {
            InitializeComponent();
            loaddv = new LoadDVBLL();
            TimKiemdv = new TimKiemDichVuBLL();
            themDv = new ThemDichVuBLL();
            capnhatDv = new CapNhatDichVuBLL();
            xoaDv = new XoaDichVuBLL();
        }

        private void frmQuanLyDichVu_Load(object sender, EventArgs e)
        {
            LoadDV();
        }
        private void LoadDV()
        {
            dgvDsdichvu.DataSource = loaddv.GetDichVu();
        }
        private void dgvDanhSachNhanPhongTrongNgay_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDsdichvu.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvDsdichvu.SelectedRows[0];

                // Lấy dữ liệu từ các ô của dòng được chọn
                string maDichVu = selectedRow.Cells["MADV"].Value?.ToString(); // Giả sử mã dịch vụ được lấy từ cột "MaDichVu"
                string tenDichVu = selectedRow.Cells["SANPHAM"].Value?.ToString(); // Giả sử tên dịch vụ được lấy từ cột "TenDichVu"
                string gia = selectedRow.Cells["GIATIEN"].Value?.ToString(); // Giả sử giá dịch vụ được lấy từ cột "Gia"
                string loaiDichVu = selectedRow.Cells["LOAIDV"].Value?.ToString(); // Giả sử loại dịch vụ được lấy từ cột "LoaiDichVu"
                string soluong = selectedRow.Cells["SOLUONG"].Value?.ToString();
                // Cập nhật giá trị của các điều khiển trong form QuanLyDichVu
                txtSoluong.Text = soluong;
                txtMadv.Text = maDichVu;
                txtTenDichVu.Text = tenDichVu;
                txtGia.Text = gia;
                cbLoaiDichVu.SelectedItem = loaiDichVu; // Giả sử combobox cbLoaiDichVu có các mục tương ứng với loại dịch vụ
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenDichVu = txtTimKiemDichVu.Text.Trim(); // Giả sử thông tin tìm kiếm nhập trong textbox txtTimKiem


            DataTable dtKetQua = TimKiemdv.TimKiemDichVuTheoSanPham(tenDichVu);

            if (dtKetQua.Rows.Count > 0)
            {

                dgvDsdichvu.DataSource = dtKetQua;
            }
            else
            {

                MessageBox.Show("Không tìm thấy dịch vụ phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maDichVu = txtMadv.Text.Trim();
            string tenDichVu = txtTenDichVu.Text.Trim();
            decimal gia = 0;
            if (!decimal.TryParse(txtGia.Text.Trim(), out gia))
            {
                MessageBox.Show("Vui lòng nhập giá dịch vụ hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string loaiDichVu = cbLoaiDichVu.SelectedItem?.ToString();
            int soLuong = 0;
            if (!int.TryParse(txtSoluong.Text.Trim(), out soLuong))
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thông tin có đầy đủ không
            if (string.IsNullOrEmpty(maDichVu) || string.IsNullOrEmpty(tenDichVu) || string.IsNullOrEmpty(loaiDichVu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện thêm dịch vụ vào cơ sở dữ liệu
            bool result = themDv.ThemDichVu(maDichVu, tenDichVu, gia, loaiDichVu, soLuong);

            if (result)
            {
                MessageBox.Show("Đã thêm dịch vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi thêm thành công, bạn có thể làm các thao tác khác, ví dụ: load lại danh sách dịch vụ
                LoadDV();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDV();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maDichVu = txtMadv.Text.Trim();
            string tenDichVu = txtTenDichVu.Text.Trim();
            decimal gia = 0;
            if (!decimal.TryParse(txtGia.Text.Trim(), out gia))
            {
                MessageBox.Show("Vui lòng nhập giá dịch vụ hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string loaiDichVu = cbLoaiDichVu.SelectedItem?.ToString();
            int soLuong = 0;
            if (!int.TryParse(txtSoluong.Text.Trim(), out soLuong))
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thông tin có đầy đủ không
            if (string.IsNullOrEmpty(maDichVu) || string.IsNullOrEmpty(tenDichVu) || string.IsNullOrEmpty(loaiDichVu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện cập nhật dịch vụ vào cơ sở dữ liệu
            bool result = capnhatDv.CapNhatDichVu(maDichVu, tenDichVu, gia, loaiDichVu, soLuong);

            if (result)
            {
                MessageBox.Show("Đã cập nhật dịch vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sau khi cập nhật thành công, bạn có thể làm các thao tác khác, ví dụ: load lại danh sách dịch vụ
                LoadDV();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi cập nhật dịch vụ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtXoadv_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn dòng nào trên DataGridView chưa
            if (dgvDsdichvu.SelectedRows.Count > 0)
            {
                // Lấy mã dịch vụ của dòng được chọn
                string maDichVu = dgvDsdichvu.SelectedRows[0].Cells["MADV"].Value?.ToString();

                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa dịch vụ này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng đồng ý xóa
                if (result == DialogResult.Yes)
                {
                    // Thực hiện xóa dịch vụ từ cơ sở dữ liệu
                    bool deleteResult = xoaDv.XoaDichVu(maDichVu);

                    // Kiểm tra kết quả xóa
                    if (deleteResult)
                    {
                        MessageBox.Show("Đã xóa dịch vụ thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Sau khi xóa thành công, cập nhật lại danh sách dịch vụ trên DataGridView
                        LoadDV();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa dịch vụ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}