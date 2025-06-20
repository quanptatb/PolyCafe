using BLL_PolyCafe;
using DTO_PolyCafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_PolyCafe
{
    public partial class frmDoanhThuLoaiSP : Form
    {
        public frmDoanhThuLoaiSP()
        {
            InitializeComponent();
        }

        private void LoadLoaiSanPham()
        {
            try
            {
                BUSLoaiSanPham bUSLoaiSanPham = new BUSLoaiSanPham();
                List<LoaiSanPham> dsLoai = bUSLoaiSanPham.GetLoaiSanPhamList();

                dsLoai.Insert(0, new LoaiSanPham() { MaLoai = string.Empty, TenLoai = string.Format("--Tất Cả--") });
                cboLoaiSanPham.DataSource = dsLoai;
                cboLoaiSanPham.ValueMember = "MaLoai";
                cboLoaiSanPham.DisplayMember = "TenLoai";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại sản phẩm" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string loai = cboLoaiSanPham.SelectedValue.ToString();
            DateTime bd = dtPTuNgay.Value.Date;
            DateTime kt = dtPDenNgay.Value.Date;

            BUSThongKe busThongKe = new BUSThongKe();
            List<TKDoanhThuTheoLoaiSP> result = busThongKe.getThongKeLoaiSP(loai, bd, kt);
            dgvDanhSachThongKe.DataSource = result;
        }
        private void frmDoanhThuLoaiSP_Load(object sender, EventArgs e)
        {
            // Lấy ngày đầu tháng hiện tại
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // Gán giá trị cho DateTimePicker
            dtPTuNgay.Value = firstDayOfMonth;
            LoadLoaiSanPham();
            btnThongKe_Click(sender, e);
        }
    }
}
