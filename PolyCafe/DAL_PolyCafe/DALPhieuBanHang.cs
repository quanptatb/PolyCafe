using DTO_PolyCafe;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_PolyCafe
{
    public class DALPhieuBanHang
    {
        //selectBySql
        public List<PhieuBanHang> SelectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<PhieuBanHang> list = new List<PhieuBanHang>();
            try
            {
                SqlDataReader reader = DBUtil.Query(sql, args);
                while (reader.Read())
                {
                    PhieuBanHang entity = new PhieuBanHang();
                    entity.MaPhieu = reader.GetString("MaPhieu");
                    entity.MaThe = reader.GetString("MaThe");
                    entity.MaNhanVien = reader.GetString("MaNhanVien");
                    entity.NgayTao = reader.GetDateTime("NgayTao");
                    entity.TrangThai = reader.GetBoolean("TrangThai");
                    list.Add(entity);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
        //selectAll
        public List<PhieuBanHang> SelectAll(string maThe)
        {
            //String sql = "SELECT * FROM PhieuBanHang";
            List<object> param = new List<object>();
            string sql = "SELECT phieu.MaPhieu, phieu.MaThe, the.ChuSoHuu, phieu.MaNhanVien, nv.HoTen, phieu.NgayTao, phieu.TrangThai " +
                "FROM PhieuBanHang phieu INNER JOIN NhanVien nv ON phieu.MaNhanVien = nv.MaNhanVien " +
                "INNER JOIN TheLuuDong the ON the.MaThe = phieu.MaThe";
            if (!string.IsNullOrEmpty(maThe))
            {
                sql = "SELECT phieu.MaPhieu, phieu.MaThe, the.ChuSoHuu, phieu.MaNhanVien, nv.HoTen, phieu.NgayTao, phieu.TrangThai " +
               "FROM PhieuBanHang phieu INNER JOIN NhanVien nv ON phieu.MaNhanVien = nv.MaNhanVien " +
               "INNER JOIN TheLuuDong the ON the.MaThe = phieu.MaThe " +
               "WHERE the.MaThe = @0";
                param.Add(maThe);
            }

            return SelectBySql(sql, param);
        }
        //selectById
        public PhieuBanHang SelectById(string id)
        {
            string sql = "SELECT * FROM PhieuBanHang WHERE MaPhieu = @0";
            List<object> p = new List<object> { id };
            List<PhieuBanHang> list = SelectBySql(sql, p);
            return list.FirstOrDefault();
        }
        //insert
        public void Insert(PhieuBanHang entity)
        {
            string sql = "INSERT INTO PhieuBanHang (MaPhieu, MaThe, MaNhanVien, NgayTao, TrangThai) " +
                         "VALUES (@0, @1, @2, @3, @4)";
            List<object> p = new List<object>
            {
                entity.MaPhieu,
                entity.MaThe,
                entity.MaNhanVien,
                entity.NgayTao,
                entity.TrangThai
            };
            DBUtil.Update(sql, p);
        }
        //update
        public void Update(PhieuBanHang entity)
        {
            string sql = "UPDATE PhieuBanHang SET MaThe = @1, MaNhanVien = @2, NgayTao = @3, TrangThai = @4 " +
                         "WHERE MaPhieu = @0";
            List<object> p = new List<object>
            {
                entity.MaPhieu,
                entity.MaThe,
                entity.MaNhanVien,
                entity.NgayTao,
                entity.TrangThai
            };
            DBUtil.Update(sql, p);
        }
        //delete
        public void Delete(string id)
        {
            string sql = "DELETE FROM PhieuBanHang WHERE MaPhieu = @0";
            List<object> p = new List<object> { id };
            DBUtil.Update(sql, p);
        }
        //generateMaPhieu
        public string GenerateMaPhieu()
        {
            string prefix = "PBH";
            string sql = "select top 1 MaPhieu from PhieuBanHang order by MaPhieu desc";
            List<object> args = new List<object>();
            object result = DBUtil.ScalarQuery(sql, args);
            if (result == null || result == DBNull.Value)
            {
                return prefix + "0001";
            }
            else
            {
                string lastId = result.ToString();
                int number = int.Parse(lastId.Substring(prefix.Length));
                number++;
                return prefix + number.ToString("D4");
            }
        }
    }
}
