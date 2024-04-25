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
    public partial class frmQuanLyHoaDon : DevExpress.XtraEditors.XtraForm
    {
        private int quantity = 0;
        LoadDVBLL themDichVuBLL;
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
            themDichVuBLL = new LoadDVBLL();
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
            ChinhSachPhuThuBLL chinhSachPhuThuBLL = new ChinhSachPhuThuBLL();
            List<ChinhSachPhuThu> danhSach = chinhSachPhuThuBLL.GetDanhSachChinhSachPhuThu();

            dgvChinhSachPhuThu.Rows.Clear();

            if (dgvChinhSachPhuThu.Columns.Count == 0)
            {
                dgvChinhSachPhuThu.Columns.Add("MaPhuThu", "Mã Phụ Thu");
                dgvChinhSachPhuThu.Columns.Add("MoTa", "Mô Tả");
                dgvChinhSachPhuThu.Columns.Add("PhanTramPhuThu", "Phần Trăm Phụ Thu");
            }

            // Thêm dòng dữ liệu vào DataGridView
            foreach (ChinhSachPhuThu chinhSachPhuThu in danhSach)
            {
                dgvChinhSachPhuThu.Rows.Add(chinhSachPhuThu.MaPhuThu, chinhSachPhuThu.MoTa, chinhSachPhuThu.PhanTramPhuThu);
            }
        }

        private void LoadDV()
        {
            dgvHoaDonDichVu.DataSource = themDichVuBLL.GetDichVu();
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {

        }
    }
}