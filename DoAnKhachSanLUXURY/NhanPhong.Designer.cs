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
            label1.Location = new System.Drawing.Point(21, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(160, 33);
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
            groupBox1.Location = new System.Drawing.Point(27, 50);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(192, 119);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // txtMaDatPhong
            // 
            txtMaDatPhong.Location = new System.Drawing.Point(21, 42);
            txtMaDatPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMaDatPhong.Name = "txtMaDatPhong";
            txtMaDatPhong.Size = new System.Drawing.Size(151, 24);
            txtMaDatPhong.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(21, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 17);
            label2.TabIndex = 1;
            label2.Text = "Mã đặt phòng:";
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new System.Drawing.Point(21, 82);
            btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new System.Drawing.Size(150, 24);
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
            groupBox2.Location = new System.Drawing.Point(225, 50);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox2.Size = new System.Drawing.Size(192, 119);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách phòng trống";
            // 
            // cbbPhong
            // 
            cbbPhong.FormattingEnabled = true;
            cbbPhong.Location = new System.Drawing.Point(23, 84);
            cbbPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbbPhong.Name = "cbbPhong";
            cbbPhong.Size = new System.Drawing.Size(151, 25);
            cbbPhong.TabIndex = 3;
            // 
            // cbbLoaiPhong
            // 
            cbbLoaiPhong.FormattingEnabled = true;
            cbbLoaiPhong.Location = new System.Drawing.Point(23, 38);
            cbbLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cbbLoaiPhong.Name = "cbbLoaiPhong";
            cbbLoaiPhong.Size = new System.Drawing.Size(151, 25);
            cbbLoaiPhong.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 64);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(53, 17);
            label4.TabIndex = 1;
            label4.Text = "Phòng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 20);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 17);
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
            groupBox3.Location = new System.Drawing.Point(435, 50);
            groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox3.Size = new System.Drawing.Size(423, 434);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Danh sách nhận phòng trong ngày";
            // 
            // dgvDanhSachNhanPhongTrongNgay
            // 
            dgvDanhSachNhanPhongTrongNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachNhanPhongTrongNgay.Location = new System.Drawing.Point(5, 22);
            dgvDanhSachNhanPhongTrongNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvDanhSachNhanPhongTrongNgay.Name = "dgvDanhSachNhanPhongTrongNgay";
            dgvDanhSachNhanPhongTrongNgay.RowHeadersWidth = 51;
            dgvDanhSachNhanPhongTrongNgay.Size = new System.Drawing.Size(413, 375);
            dgvDanhSachNhanPhongTrongNgay.TabIndex = 1;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.Location = new System.Drawing.Point(268, 401);
            btnXemChiTiet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new System.Drawing.Size(150, 28);
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
            groupBox4.Location = new System.Drawing.Point(27, 174);
            groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox4.Size = new System.Drawing.Size(389, 217);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin nhận phòng";
            // 
            // txtGia
            // 
            txtGia.Location = new System.Drawing.Point(211, 189);
            txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtGia.Name = "txtGia";
            txtGia.Size = new System.Drawing.Size(151, 24);
            txtGia.TabIndex = 15;
            // 
            // txtSLNguoiToiDa
            // 
            txtSLNguoiToiDa.Location = new System.Drawing.Point(211, 141);
            txtSLNguoiToiDa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtSLNguoiToiDa.Name = "txtSLNguoiToiDa";
            txtSLNguoiToiDa.Size = new System.Drawing.Size(151, 24);
            txtSLNguoiToiDa.TabIndex = 14;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new System.Drawing.Point(211, 97);
            txtNgayTra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new System.Drawing.Size(151, 24);
            txtNgayTra.TabIndex = 13;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new System.Drawing.Point(211, 52);
            txtNgayNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new System.Drawing.Size(151, 24);
            txtNgayNhan.TabIndex = 12;
            // 
            // txtTenLoaiPhong
            // 
            txtTenLoaiPhong.Location = new System.Drawing.Point(21, 189);
            txtTenLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTenLoaiPhong.Name = "txtTenLoaiPhong";
            txtTenLoaiPhong.Size = new System.Drawing.Size(151, 24);
            txtTenLoaiPhong.TabIndex = 11;
            // 
            // txtTenPhong
            // 
            txtTenPhong.Location = new System.Drawing.Point(21, 141);
            txtTenPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTenPhong.Name = "txtTenPhong";
            txtTenPhong.Size = new System.Drawing.Size(151, 24);
            txtTenPhong.TabIndex = 10;
            // 
            // txtTheCanCuoc
            // 
            txtTheCanCuoc.Location = new System.Drawing.Point(21, 97);
            txtTheCanCuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTheCanCuoc.Name = "txtTheCanCuoc";
            txtTheCanCuoc.Size = new System.Drawing.Size(151, 24);
            txtTheCanCuoc.TabIndex = 9;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new System.Drawing.Point(21, 52);
            txtHoVaTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new System.Drawing.Size(151, 24);
            txtHoVaTen.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(211, 167);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(31, 17);
            label12.TabIndex = 7;
            label12.Text = "Giá:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(21, 167);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(103, 17);
            label11.TabIndex = 6;
            label11.Text = "Tên loại phòng:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(209, 122);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(145, 17);
            label10.TabIndex = 5;
            label10.Text = "Số lượng người tối đa:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(21, 122);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(80, 17);
            label9.TabIndex = 4;
            label9.Text = "Tên phòng:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(211, 77);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(66, 17);
            label8.TabIndex = 3;
            label8.Text = "Ngày trả:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(21, 77);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(148, 17);
            label7.TabIndex = 2;
            label7.Text = "Thẻ căn cước / CMND:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(211, 32);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(80, 17);
            label6.TabIndex = 1;
            label6.Text = "Ngày nhận:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(21, 32);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(73, 17);
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
            groupBox5.Location = new System.Drawing.Point(27, 396);
            groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox5.Size = new System.Drawing.Size(389, 89);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Chức năng";
            // 
            // btnDong
            // 
            btnDong.Location = new System.Drawing.Point(209, 57);
            btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDong.Name = "btnDong";
            btnDong.Size = new System.Drawing.Size(150, 28);
            btnDong.TabIndex = 3;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new System.Drawing.Point(18, 56);
            btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new System.Drawing.Size(151, 28);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnNhanPhong
            // 
            btnNhanPhong.Location = new System.Drawing.Point(209, 23);
            btnNhanPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnNhanPhong.Name = "btnNhanPhong";
            btnNhanPhong.Size = new System.Drawing.Size(150, 28);
            btnNhanPhong.TabIndex = 1;
            btnNhanPhong.Text = "Nhận phòng";
            btnNhanPhong.UseVisualStyleBackColor = true;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.Location = new System.Drawing.Point(18, 20);
            btnThemKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new System.Drawing.Size(151, 31);
            btnThemKhachHang.TabIndex = 0;
            btnThemKhachHang.Text = "Thêm khách hàng";
            btnThemKhachHang.UseVisualStyleBackColor = true;
            // 
            // frmNhanPhong
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(869, 494);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmNhanPhong";
            Text = "NhanPhong";
            Load += frmNhanPhong_Load;
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