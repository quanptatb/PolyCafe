using DAL_PolyCafe;
using DTO_PolyCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_PolyCafe
{
    public class BUSPhieuBanHang
    {
        DALPhieuBanHang dalPhieuBanHang = new DALPhieuBanHang();
        //get
        public List<PhieuBanHang> getPhieuBanHang(string MaThe)
        {
            return dalPhieuBanHang.SelectAll(MaThe);
        }

        public string insertPhieuBanHang(PhieuBanHang phieu)
        {
            try
            {
                if (string.IsNullOrEmpty(phieu.MaPhieu))
                {
                    phieu.MaPhieu = dalPhieuBanHang.GenerateMaPhieu();
                }
                if (string.IsNullOrEmpty(phieu.MaPhieu))
                {
                    return "Mã phiếu bán hàng không hợp lệ.";
                }
                dalPhieuBanHang.Insert(phieu);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
        public string updatePhieuBanHang(PhieuBanHang phieu)
        {
            try
            {
                if (string.IsNullOrEmpty(phieu.MaPhieu))
                {
                    return "Mã phiếu bán hàng không hợp lệ.";
                }
                dalPhieuBanHang.Update(phieu);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }
        public string deletePhieuBanHang(string maPhieu)
        {
            try
            {
                if (string.IsNullOrEmpty(maPhieu))
                {
                    return "Mã phiếu bán hàng không hợp lệ.";
                }
                dalPhieuBanHang.Delete(maPhieu);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "Lỗi: " + ex.Message;
            }
        }

        //thanh toán

    }
}
