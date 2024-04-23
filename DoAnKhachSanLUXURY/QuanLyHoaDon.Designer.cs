namespace DoAnKhachSanLUXURY
{
    partial class frmQuanLyHoaDon
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnGiamSL = new System.Windows.Forms.Button();
            btnTangSL = new System.Windows.Forms.Button();
            txtSoLuong = new System.Windows.Forms.TextBox();
            txtGia = new System.Windows.Forms.TextBox();
            cbDichVu = new System.Windows.Forms.ComboBox();
            cbLoaiDichVu = new System.Windows.Forms.ComboBox();
            btnThemDichVu = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btnTangGia = new System.Windows.Forms.Button();
            btnGiamGia = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            btnDong = new System.Windows.Forms.Button();
            btnThanhToan = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            txtTongTien = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            groupBox3 = new System.Windows.Forms.GroupBox();
            dgvHoaDonTienPhong = new System.Windows.Forms.DataGridView();
            groupBox4 = new System.Windows.Forms.GroupBox();
            dgvChinhSachPhuThu = new System.Windows.Forms.DataGridView();
            groupBox5 = new System.Windows.Forms.GroupBox();
            dgvHoaDonDichVu = new System.Windows.Forms.DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonTienPhong).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChinhSachPhuThu).BeginInit();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonDichVu).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGiamSL);
            groupBox1.Controls.Add(btnTangSL);
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(cbDichVu);
            groupBox1.Controls.Add(cbLoaiDichVu);
            groupBox1.Controls.Add(btnThemDichVu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox1.Location = new System.Drawing.Point(12, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(366, 314);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách dịch vụ";
            // 
            // btnGiamSL
            // 
            btnGiamSL.Image = Properties.Resources.minus;
            btnGiamSL.Location = new System.Drawing.Point(318, 230);
            btnGiamSL.Name = "btnGiamSL";
            btnGiamSL.Size = new System.Drawing.Size(25, 24);
            btnGiamSL.TabIndex = 12;
            btnGiamSL.UseVisualStyleBackColor = true;
            btnGiamSL.Click += btnGiam_Click;
            // 
            // btnTangSL
            // 
            btnTangSL.Image = Properties.Resources.plus_button;
            btnTangSL.Location = new System.Drawing.Point(318, 197);
            btnTangSL.Name = "btnTangSL";
            btnTangSL.Size = new System.Drawing.Size(24, 27);
            btnTangSL.TabIndex = 11;
            btnTangSL.UseVisualStyleBackColor = true;
            btnTangSL.Click += btnTang_Click;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new System.Drawing.Point(22, 214);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new System.Drawing.Size(321, 28);
            txtSoLuong.TabIndex = 10;
            // 
            // txtGia
            // 
            txtGia.Location = new System.Drawing.Point(22, 159);
            txtGia.Name = "txtGia";
            txtGia.Size = new System.Drawing.Size(321, 28);
            txtGia.TabIndex = 9;
            // 
            // cbDichVu
            // 
            cbDichVu.FormattingEnabled = true;
            cbDichVu.Location = new System.Drawing.Point(22, 103);
            cbDichVu.Name = "cbDichVu";
            cbDichVu.Size = new System.Drawing.Size(321, 29);
            cbDichVu.TabIndex = 6;
            // 
            // cbLoaiDichVu
            // 
            cbLoaiDichVu.FormattingEnabled = true;
            cbLoaiDichVu.Location = new System.Drawing.Point(22, 47);
            cbLoaiDichVu.Name = "cbLoaiDichVu";
            cbLoaiDichVu.Size = new System.Drawing.Size(321, 29);
            cbLoaiDichVu.TabIndex = 5;
            // 
            // btnThemDichVu
            // 
            btnThemDichVu.Location = new System.Drawing.Point(97, 262);
            btnThemDichVu.Name = "btnThemDichVu";
            btnThemDichVu.Size = new System.Drawing.Size(188, 37);
            btnThemDichVu.TabIndex = 4;
            btnThemDichVu.Text = "Thêm dịch vụ";
            btnThemDichVu.UseVisualStyleBackColor = true;
            btnThemDichVu.Click += btnThemDichVu_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(22, 190);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(80, 21);
            label5.TabIndex = 3;
            label5.Text = "Số lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 135);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 21);
            label4.TabIndex = 2;
            label4.Text = "Giá:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 79);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(71, 21);
            label3.TabIndex = 1;
            label3.Text = "Dịch vụ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 24);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 21);
            label2.TabIndex = 0;
            label2.Text = "Loại dịch vụ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.SteelBlue;
            label1.Location = new System.Drawing.Point(12, -1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(454, 36);
            label1.TabIndex = 1;
            label1.Text = "Sử Dụng Dịch Vụ Và Thanh Toán";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTangGia);
            groupBox2.Controls.Add(btnGiamGia);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(btnDong);
            groupBox2.Controls.Add(btnThanhToan);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTongTien);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox2.Location = new System.Drawing.Point(12, 358);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(366, 228);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btnTangGia
            // 
            btnTangGia.Image = Properties.Resources.plus_button;
            btnTangGia.Location = new System.Drawing.Point(319, 99);
            btnTangGia.Name = "btnTangGia";
            btnTangGia.Size = new System.Drawing.Size(25, 24);
            btnTangGia.TabIndex = 16;
            btnTangGia.UseVisualStyleBackColor = true;
            // 
            // btnGiamGia
            // 
            btnGiamGia.Image = Properties.Resources.minus;
            btnGiamGia.Location = new System.Drawing.Point(319, 129);
            btnGiamGia.Name = "btnGiamGia";
            btnGiamGia.Size = new System.Drawing.Size(26, 24);
            btnGiamGia.TabIndex = 15;
            btnGiamGia.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(22, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(321, 28);
            textBox1.TabIndex = 14;
            // 
            // btnDong
            // 
            btnDong.Location = new System.Drawing.Point(94, 193);
            btnDong.Name = "btnDong";
            btnDong.Size = new System.Drawing.Size(191, 29);
            btnDong.TabIndex = 13;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new System.Drawing.Point(94, 155);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new System.Drawing.Size(191, 32);
            btnThanhToan.TabIndex = 12;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(22, 85);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(81, 21);
            label7.TabIndex = 11;
            label7.Text = "Giảm giá:";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new System.Drawing.Point(22, 46);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new System.Drawing.Size(321, 28);
            txtTongTien.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(22, 24);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(86, 21);
            label6.TabIndex = 0;
            label6.Text = "Tổng tiền:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox3.Controls.Add(dgvHoaDonTienPhong);
            groupBox3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox3.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox3.Location = new System.Drawing.Point(399, 38);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(504, 124);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa đơn tiền phòng";
            // 
            // dgvHoaDonTienPhong
            // 
            dgvHoaDonTienPhong.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvHoaDonTienPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonTienPhong.Location = new System.Drawing.Point(6, 19);
            dgvHoaDonTienPhong.Name = "dgvHoaDonTienPhong";
            dgvHoaDonTienPhong.RowHeadersWidth = 51;
            dgvHoaDonTienPhong.Size = new System.Drawing.Size(492, 97);
            dgvHoaDonTienPhong.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox4.Controls.Add(dgvChinhSachPhuThu);
            groupBox4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox4.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox4.Location = new System.Drawing.Point(399, 168);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(504, 150);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Chính sách phụ thu";
            // 
            // dgvChinhSachPhuThu
            // 
            dgvChinhSachPhuThu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvChinhSachPhuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChinhSachPhuThu.Location = new System.Drawing.Point(6, 20);
            dgvChinhSachPhuThu.Name = "dgvChinhSachPhuThu";
            dgvChinhSachPhuThu.RowHeadersWidth = 51;
            dgvChinhSachPhuThu.Size = new System.Drawing.Size(492, 124);
            dgvChinhSachPhuThu.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            groupBox5.Controls.Add(dgvHoaDonDichVu);
            groupBox5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            groupBox5.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox5.Location = new System.Drawing.Point(399, 324);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new System.Drawing.Size(504, 262);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Hóa đơn dịch vụ";
            // 
            // dgvHoaDonDichVu
            // 
            dgvHoaDonDichVu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvHoaDonDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonDichVu.Location = new System.Drawing.Point(6, 23);
            dgvHoaDonDichVu.Name = "dgvHoaDonDichVu";
            dgvHoaDonDichVu.RowHeadersWidth = 51;
            dgvHoaDonDichVu.Size = new System.Drawing.Size(492, 233);
            dgvHoaDonDichVu.TabIndex = 0;
            dgvHoaDonDichVu.CellContentClick += dgvHoaDonDichVu_CellContentClick;
            // 
            // frmQuanLyHoaDon
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(943, 598);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "frmQuanLyHoaDon";
            Text = "QuanLyHoaDon";
            Load += frmQuanLyHoaDon_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonTienPhong).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChinhSachPhuThu).EndInit();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonDichVu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ComboBox cbDichVu;
        private System.Windows.Forms.ComboBox cbLoaiDichVu;
        private System.Windows.Forms.Button btnThemDichVu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvHoaDonTienPhong;
        private System.Windows.Forms.DataGridView dgvChinhSachPhuThu;
        private System.Windows.Forms.DataGridView dgvHoaDonDichVu;
        private System.Windows.Forms.Button btnGiamSL;
        private System.Windows.Forms.Button btnTangSL;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTangGia;
        private System.Windows.Forms.Button btnGiamGia;
    }
}