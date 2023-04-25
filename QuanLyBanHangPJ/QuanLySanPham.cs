using QuanLyBanHangPJ.BS_layer;
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
    public partial class QuanLySanPham : Form
    {
        public QuanLySanPham()
        {
            InitializeComponent();
        }

        bool Them;
        //string err;
        BLSanPham dbSP = new BLSanPham();

        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                dataGVSanPham.DataSource = dbSP.LaySanPham();
                // Thay đổi độ rộng cột
                dataGVSanPham.AutoResizeColumns();
                dataGVSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Xóa trống các đối tượng trong ProductPanel
                this.txtMaSP.ResetText();
                this.txtTenSP.ResetText();
                this.txtDVT.ResetText();
                this.txtDG.ResetText();
                this.txtHinhSP.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.luuBtn.Enabled = false;
                this.huyBtn.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.themBtn.Enabled = true;
                this.suaBtn.Enabled = true;
                this.xoaBtn.Enabled = true;

                //
                dataGVSanPham_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table SANPHAM. Lỗi rồi!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGVSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem CurrentCell có phải là null không
            if (dataGVSanPham.CurrentCell != null)
            {
                // Thứ tự dòng hiện hành
                int r = dataGVSanPham.CurrentCell.RowIndex;
                // Chuyển thông tin lên ProductPanel
                this.txtMaSP.Text = dataGVSanPham.Rows[r].Cells[0].Value?.ToString() ?? string.Empty;
                this.txtTenSP.Text = dataGVSanPham.Rows[r].Cells[1].Value?.ToString() ?? string.Empty;
                this.txtDVT.Text = dataGVSanPham.Rows[r].Cells[2].Value?.ToString() ?? string.Empty;
                this.txtDG.Text = dataGVSanPham.Rows[r].Cells[3].Value?.ToString() ?? string.Empty;
                this.txtHinhSP.Text = dataGVSanPham.Rows[r].Cells[4].Value?.ToString() ?? string.Empty;
            }
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong ProductPanel
            this.txtMaSP.ResetText();
            this.txtTenSP.ResetText();
            this.txtDVT.ResetText();
            this.txtDG.ResetText();
            this.txtHinhSP.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / ProductPanel
            this.luuBtn.Enabled = true;
            this.huyBtn.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.themBtn.Enabled = false;
            this.suaBtn.Enabled = false;
            this.xoaBtn.Enabled = false;

            // Đưa con trỏ đến TextField txtMaSanPham
            this.txtTenSP.Focus();
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên ProductPanel
            this.panel1.Enabled = true;
            dataGVSanPham_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / ProductPanel
            this.luuBtn.Enabled = true;
            this.huyBtn.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.themBtn.Enabled = false;
            this.suaBtn.Enabled = false;
            this.xoaBtn.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaSP.Enabled = false;
            this.txtTenSP.Focus();
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.txtDG.Text, out int donGia))
            {
                if (Them)
                {
                    try
                    {
                        BLSanPham blSP = new BLSanPham();
                        blSP.ThemSanPham(this.txtMaSP.Text, this.txtTenSP.Text, this.txtDVT.Text, donGia, this.txtHinhSP.Text);
                        LoadData();
                        MessageBox.Show("Đã thêm xong!");
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!");
                    }
                }
                else
                {
                    try
                    {
                        BLSanPham blSP = new BLSanPham();
                        blSP.CapNhatSanPham(this.txtMaSP.Text, this.txtTenSP.Text, this.txtDVT.Text, donGia, this.txtHinhSP.Text);
                        LoadData();
                        MessageBox.Show("Đã sửa xong!");
                    }
                    catch
                    {
                        MessageBox.Show("Không sửa được. Lỗi rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị số nguyên hợp lệ cho đơn giá!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void huyBtn_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong ProductPanel
            this.txtMaSP.ResetText();
            this.txtTenSP.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.themBtn.Enabled = true;
            this.suaBtn.Enabled = true;
            this.xoaBtn.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / ProductPanel
            this.luuBtn.Enabled = false;
            this.huyBtn.Enabled = false;
            this.panel1.Enabled = false;
            dataGVSanPham_CellClick(null, null);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dataGVSanPham.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strSanPham = dataGVSanPham.Rows[r].Cells[0].Value.ToString();

                // Hiện thông báo xác nhận việc xóa mẫu tin
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    // Thực hiện lệnh xóa
                    BLSanPham blSP = new BLSanPham();
                    blSP.XoaSanPham(strSanPham);

                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void troVeBtn_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
        }

        private void thoatBtn_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc chắn thoát?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) Application.Exit();
        }
    }
}
