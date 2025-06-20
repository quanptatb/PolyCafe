namespace PolyCafe
{
    partial class frmLogin
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
            lblDangNhap = new Label();
            lblTenDangNhap = new Label();
            lblMatKhau = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            chkHienThiMatKhau = new CheckBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lblDangNhap
            // 
            lblDangNhap.AutoEllipsis = true;
            lblDangNhap.AutoSize = true;
            lblDangNhap.Font = new Font("Segoe UI", 25F);
            lblDangNhap.Location = new Point(155, 39);
            lblDangNhap.Name = "lblDangNhap";
            lblDangNhap.Size = new Size(213, 46);
            lblDangNhap.TabIndex = 0;
            lblDangNhap.Text = "ĐĂNG NHẬP";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.AutoSize = true;
            lblTenDangNhap.Font = new Font("Segoe UI", 13F);
            lblTenDangNhap.Location = new Point(37, 108);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(129, 25);
            lblTenDangNhap.TabIndex = 1;
            lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Font = new Font("Segoe UI", 13F);
            lblMatKhau.Location = new Point(37, 186);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(86, 25);
            lblMatKhau.TabIndex = 3;
            lblMatKhau.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 13F);
            txtTenDangNhap.Location = new Point(37, 136);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(432, 31);
            txtTenDangNhap.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 13F);
            txtMatKhau.Location = new Point(37, 214);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(432, 31);
            txtMatKhau.TabIndex = 5;
            // 
            // chkHienThiMatKhau
            // 
            chkHienThiMatKhau.AutoSize = true;
            chkHienThiMatKhau.Location = new Point(37, 251);
            chkHienThiMatKhau.Name = "chkHienThiMatKhau";
            chkHienThiMatKhau.Size = new Size(121, 19);
            chkHienThiMatKhau.TabIndex = 6;
            chkHienThiMatKhau.Text = "Hiển thị mật khẩu";
            chkHienThiMatKhau.UseVisualStyleBackColor = true;
            chkHienThiMatKhau.CheckedChanged += chkHienThiMatKhau_CheckedChanged;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.DodgerBlue;
            btnDangNhap.Font = new Font("Segoe UI", 13F);
            btnDangNhap.ForeColor = SystemColors.ButtonHighlight;
            btnDangNhap.Location = new Point(37, 295);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(432, 46);
            btnDangNhap.TabIndex = 7;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(255, 128, 128);
            btnThoat.Font = new Font("Segoe UI", 13F);
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Location = new Point(37, 347);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(432, 46);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 467);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(chkHienThiMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblMatKhau);
            Controls.Add(lblTenDangNhap);
            Controls.Add(lblDangNhap);
            Name = "frmLogin";
            Text = "Đăng nhập";
            FormClosing += frmLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDangNhap;
        private Label lblTenDangNhap;
        private Label lblMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private CheckBox chkHienThiMatKhau;
        private Button btnDangNhap;
        private Button btnThoat;
    }
}