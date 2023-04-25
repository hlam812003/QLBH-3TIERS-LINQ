using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHangPJ.BS_layer
{
    class BLSanPham
    {
        private QuanLyBanHangDataContext QLBH = new QuanLyBanHangDataContext();

        public System.Data.Linq.Table<SanPham> LaySanPham()
        {
            return QLBH.SanPhams;
        }

        public List<string> GetListCityCode()
        {
            return QLBH.SanPhams.Select(sp => sp.MaSP).ToList();
        }

        public bool ThemSanPham(string MaSanPham, string TenSanPham, string DonViTinh, int DonGia, string Hinh)
        {
            SanPham SP = new SanPham
            {
                MaSP = MaSanPham,
                TenSP = TenSanPham,
                DonViTinh = DonViTinh,
                DonGia = DonGia,
                Hinh = Hinh
            };

            QLBH.SanPhams.InsertOnSubmit(SP);
            QLBH.SubmitChanges();
            return true;
        }

        public bool XoaSanPham(string MaSanPham)
        {
            var tpQuery = QLBH.SanPhams.Where(tp => tp.MaSP == MaSanPham);
            QLBH.SanPhams.DeleteAllOnSubmit(tpQuery);
            QLBH.SubmitChanges();
            return true;
        }

        public bool CapNhatSanPham(string MaSanPham, string TenSanPham, string DonViTinh, int DonGia, string Hinh)
        {
            var tpQuery = QLBH.SanPhams.SingleOrDefault(tp => tp.MaSP == MaSanPham);

            if (tpQuery != null)
            {
                tpQuery.TenSP = TenSanPham;
                tpQuery.DonViTinh = DonViTinh;
                tpQuery.DonGia = DonGia;
                tpQuery.Hinh = Hinh;
                QLBH.SubmitChanges();
            }
            return true;
        }
    }
}
