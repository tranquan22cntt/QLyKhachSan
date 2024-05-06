namespace DoAnKhachSanLUXURY
{
    partial class frmQuanLyNhanVienn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDanhSachNhanVien = new System.Windows.Forms.DataGridView();
            dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            cbGioiTinh = new System.Windows.Forms.ComboBox();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            groupBox4 = new System.Windows.Forms.GroupBox();
            txtdiachi = new System.Windows.Forms.TextBox();
            txtsdt = new System.Windows.Forms.TextBox();
            txtCCCD = new System.Windows.Forms.TextBox();
            txtTen = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            btnDong = new System.Windows.Forms.Button();
            btnXoaNhanVien = new System.Windows.Forms.Button();
            btnThemNhanVien = new System.Windows.Forms.Button();
            btnCapNhatNhanVien = new System.Windows.Forms.Button();
            dtpNgayVaoLam = new System.Windows.Forms.DateTimePicker();
            txtTenDangNhap = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            txtloainhanvien = new System.Windows.Forms.ComboBox();
            btnTimKiem = new System.Windows.Forms.Button();
            txtTimKiem = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            groupBox5 = new System.Windows.Forms.GroupBox();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            groupBox3 = new System.Windows.Forms.GroupBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            txtmanv = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).BeginInit();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvDanhSachNhanVien
            // 
            dgvDanhSachNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvDanhSachNhanVien.BackgroundColor = System.Drawing.Color.White;
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhanVien.Location = new System.Drawing.Point(6, 29);
            dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            dgvDanhSachNhanVien.RowHeadersWidth = 51;
            dgvDanhSachNhanVien.Size = new System.Drawing.Size(354, 526);
            dgvDanhSachNhanVien.TabIndex = 0;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new System.Drawing.Point(13, 207);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new System.Drawing.Size(289, 28);
            dtpNgaySinh.TabIndex = 11;
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Items.AddRange(new object[] { "0", "1" });
            cbGioiTinh.Location = new System.Drawing.Point(13, 151);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new System.Drawing.Size(289, 29);
            cbGioiTinh.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(13, 287);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(67, 21);
            label11.TabIndex = 8;
            label11.Text = "Địa chỉ:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(13, 238);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(113, 21);
            label10.TabIndex = 7;
            label10.Text = "Số điện thoại:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(13, 183);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(88, 21);
            label9.TabIndex = 6;
            label9.Text = "Ngày sinh:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(13, 127);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(77, 21);
            label8.TabIndex = 5;
            label8.Text = "Giới tính:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(13, 78);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(85, 21);
            label7.TabIndex = 1;
            label7.Text = "Số CMND:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtdiachi);
            groupBox4.Controls.Add(txtsdt);
            groupBox4.Controls.Add(txtCCCD);
            groupBox4.Controls.Add(txtTen);
            groupBox4.Controls.Add(dtpNgaySinh);
            groupBox4.Controls.Add(cbGioiTinh);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox4.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox4.Location = new System.Drawing.Point(357, 71);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(317, 359);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin nhân viên";
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new System.Drawing.Point(13, 311);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new System.Drawing.Size(291, 28);
            txtdiachi.TabIndex = 16;
            // 
            // txtsdt
            // 
            txtsdt.Location = new System.Drawing.Point(13, 262);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new System.Drawing.Size(291, 28);
            txtsdt.TabIndex = 15;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new System.Drawing.Point(13, 102);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new System.Drawing.Size(291, 28);
            txtCCCD.TabIndex = 14;
            // 
            // txtTen
            // 
            txtTen.Location = new System.Drawing.Point(13, 48);
            txtTen.Name = "txtTen";
            txtTen.Size = new System.Drawing.Size(291, 28);
            txtTen.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(13, 29);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(44, 21);
            label6.TabIndex = 0;
            label6.Text = "Tên:";
            // 
            // btnDong
            // 
            btnDong.Location = new System.Drawing.Point(198, 87);
            btnDong.Name = "btnDong";
            btnDong.Size = new System.Drawing.Size(286, 49);
            btnDong.TabIndex = 3;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnXoaNhanVien
            // 
            btnXoaNhanVien.Location = new System.Drawing.Point(446, 27);
            btnXoaNhanVien.Name = "btnXoaNhanVien";
            btnXoaNhanVien.Size = new System.Drawing.Size(155, 54);
            btnXoaNhanVien.TabIndex = 2;
            btnXoaNhanVien.Text = "Xóa nhân viên";
            btnXoaNhanVien.UseVisualStyleBackColor = true;
            btnXoaNhanVien.Click += btnXoaNhanVien_Click;
            // 
            // btnThemNhanVien
            // 
            btnThemNhanVien.Location = new System.Drawing.Point(257, 27);
            btnThemNhanVien.Name = "btnThemNhanVien";
            btnThemNhanVien.Size = new System.Drawing.Size(155, 54);
            btnThemNhanVien.TabIndex = 1;
            btnThemNhanVien.Text = "Thêm nhân viên";
            btnThemNhanVien.UseVisualStyleBackColor = true;
            btnThemNhanVien.Click += btnThemNhanVien_Click;
            // 
            // btnCapNhatNhanVien
            // 
            btnCapNhatNhanVien.Location = new System.Drawing.Point(65, 27);
            btnCapNhatNhanVien.Name = "btnCapNhatNhanVien";
            btnCapNhatNhanVien.Size = new System.Drawing.Size(155, 54);
            btnCapNhatNhanVien.TabIndex = 0;
            btnCapNhatNhanVien.Text = "Cập nhật nhân viên";
            btnCapNhatNhanVien.UseVisualStyleBackColor = true;
            // 
            // dtpNgayVaoLam
            // 
            dtpNgayVaoLam.Location = new System.Drawing.Point(22, 188);
            dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            dtpNgayVaoLam.Size = new System.Drawing.Size(291, 28);
            dtpNgayVaoLam.TabIndex = 5;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new System.Drawing.Point(22, 60);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new System.Drawing.Size(291, 28);
            txtTenDangNhap.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(22, 164);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 21);
            label5.TabIndex = 2;
            label5.Text = "Ngày vào làm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 103);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(122, 21);
            label4.TabIndex = 1;
            label4.Text = "Loại nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 36);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(127, 21);
            label3.TabIndex = 0;
            label3.Text = "Tên đăng nhập:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtloainhanvien);
            groupBox2.Controls.Add(dtpNgayVaoLam);
            groupBox2.Controls.Add(txtTenDangNhap);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox2.Location = new System.Drawing.Point(22, 194);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(329, 236);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tài khoản nhân viên";
            // 
            // txtloainhanvien
            // 
            txtloainhanvien.FormattingEnabled = true;
            txtloainhanvien.Items.AddRange(new object[] { "Tạp vụ", "Thu ngân", "Tiếp tân" });
            txtloainhanvien.Location = new System.Drawing.Point(22, 134);
            txtloainhanvien.Name = "txtloainhanvien";
            txtloainhanvien.Size = new System.Drawing.Size(291, 29);
            txtloainhanvien.TabIndex = 6;
            txtloainhanvien.SelectedIndexChanged += txtloainhanvien_SelectedIndexChanged;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new System.Drawing.Point(97, 78);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new System.Drawing.Size(149, 27);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new System.Drawing.Point(22, 48);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new System.Drawing.Size(291, 28);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(17, 29);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(229, 21);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản/ Tên/ CMND/ SĐT:";
            // 
            // groupBox5
            // 
            groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox5.Controls.Add(dgvDanhSachNhanVien);
            groupBox5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox5.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox5.Location = new System.Drawing.Point(680, 12);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(589, 561);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "Danh sách nhân viên";
            // 
            // gridView1
            // 
            gridView1.Name = "gridView1";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDong);
            groupBox3.Controls.Add(btnXoaNhanVien);
            groupBox3.Controls.Add(btnThemNhanVien);
            groupBox3.Controls.Add(btnCapNhatNhanVien);
            groupBox3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox3.Location = new System.Drawing.Point(22, 436);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(652, 137);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Controls.Add(txtTimKiem);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox1.Location = new System.Drawing.Point(22, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(329, 117);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.SteelBlue;
            label1.Location = new System.Drawing.Point(16, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(335, 45);
            label1.TabIndex = 6;
            label1.Text = "Quản Lý Nhân Viên";
            // 
            // txtmanv
            // 
            txtmanv.Font = new System.Drawing.Font("Tahoma", 10.2F);
            txtmanv.Location = new System.Drawing.Point(370, 31);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new System.Drawing.Size(291, 28);
            txtmanv.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Tahoma", 10.2F);
            label12.ForeColor = System.Drawing.Color.SteelBlue;
            label12.Location = new System.Drawing.Point(370, 12);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(110, 21);
            label12.TabIndex = 17;
            label12.Text = "Mã Nhân viên";
            // 
            // frmQuanLyNhanVienn
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1065, 628);
            Controls.Add(label12);
            Controls.Add(txtmanv);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmQuanLyNhanVienn";
            Text = "QuanLyNhanVienn";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoaNhanVien;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Button btnCapNhatNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
     
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox txtloainhanvien;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label12;
    }
}