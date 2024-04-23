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
    public partial class frmNhanPhong : DevExpress.XtraEditors.XtraForm
    {
        LoadNhanPhongBLL Loadnhanphong;
        public frmNhanPhong()
        {
            InitializeComponent();
            Loadnhanphong = new LoadNhanPhongBLL();
        }

        private void frmNhanPhong_Load(object sender, EventArgs e)
        {
            LoadNP();
        }
        private void LoadNP()
        {
            dgvDanhSachNhanPhongTrongNgay.DataSource = Loadnhanphong.getDSnhanphong();
        }
    }
}