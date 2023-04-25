using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangPJ.BS_layer
{
    public class BLNhanVien : IDisposable
    {
        private readonly QuanLyBanHangDataContext _qlBH = new QuanLyBanHangDataContext();

        public void Dispose()
        {
            _qlBH.Dispose();
        }

        public IQueryable<NhanVien> LayNhanVien()
        {
            return _qlBH.NhanViens;
        }

        public bool ThemNhanVien(string maNhanVien, string ho, string ten, bool nu, DateTime ngayNV,
            string diaChi, string dienThoai, string hinh, ref string errString)
        {
            try
            {
                var nv = new NhanVien
                {
                    MaNV = maNhanVien,
                    Ho = ho,
                    Ten = ten,
                    Nu = nu,
                    NgayNV = ngayNV,
                    DiaChi = diaChi,
                    DienThoai = dienThoai,
                    Hinh = hinh
                };

                _qlBH.NhanViens.InsertOnSubmit(nv);
                _qlBH.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                errString = ex.Message;
                return false;
            }
        }

        public bool XoaNhanVien(ref string err, string maNhanVien)
        {
            try
            {
                var tpQuery = _qlBH.NhanViens.Where(tp => tp.MaNV == maNhanVien);
                _qlBH.NhanViens.DeleteAllOnSubmit(tpQuery);
                _qlBH.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                err = ex.Message;
                return false;
            }
        }

        public bool CapNhatNhanVien(string maNhanVien, string ho, string ten, bool nu, DateTime ngayNV,
            string diaChi, string dienThoai, string hinh, ref string errString)
        {
            try
            {
                var tpQuery = _qlBH.NhanViens.SingleOrDefault(tp => tp.MaNV == maNhanVien);

                if (tpQuery == null) return false;

                tpQuery.Ho = ho;
                tpQuery.Ten = ten;
                tpQuery.Nu = nu;
                tpQuery.NgayNV = ngayNV;
                tpQuery.DiaChi = diaChi;
                tpQuery.DienThoai = dienThoai;
                tpQuery.Hinh = hinh;
                _qlBH.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                errString = ex.Message;
                return false;
            }
        }
    }
}
