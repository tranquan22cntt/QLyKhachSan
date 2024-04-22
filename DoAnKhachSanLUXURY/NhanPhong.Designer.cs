namespace DoAnKhachSanLUXURY
{
    partial class frmNhanPhong
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
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            txtMaDatPhong = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnTimKiem = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            cbbPhong = new System.Windows.Forms.ComboBox();
            cbbLoaiPhong = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            dgvDanhSachNhanPhongTrongNgay = new System.Windows.Forms.DataGridView();
            btnXemChiTiet = new System.Windows.Forms.Button();
            groupBox4 = new System.Windows.Forms.GroupBox();
            txtGia = new System.Windows.Forms.TextBox();
            txtSLNguoiToiDa = new System.Windows.Forms.TextBox();
            txtNgayTra = new System.Windows.Forms.TextBox();
            txtNgayNhan = new System.Windows.Forms.TextBox();
            txtTenLoaiPhong = new System.Windows.Forms.TextBox();
            txtTenPhong = new System.Windows.Forms.TextBox();
            txtTheCanCuoc = new System.Windows.Forms.TextBox();
            txtHoVaTen = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            groupBox5 = new System.Windows.Forms.GroupBox();
            btnDong = new System.Windows.Forms.Button();
            btnHuy = new System.Windows.Forms.Button();
            btnNhanPhong = new System.Windows.Forms.Button();
            btnThemKhachHang = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanPhongTrongNgay).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 19.8000011F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.SteelBlue;
            label1.Location = new System.Drawing.Point(24, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(202, 41);
            label1.TabIndex = 0;
            label1.Text = "Nhận Phòng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaDatPhong);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnTimKiem);
            groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox1.Location = new System.Drawing.Point(32, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(224, 146);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // txtMaDatPhong
            // 
            txtMaDatPhong.Location = new System.Drawing.Point(24, 52);
            txtMaDatPhong.Name = "txtMaDatPhong";
            txtMaDatPhong.Size = new System.Drawing.Size(175, 28);
            txtMaDatPhong.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(25, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 21);
            label2.TabIndex = 1;
            label2.Text = "Mã đặt phòng:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new System.Drawing.Point(25, 101);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new System.Drawing.Size(175, 30);
            btnTimKiem.TabIndex = 0;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbbPhong);
            groupBox2.Controls.Add(cbbLoaiPhong);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox2.Location = new System.Drawing.Point(262, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(224, 146);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng trống";
            // 
            // cbbPhong
            // 
            cbbPhong.FormattingEnabled = true;
            cbbPhong.Location = new System.Drawing.Point(27, 103);
            cbbPhong.Name = "cbbPhong";
            cbbPhong.Size = new System.Drawing.Size(175, 29);
            cbbPhong.TabIndex = 3;
            // 
            // cbbLoaiPhong
            // 
            cbbLoaiPhong.FormattingEnabled = true;
            cbbLoaiPhong.Location = new System.Drawing.Point(27, 47);
            cbbLoaiPhong.Name = "cbbLoaiPhong";
            cbbLoaiPhong.Size = new System.Drawing.Size(175, 29);
            cbbLoaiPhong.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(16, 79);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 21);
            label4.TabIndex = 1;
            label4.Text = "Phòng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 24);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 21);
            label3.TabIndex = 0;
            label3.Text = "Loại phòng:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox3.Controls.Add(dgvDanhSachNhanPhongTrongNgay);
            groupBox3.Controls.Add(btnXemChiTiet);
            groupBox3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox3.Location = new System.Drawing.Point(508, 62);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(494, 534);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách nhận phòng trong ngày";
            // 
            // dgvDanhSachNhanPhongTrongNgay
            // 
            dgvDanhSachNhanPhongTrongNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhanPhongTrongNgay.Location = new System.Drawing.Point(6, 27);
            dgvDanhSachNhanPhongTrongNgay.Name = "dgvDanhSachNhanPhongTrongNgay";
            dgvDanhSachNhanPhongTrongNgay.RowHeadersWidth = 51;
            dgvDanhSachNhanPhongTrongNgay.Size = new System.Drawing.Size(482, 461);
            dgvDanhSachNhanPhongTrongNgay.TabIndex = 1;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.Location = new System.Drawing.Point(313, 493);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new System.Drawing.Size(175, 35);
            btnXemChiTiet.TabIndex = 0;
            btnXemChiTiet.Text = "Xem chi tiết";
            btnXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtGia);
            groupBox4.Controls.Add(txtSLNguoiToiDa);
            groupBox4.Controls.Add(txtNgayTra);
            groupBox4.Controls.Add(txtNgayNhan);
            groupBox4.Controls.Add(txtTenLoaiPhong);
            groupBox4.Controls.Add(txtTenPhong);
            groupBox4.Controls.Add(txtTheCanCuoc);
            groupBox4.Controls.Add(txtHoVaTen);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox4.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox4.Location = new System.Drawing.Point(32, 214);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(454, 267);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin nhận phòng";
            // 
            // txtGia
            // 
            txtGia.Location = new System.Drawing.Point(246, 233);
            txtGia.Name = "txtGia";
            txtGia.Size = new System.Drawing.Size(175, 28);
            txtGia.TabIndex = 15;
            // 
            // txtSLNguoiToiDa
            // 
            txtSLNguoiToiDa.Location = new System.Drawing.Point(246, 174);
            txtSLNguoiToiDa.Name = "txtSLNguoiToiDa";
            txtSLNguoiToiDa.Size = new System.Drawing.Size(175, 28);
            txtSLNguoiToiDa.TabIndex = 14;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new System.Drawing.Point(246, 119);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new System.Drawing.Size(175, 28);
            txtNgayTra.TabIndex = 13;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new System.Drawing.Point(246, 64);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new System.Drawing.Size(175, 28);
            txtNgayNhan.TabIndex = 12;
            // 
            // txtTenLoaiPhong
            // 
            txtTenLoaiPhong.Location = new System.Drawing.Point(25, 233);
            txtTenLoaiPhong.Name = "txtTenLoaiPhong";
            txtTenLoaiPhong.Size = new System.Drawing.Size(175, 28);
            txtTenLoaiPhong.TabIndex = 11;
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new System.Drawing.Point(25, 174);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new System.Drawing.Size(175, 28);
            txtTenPhong.TabIndex = 10;
            // 
            // txtTheCanCuoc
            // 
            txtTheCanCuoc.Location = new System.Drawing.Point(25, 119);
            txtTheCanCuoc.Name = "txtTheCanCuoc";
            txtTheCanCuoc.Size = new System.Drawing.Size(175, 28);
            txtTheCanCuoc.TabIndex = 9;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new System.Drawing.Point(25, 64);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new System.Drawing.Size(175, 28);
            txtHoVaTen.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(246, 205);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(40, 21);
            label12.TabIndex = 7;
            label12.Text = "Giá:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(25, 205);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(125, 21);
            label11.TabIndex = 6;
            label11.Text = "Tên loại phòng:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(244, 150);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(174, 21);
            label10.TabIndex = 5;
            label10.Text = "Số lượng người tối đa:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(25, 150);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(94, 21);
            label9.TabIndex = 4;
            label9.Text = "Tên phòng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(246, 95);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(79, 21);
            label8.TabIndex = 3;
            label8.Text = "Ngày trả:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(25, 95);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(178, 21);
            label7.TabIndex = 2;
            label7.Text = "Thẻ căn cước / CMND:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(246, 40);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(94, 21);
            label6.TabIndex = 1;
            label6.Text = "Ngày nhận:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(25, 40);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(87, 21);
            label5.TabIndex = 0;
            label5.Text = "Họ và tên:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnDong);
            groupBox5.Controls.Add(btnHuy);
            groupBox5.Controls.Add(btnNhanPhong);
            groupBox5.Controls.Add(btnThemKhachHang);
            groupBox5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox5.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox5.Location = new System.Drawing.Point(32, 487);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(454, 109);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
            // 
            // btnDong
            // 
            btnDong.Location = new System.Drawing.Point(244, 70);
            btnDong.Name = "btnDong";
            btnDong.Size = new System.Drawing.Size(175, 35);
            btnDong.TabIndex = 3;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new System.Drawing.Point(21, 69);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(176, 35);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnNhanPhong
            // 
            btnNhanPhong.Location = new System.Drawing.Point(244, 28);
            btnNhanPhong.Name = "btnNhanPhong";
            btnNhanPhong.Size = new System.Drawing.Size(175, 35);
            btnNhanPhong.TabIndex = 1;
            btnNhanPhong.Text = "Nhận phòng";
            btnNhanPhong.UseVisualStyleBackColor = true;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.Location = new System.Drawing.Point(21, 25);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new System.Drawing.Size(176, 38);
            btnThemKhachHang.TabIndex = 0;
            btnThemKhachHang.Text = "Thêm khách hàng";
            btnThemKhachHang.UseVisualStyleBackColor = true;
            // 
            // frmNhanPhong
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1014, 608);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmNhanPhong";
            Text = "NhanPhong";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanPhongTrongNgay).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaDatPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbPhong;
        private System.Windows.Forms.ComboBox cbbLoaiPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSLNguoiToiDa;
        private System.Windows.Forms.TextBox txtNgayTra;
        private System.Windows.Forms.TextBox txtNgayNhan;
        private System.Windows.Forms.TextBox txtTenLoaiPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtTheCanCuoc;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnThemKhachHang;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.DataGridView dgvDanhSachNhanPhongTrongNgay;
    }
}