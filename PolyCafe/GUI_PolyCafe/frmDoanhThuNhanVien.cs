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
    public partial class frmDoanhThuNhanVien : Form
    {
        public frmDoanhThuNhanVien()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string maNV = cboNhanVien.SelectedValue.ToString();
            DateTime bd = dtPTuNgay.Value.Date;
            DateTime kt = dtPDenNgay.Value.Date;

            BUSThongKe busThongKe = new BUSThongKe();
            List<TKDoanhThuTheoNhanVien> result = busThongKe.getThongKeNhanVien(maNV, bd, kt);
            dgvDanhSachThongKe.DataSource = result;
        }

        private void LoadNhanVien()
        {
            try
            {
                BUSNhanVien busNhanVien = new BUSNhanVien();
                List<NhanVien> dsNhanVien = busNhanVien.GetNhanVienList();
                dsNhanVien.Insert(0, new NhanVien() { MaNhanVien = string.Empty, HoTen = string.Format("--Tất Cả--") });
                cboNhanVien.DataSource = dsNhanVien;
                cboNhanVien.ValueMember = "MaNhanVien";
                cboNhanVien.DisplayMember = "HoTen";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDoanhThuNhanVien_Load(object sender, EventArgs e)
        {
            // Lấy ngày đầu tháng hiện tại
            DateTime firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // Gán giá trị cho DateTimePicker
            dtPTuNgay.Value = firstDayOfMonth;
            LoadNhanVien();

            btnThongKe_Click(sender, e);
        }
    }
}
