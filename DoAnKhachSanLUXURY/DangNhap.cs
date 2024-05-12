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
using System.Data.SqlClient;
using BLL;
namespace DoAnKhachSanLUXURY
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {
        private DangNhapBLL dangNhapBLL;
       
        public DangNhap()
        {
            InitializeComponent();
            dangNhapBLL =new DangNhapBLL();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhap.Text;
            string password = txtMatKhau.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng và mật khẩu.");
                return;
            }

           
            if (dangNhapBLL.DangNhap(username, password))
            {
                MessageBox.Show("Đăng nhập thành công.");
               
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng.");
            }
        }
    }
}