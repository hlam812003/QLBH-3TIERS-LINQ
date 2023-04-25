using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangPJ.BS_layer
{
    class BLHoaDonChiTiet
    {
        public IQueryable<ChiTietHoaDon> LayChiTietHoaDon()
        {
            QuanLyBanHangDataContext QLBH = new QuanLyBanHangDataContext();
            return QLBH.ChiTietHoaDons;
        }

        public bool ThemChiTietHoaDon(string maHD, string maSP, int soLuong, ref string errString)
        {
            try
            {
                QuanLyBanHangDataContext QLBH = new QuanLyBanHangDataContext();
                ChiTietHoaDon CTHD = new ChiTietHoaDon
                {
                    MaHD = maHD,
                    MaSP = maSP,
                    Soluong = soLuong
                };

                QLBH.ChiTietHoaDons.InsertOnSubmit(CTHD);
                QLBH.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                errString = ex.Message;
                return false;
            }
        }

        public bool XoaChiTietHoaDon(ref string err, string MaChiTietHoaDon)
        {
            try
            {
                QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
                var tpQuery = from cthd in qlBH.ChiTietHoaDons
                              where cthd.MaHD == MaChiTietHoaDon
                              select cthd;
                qlBH.ChiTietHoaDons.DeleteAllOnSubmit(tpQuery);
                qlBH.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool CapNhatChiTietHoaDon(string maHD, string maSP, int soLuong, ref string err)
        {
            try
            {
                QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
                var cthdQuery = (from cthd in qlBH.ChiTietHoaDons
                                 where cthd.MaHD == maHD
                                 select cthd).SingleOrDefault();

                if (cthdQuery != null)
                {
                    cthdQuery.MaSP = maSP;
                    cthdQuery.Soluong = soLuong;
                    qlBH.SubmitChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }
    }
}
