using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangPJ.BS_layer
{
    class BLKhachHang
    {
        private QuanLyBanHangDataContext QLBH = new QuanLyBanHangDataContext();

        public System.Data.Linq.Table<KhachHang> LayKhachHang()
        {
            return QLBH.KhachHangs;
        }

        public bool ThemKhachHang(string MaKhachHang, string TenCongTy, string DiaChi, string MaThanhPho, string DienThoai)
        {
            KhachHang KH = new KhachHang
            {
                MaKH = MaKhachHang,
                TenCty = TenCongTy,
                DiaChi = DiaChi,
                ThanhPho = MaThanhPho,
                DienThoai = DienThoai
            };

            QLBH.KhachHangs.InsertOnSubmit(KH);
            QLBH.SubmitChanges();
            return true;
        }

        public bool XoaKhachHang(string MaKhachHang)
        {
            var tpQuery = QLBH.KhachHangs.Where(kh => kh.MaKH == MaKhachHang);
            QLBH.KhachHangs.DeleteAllOnSubmit(tpQuery);
            QLBH.SubmitChanges();
            return true;
        }

        public bool CapNhatKhachHang(string MaKhachHang, string TenCongTy, string DiaChi, string MaThanhPho, string DienThoai)
        {
            var tpQuery = QLBH.KhachHangs.SingleOrDefault(tp => tp.MaKH == MaKhachHang);

            if (tpQuery != null)
            {
                tpQuery.TenCty = TenCongTy;
                tpQuery.DiaChi = DiaChi;
                tpQuery.ThanhPho = MaThanhPho;
                tpQuery.DienThoai = DienThoai;
                QLBH.SubmitChanges();
            }
            return true;
        }

        public List<KhachHang> LayTop10KhachHang()
        {
            var query = (from hd in QLBH.HoaDons
                         join cthd in QLBH.ChiTietHoaDons on hd.MaHD equals cthd.MaHD
                         join kh in QLBH.KhachHangs on hd.MaKH equals kh.MaKH
                         group cthd by kh into khGroup
                         orderby khGroup.Sum(x => x.Soluong) descending
                         select khGroup.Key).Take(10);

            return query.ToList();
        }

    }
}
