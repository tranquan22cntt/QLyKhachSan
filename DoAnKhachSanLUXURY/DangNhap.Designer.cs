namespace DoAnKhachSanLUXURY
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnThoat = new System.Windows.Forms.Button();
            btnDangNhap = new System.Windows.Forms.Button();
            txtMatKhau = new System.Windows.Forms.TextBox();
            txtTenDangNhap = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureEdit1
            // 
            pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new System.Drawing.Point(10, 32);
            pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Size = new System.Drawing.Size(412, 351);
            pictureEdit1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.SteelBlue;
            label1.Location = new System.Drawing.Point(423, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(208, 46);
            label1.TabIndex = 1;
            label1.Text = "Đăng Nhập";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnDangNhap);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            groupBox1.Location = new System.Drawing.Point(423, 85);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            groupBox1.Size = new System.Drawing.Size(333, 298);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnThoat.Location = new System.Drawing.Point(64, 239);
            btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new System.Drawing.Size(212, 41);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            btnDangNhap.Location = new System.Drawing.Point(64, 184);
            btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new System.Drawing.Size(212, 41);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new System.Drawing.Point(16, 105);
            txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new System.Drawing.Size(300, 21);
            txtMatKhau.TabIndex = 3;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new System.Drawing.Point(16, 45);
            txtTenDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new System.Drawing.Size(300, 21);
            txtTenDangNhap.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(16, 83);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 19);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(16, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(122, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập:";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(777, 414);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureEdit1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DangNhap";
            Text = "DangNhap";
            Load += DangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}