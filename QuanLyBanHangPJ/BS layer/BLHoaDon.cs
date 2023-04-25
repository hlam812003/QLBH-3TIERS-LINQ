using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangPJ.BS_layer
{
    class BLHoaDon
    {
        private readonly QuanLyBanHangDataContext QLBH = new QuanLyBanHangDataContext();

        public IQueryable<HoaDon> LayHoaDon()
        {
            return QLBH.HoaDons;
        }

        public bool ThemHoaDon(string MaHoaDon, string MaKH, string MaNV,
            DateTime NgayLapHD, DateTime NgayNhanHang, out string errString)
        {
            errString = string.Empty;
            try
            {
                HoaDon HD = new HoaDon
                {
                    MaHD = MaHoaDon,
                    MaKH = MaKH,
                    MaNV = MaNV,
                    NgayLapHD = NgayLapHD,
                    NgayNhanHang = NgayNhanHang
                };

                QLBH.HoaDons.InsertOnSubmit(HD);
                QLBH.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                errString = ex.Message;
                return false;
            }
        }

        public bool XoaHoaDon(string MaHoaDon, out string err)
        {
            err = string.Empty;
            try
            {
                var tpQuery = QLBH.HoaDons.Where(tp => tp.MaHD == MaHoaDon);
                QLBH.HoaDons.DeleteAllOnSubmit(tpQuery);
                QLBH.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool CapNhatHoaDon(string MaHoaDon, string MaKH, string MaNV,
            DateTime NgayLapHD, DateTime NgayNhanHang, out string errString)
        {
            errString = string.Empty;
            try
            {
                var tpQuery = QLBH.HoaDons.SingleOrDefault(tp => tp.MaHD == MaHoaDon);
                if (tpQuery != null)
                {
                    tpQuery.MaKH = MaKH;
                    tpQuery.MaNV = MaNV;
                    tpQuery.NgayLapHD = NgayLapHD;
                    tpQuery.NgayNhanHang = NgayNhanHang;
                    QLBH.SubmitChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                errString = ex.Message;
                return false;
            }
        }

        public DataTable LayDoanhThuTheoThang()
        {
            // Tạo một DataTable để chứa kết quả
            DataTable dt = new DataTable();
            dt.Columns.Add("Tháng", typeof(int));
            dt.Columns.Add("Doanh Thu", typeof(decimal));

            // Thực hiện truy vấn để tính doanh thu theo tháng
            var doanhThuQuery = from hd in QLBH.HoaDons
                                join cthd in QLBH.ChiTietHoaDons on hd.MaHD equals cthd.MaHD
                                join sp in QLBH.SanPhams on cthd.MaSP equals sp.MaSP
                                group new { hd, cthd, sp } by hd.NgayLapHD.GetValueOrDefault().Month into g
                                select new
                                {
                                    Thang = g.Key,
                                    DoanhThu = g.Sum(x => x.cthd.Soluong * x.sp.DonGia)
                                };

            // Thêm kết quả vào DataTable
            foreach (var item in doanhThuQuery)
            {
                dt.Rows.Add(item.Thang, item.DoanhThu);
            }

            return dt;
        }
    }
}
