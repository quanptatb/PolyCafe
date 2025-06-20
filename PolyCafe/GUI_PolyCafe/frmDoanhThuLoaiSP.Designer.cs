namespace GUI_PolyCafe
{
    partial class frmDoanhThuLoaiSP
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label9 = new Label();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            btnThongKe = new Guna.UI2.WinForms.Guna2Button();
            dtPDenNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label3 = new Label();
            dtPTuNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label2 = new Label();
            cboLoaiSanPham = new Guna.UI2.WinForms.Guna2ComboBox();
            label1 = new Label();
            dgvDanhSachThongKe = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThongKe).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft New Tai Lue", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.MenuHighlight;
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(753, 43);
            label9.TabIndex = 67;
            label9.Text = "THỐNG KÊ DOANH THU THEO LOẠI SẢN PHẨM";
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Controls.Add(btnThongKe);
            guna2GroupBox1.Controls.Add(dtPDenNgay);
            guna2GroupBox1.Controls.Add(label3);
            guna2GroupBox1.Controls.Add(dtPTuNgay);
            guna2GroupBox1.Controls.Add(label2);
            guna2GroupBox1.Controls.Add(cboLoaiSanPham);
            guna2GroupBox1.Controls.Add(label1);
            guna2GroupBox1.CustomizableEdges = customizableEdges9;
            guna2GroupBox1.Font = new Font("Segoe UI", 9F);
            guna2GroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox1.Location = new Point(12, 55);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2GroupBox1.Size = new Size(1779, 139);
            guna2GroupBox1.TabIndex = 68;
            guna2GroupBox1.Text = "Thông tin";
            // 
            // btnThongKe
            // 
            btnThongKe.CustomizableEdges = customizableEdges1;
            btnThongKe.DisabledState.BorderColor = Color.DarkGray;
            btnThongKe.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThongKe.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThongKe.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThongKe.FillColor = Color.RosyBrown;
            btnThongKe.Font = new Font("Segoe UI", 9F);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(1504, 54);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnThongKe.Size = new Size(180, 45);
            btnThongKe.TabIndex = 78;
            btnThongKe.Text = "Thống kê";
            btnThongKe.Click += btnThongKe_Click;
            // 
            // dtPDenNgay
            // 
            dtPDenNgay.Checked = true;
            dtPDenNgay.CustomizableEdges = customizableEdges3;
            dtPDenNgay.FillColor = Color.White;
            dtPDenNgay.Font = new Font("Segoe UI", 9F);
            dtPDenNgay.Format = DateTimePickerFormat.Long;
            dtPDenNgay.Location = new Point(1080, 63);
            dtPDenNgay.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtPDenNgay.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtPDenNgay.Name = "dtPDenNgay";
            dtPDenNgay.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtPDenNgay.Size = new Size(330, 36);
            dtPDenNgay.TabIndex = 77;
            dtPDenNgay.Value = new DateTime(2025, 6, 8, 14, 47, 55, 51);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(998, 78);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 76;
            label3.Text = "Đến ngày";
            // 
            // dtPTuNgay
            // 
            dtPTuNgay.Checked = true;
            dtPTuNgay.CustomizableEdges = customizableEdges5;
            dtPTuNgay.FillColor = Color.White;
            dtPTuNgay.Font = new Font("Segoe UI", 9F);
            dtPTuNgay.Format = DateTimePickerFormat.Long;
            dtPTuNgay.Location = new Point(561, 63);
            dtPTuNgay.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtPTuNgay.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtPTuNgay.Name = "dtPTuNgay";
            dtPTuNgay.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtPTuNgay.Size = new Size(330, 36);
            dtPTuNgay.TabIndex = 75;
            dtPTuNgay.Value = new DateTime(2025, 6, 8, 14, 47, 55, 51);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(490, 78);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 74;
            label2.Text = "Từ ngày";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.BackColor = Color.Transparent;
            cboLoaiSanPham.CustomizableEdges = customizableEdges7;
            cboLoaiSanPham.DrawMode = DrawMode.OwnerDrawFixed;
            cboLoaiSanPham.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSanPham.FocusedColor = Color.FromArgb(94, 148, 255);
            cboLoaiSanPham.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboLoaiSanPham.Font = new Font("Segoe UI", 10F);
            cboLoaiSanPham.ForeColor = Color.FromArgb(68, 88, 112);
            cboLoaiSanPham.ItemHeight = 30;
            cboLoaiSanPham.Location = new Point(87, 63);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cboLoaiSanPham.Size = new Size(308, 36);
            cboLoaiSanPham.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(20, 78);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 72;
            label1.Text = "Loại SP";
            // 
            // dgvDanhSachThongKe
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvDanhSachThongKe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDanhSachThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhSachThongKe.ColumnHeadersHeight = 4;
            dgvDanhSachThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhSachThongKe.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSachThongKe.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSachThongKe.Location = new Point(12, 200);
            dgvDanhSachThongKe.Name = "dgvDanhSachThongKe";
            dgvDanhSachThongKe.RowHeadersVisible = false;
            dgvDanhSachThongKe.Size = new Size(1779, 475);
            dgvDanhSachThongKe.TabIndex = 69;
            dgvDanhSachThongKe.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDanhSachThongKe.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDanhSachThongKe.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDanhSachThongKe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDanhSachThongKe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDanhSachThongKe.ThemeStyle.BackColor = Color.White;
            dgvDanhSachThongKe.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSachThongKe.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDanhSachThongKe.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDanhSachThongKe.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvDanhSachThongKe.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDanhSachThongKe.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDanhSachThongKe.ThemeStyle.HeaderStyle.Height = 4;
            dgvDanhSachThongKe.ThemeStyle.ReadOnly = false;
            dgvDanhSachThongKe.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDanhSachThongKe.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhSachThongKe.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvDanhSachThongKe.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDanhSachThongKe.ThemeStyle.RowsStyle.Height = 25;
            dgvDanhSachThongKe.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvDanhSachThongKe.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // frmDoanhThuLoaiSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1803, 687);
            Controls.Add(dgvDanhSachThongKe);
            Controls.Add(guna2GroupBox1);
            Controls.Add(label9);
            Name = "frmDoanhThuLoaiSP";
            Text = "frmDoanhThuLoaiSP";
            Load += frmDoanhThuLoaiSP_Load;
            guna2GroupBox1.ResumeLayout(false);
            guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachThongKe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnThongKe;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPDenNgay;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtPTuNgay;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cboLoaiSanPham;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSachThongKe;
    }
}