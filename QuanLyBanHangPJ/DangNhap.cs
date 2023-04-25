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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void dangNhap_btn_Click(object sender, EventArgs e)
        {
            if (this.DangNhapInput.Text == "admin" && this.MatKhauInput.Text == "123")
            {
                MessageBox.Show("Đăng Nhập Thành Công!", "Thông Báo");
                this.Hide();
                MenuManager formMenuManager = new MenuManager();
                formMenuManager.Show();
            }
            else
            {
                MessageBox.Show("Sai Tên Đăng Nhập Hoặc Sai Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DangNhapInput.Focus();
            }
        }


        private void MatKhauInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dangNhap_btn.Focus();
            }
        }

        private void xoa_btn_Click(object sender, EventArgs e)
        {
            this.DangNhapInput.ResetText();
            this.MatKhauInput.Text = "";
            this.DangNhapInput.Focus();
        }

        private void huy_btn_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dl == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
