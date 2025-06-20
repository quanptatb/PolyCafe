namespace GUI_PolyCafe
{
    partial class frmMain
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
            menuStrip1 = new MenuStrip();
            heThongToolStripMenuItem = new ToolStripMenuItem();
            doiMatKhauToolStripMenuItem = new ToolStripMenuItem();
            thongTinTaiKhoanToolStripMenuItem = new ToolStripMenuItem();
            dangXuatToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            danhMucToolStripMenuItem = new ToolStripMenuItem();
            loaiSanPhamToolStripMenuItem = new ToolStripMenuItem();
            sanPhamToolStripMenuItem = new ToolStripMenuItem();
            banHangToolStripMenuItem = new ToolStripMenuItem();
            theLuuDongToolStripMenuItem = new ToolStripMenuItem();
            phieuBanHangToolStripMenuItem = new ToolStripMenuItem();
            nhanVienToolStripMenuItem = new ToolStripMenuItem();
            doanhThuToolStripMenuItem = new ToolStripMenuItem();
            loaiHangToolStripMenuItem = new ToolStripMenuItem();
            tkNhanVienToolStripMenuItem = new ToolStripMenuItem();
            huongDanToolStripMenuItem = new ToolStripMenuItem();
            hdSuDungToolStripMenuItem = new ToolStripMenuItem();
            gioiThieuPhanMemToolStripMenuItem = new ToolStripMenuItem();
            pnMain = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripTimer = new ToolStripStatusLabel();
            toolStripUserName = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            pnMain.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Font = new Font("Times New Roman", 13F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { heThongToolStripMenuItem, danhMucToolStripMenuItem, banHangToolStripMenuItem, nhanVienToolStripMenuItem, doanhThuToolStripMenuItem, huongDanToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1598, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            heThongToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauToolStripMenuItem, thongTinTaiKhoanToolStripMenuItem, dangXuatToolStripMenuItem, thoatToolStripMenuItem });
            heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            heThongToolStripMenuItem.Size = new Size(94, 24);
            heThongToolStripMenuItem.Text = "Hệ Thống";
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(219, 24);
            doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            doiMatKhauToolStripMenuItem.Click += doiMatKhauToolStripMenuItem_Click;
            // 
            // thongTinTaiKhoanToolStripMenuItem
            // 
            thongTinTaiKhoanToolStripMenuItem.Name = "thongTinTaiKhoanToolStripMenuItem";
            thongTinTaiKhoanToolStripMenuItem.Size = new Size(219, 24);
            thongTinTaiKhoanToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // dangXuatToolStripMenuItem
            // 
            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            dangXuatToolStripMenuItem.Size = new Size(219, 24);
            dangXuatToolStripMenuItem.Text = "Đăng xuất";
            dangXuatToolStripMenuItem.Click += dangXuatToolStripMenuItem_Click;
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(219, 24);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;
            // 
            // danhMucToolStripMenuItem
            // 
            danhMucToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loaiSanPhamToolStripMenuItem, sanPhamToolStripMenuItem });
            danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            danhMucToolStripMenuItem.Size = new Size(96, 24);
            danhMucToolStripMenuItem.Text = "Danh mục";
            // 
            // loaiSanPhamToolStripMenuItem
            // 
            loaiSanPhamToolStripMenuItem.Name = "loaiSanPhamToolStripMenuItem";
            loaiSanPhamToolStripMenuItem.Size = new Size(184, 24);
            loaiSanPhamToolStripMenuItem.Text = "Loại sản phẩm";
            loaiSanPhamToolStripMenuItem.Click += loaiSanPhamToolStripMenuItem_Click;
            // 
            // sanPhamToolStripMenuItem
            // 
            sanPhamToolStripMenuItem.Name = "sanPhamToolStripMenuItem";
            sanPhamToolStripMenuItem.Size = new Size(184, 24);
            sanPhamToolStripMenuItem.Text = "Sản phẩm";
            sanPhamToolStripMenuItem.Click += sanPhamToolStripMenuItem_Click;
            // 
            // banHangToolStripMenuItem
            // 
            banHangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { theLuuDongToolStripMenuItem, phieuBanHangToolStripMenuItem });
            banHangToolStripMenuItem.Name = "banHangToolStripMenuItem";
            banHangToolStripMenuItem.Size = new Size(89, 24);
            banHangToolStripMenuItem.Text = "Bán hàng";
            // 
            // theLuuDongToolStripMenuItem
            // 
            theLuuDongToolStripMenuItem.Name = "theLuuDongToolStripMenuItem";
            theLuuDongToolStripMenuItem.Size = new Size(189, 24);
            theLuuDongToolStripMenuItem.Text = "Thẻ lưu động";
            theLuuDongToolStripMenuItem.Click += theLuuDongToolStripMenuItem_Click;
            // 
            // phieuBanHangToolStripMenuItem
            // 
            phieuBanHangToolStripMenuItem.Name = "phieuBanHangToolStripMenuItem";
            phieuBanHangToolStripMenuItem.Size = new Size(189, 24);
            phieuBanHangToolStripMenuItem.Text = "Phiếu bán hàng";
            phieuBanHangToolStripMenuItem.Click += phieuBanHangToolStripMenuItem_Click;
            // 
            // nhanVienToolStripMenuItem
            // 
            nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            nhanVienToolStripMenuItem.Size = new Size(95, 24);
            nhanVienToolStripMenuItem.Text = "Nhân viên";
            nhanVienToolStripMenuItem.Click += nhanVienToolStripMenuItem_Click;
            // 
            // doanhThuToolStripMenuItem
            // 
            doanhThuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loaiHangToolStripMenuItem, tkNhanVienToolStripMenuItem });
            doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            doanhThuToolStripMenuItem.Size = new Size(97, 24);
            doanhThuToolStripMenuItem.Text = "Doanh thu";
            // 
            // loaiHangToolStripMenuItem
            // 
            loaiHangToolStripMenuItem.Name = "loaiHangToolStripMenuItem";
            loaiHangToolStripMenuItem.Size = new Size(180, 24);
            loaiHangToolStripMenuItem.Text = "Loại hàng";
            loaiHangToolStripMenuItem.Click += loaiHangToolStripMenuItem_Click;
            // 
            // tkNhanVienToolStripMenuItem
            // 
            tkNhanVienToolStripMenuItem.Name = "tkNhanVienToolStripMenuItem";
            tkNhanVienToolStripMenuItem.Size = new Size(180, 24);
            tkNhanVienToolStripMenuItem.Text = "Nhân viên";
            tkNhanVienToolStripMenuItem.Click += tkNhanVienToolStripMenuItem_Click;
            // 
            // huongDanToolStripMenuItem
            // 
            huongDanToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hdSuDungToolStripMenuItem, gioiThieuPhanMemToolStripMenuItem });
            huongDanToolStripMenuItem.Name = "huongDanToolStripMenuItem";
            huongDanToolStripMenuItem.Size = new Size(102, 24);
            huongDanToolStripMenuItem.Text = "Hướng dẫn";
            // 
            // hdSuDungToolStripMenuItem
            // 
            hdSuDungToolStripMenuItem.Name = "hdSuDungToolStripMenuItem";
            hdSuDungToolStripMenuItem.Size = new Size(230, 24);
            hdSuDungToolStripMenuItem.Text = "Hướng dẫn sử dụng";
            // 
            // gioiThieuPhanMemToolStripMenuItem
            // 
            gioiThieuPhanMemToolStripMenuItem.Name = "gioiThieuPhanMemToolStripMenuItem";
            gioiThieuPhanMemToolStripMenuItem.Size = new Size(230, 24);
            gioiThieuPhanMemToolStripMenuItem.Text = "Giới thiệu phần mềm";
            // 
            // pnMain
            // 
            pnMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnMain.BackColor = Color.Transparent;
            pnMain.Controls.Add(statusStrip1);
            pnMain.ForeColor = SystemColors.ControlText;
            pnMain.Location = new Point(12, 31);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1574, 687);
            pnMain.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripTimer, toolStripUserName });
            statusStrip1.Location = new Point(0, 665);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1574, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripTimer
            // 
            toolStripTimer.Name = "toolStripTimer";
            toolStripTimer.Size = new Size(57, 17);
            toolStripTimer.Text = "Hệ thống";
            // 
            // toolStripUserName
            // 
            toolStripUserName.ImageAlign = ContentAlignment.MiddleRight;
            toolStripUserName.Name = "toolStripUserName";
            toolStripUserName.Size = new Size(1502, 17);
            toolStripUserName.Spring = true;
            toolStripUserName.Text = "UserName";
            toolStripUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1598, 730);
            Controls.Add(pnMain);
            Controls.Add(menuStrip1);
            Name = "frmMain";
            Text = "frmMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem heThongToolStripMenuItem;
        private ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private ToolStripMenuItem thongTinTaiKhoanToolStripMenuItem;
        private ToolStripMenuItem dangXuatToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem danhMucToolStripMenuItem;
        private ToolStripMenuItem loaiSanPhamToolStripMenuItem;
        private ToolStripMenuItem sanPhamToolStripMenuItem;
        private ToolStripMenuItem banHangToolStripMenuItem;
        private ToolStripMenuItem theLuuDongToolStripMenuItem;
        private ToolStripMenuItem phieuBanHangToolStripMenuItem;
        private ToolStripMenuItem nhanVienToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem loaiHangToolStripMenuItem;
        private ToolStripMenuItem tkNhanVienToolStripMenuItem;
        private ToolStripMenuItem huongDanToolStripMenuItem;
        private ToolStripMenuItem hdSuDungToolStripMenuItem;
        private ToolStripMenuItem gioiThieuPhanMemToolStripMenuItem;
        private Panel pnMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripTimer;
        private ToolStripStatusLabel toolStripUserName;
    }
}