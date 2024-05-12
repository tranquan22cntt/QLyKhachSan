using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAnKhachSanLUXURY
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnNhanPhong_Click(object sender, EventArgs e)
        {

        }

        private void accordionControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            frmNhanPhong frm = new frmNhanPhong();
            frm.Show();

        }

        private void btnQLHoaDon_Click(object sender, EventArgs e)
        {
            frmQuanLyHoaDon frm = new frmQuanLyHoaDon();
            frm.Show();
        }

        private void btnQuyDinhKS_Click(object sender, EventArgs e)
        {
            frmQuyDinh frm = new frmQuyDinh();
            frm.Show();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVienn frm = new frmQuanLyNhanVienn();
            frm.Show();
        }

        private void btnQLDichVu_Click(object sender, EventArgs e)
        {
            frmQuanLyDichVu frm = new frmQuanLyDichVu();
            frm.Show();
        }

        private void aThô_Click(object sender, EventArgs e)
        {

        }
    }
}
