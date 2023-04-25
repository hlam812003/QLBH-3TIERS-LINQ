using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangPJ
{
    public partial class MenuManager : Form
    {
        public MenuManager()
        {
            InitializeComponent();
        }

        private void qlBHBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyKhachHang formQLKH = new QuanLyKhachHang();
            formQLKH.ShowDialog();
            this.Show();
        }

        private void qlTPBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDmTp formQLTP = new QuanLyDmTp();
            formQLTP.ShowDialog();
            this.Show();
        }

        private void qlHDBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoaDon formQLHD = new QuanLyHoaDon();
            formQLHD.ShowDialog();
            this.Show();
        }

        private void qlNVBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyNhanVien formQLNV = new QuanLyNhanVien();
            formQLNV.ShowDialog();
            this.Show();
        }

        private void qlSPBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySanPham formQLSP = new QuanLySanPham();
            formQLSP.ShowDialog();
            this.Show();
        }

        private void qlHDCTBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHoaDonChiTiet formQLHDCT = new QuanLyHoaDonChiTiet();
            formQLHDCT.ShowDialog();
            this.Show();
        }
    }
}
