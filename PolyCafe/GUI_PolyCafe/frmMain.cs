using PolyCafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTIL_PolyCafe;

namespace GUI_PolyCafe
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void openChildForm(Form formChild)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            pnMain.Controls.Add(formChild);
            pnMain.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();


        }
        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //openChildForm(new ResetPassword());
            frmResetPW reset = new frmResetPW();
            reset.ShowDialog();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            danhMucToolStripMenuItem.Visible = false;
            banHangToolStripMenuItem.Visible = false;
            nhanVienToolStripMenuItem.Visible = false;
            doanhThuToolStripMenuItem.Visible = false;

            this.Hide();
            AuthUtil.user = null;
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void theLuuDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyTheLuuDong());
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmQuanLyNhanVien());
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSanPham());
        }

        private void loaiSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLoaiSanPham());
        }

        private void loaiHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoanhThuLoaiSP());
        }

        private void tkNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoanhThuNhanVien());
        }

        private void phieuBanHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmPhieuBH());
        }
    }
}
