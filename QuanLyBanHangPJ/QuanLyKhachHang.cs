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
    public partial class QuanLyKhachHang : Form
    {
        public QuanLyKhachHang()
        {
            InitializeComponent();
        }

        bool Them;
        //string err;
        BLKhachHang dbKH = new BLKhachHang();

        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                dataGVKhachHang.DataSource = null;
                dataGVKhachHang.DataSource = dbKH.LayKhachHang();

                //ẩn các column ref
                for (int i = 5; i < dataGVKhachHang.Columns.Count; ++i)
                    dataGVKhachHang.Columns[i].Visible = false;

                // Thay đổi độ rộng cột
                dataGVKhachHang.AutoResizeColumns();
                dataGVKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Xóa trống các đối tượng trong CustomerPanel
                this.txtMaKH.ResetText();
                this.txtTenKH.ResetText();
                this.txtDiaChi.ResetText();
                this.txtThanhPho.ResetText();
                this.txtSDT.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy
                this.luuBtn.Enabled = false;
                this.huyBtn.Enabled = false;
                //this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.themBtn.Enabled = true;
                this.suaBtn.Enabled = true;
                this.xoaBtn.Enabled = true;

                // Reset comboBox sortBox
                this.sortBox.SelectedItem = null;

                dataGVKhachHang_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table KHACHHANG! Lỗi rồi!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGVKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dataGVKhachHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên CustomerPanel
            this.txtMaKH.Text = dataGVKhachHang.Rows[r].Cells[0].Value?.ToString() ?? string.Empty;
            this.txtTenKH.Text = dataGVKhachHang.Rows[r].Cells[1].Value?.ToString() ?? string.Empty;
            this.txtDiaChi.Text = dataGVKhachHang.Rows[r].Cells[2].Value?.ToString() ?? string.Empty;
            this.txtThanhPho.Text = dataGVKhachHang.Rows[r].Cells[3].Value?.ToString() ?? string.Empty;
            this.txtSDT.Text = dataGVKhachHang.Rows[r].Cells[4].Value?.ToString() ?? string.Empty;
        }

        private void dataGVKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void themBtn_Click_1(object sender, EventArgs e)
        {
            Them = true;
            // Xóa trống các đối tượng trong CustomerPanel
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
            this.txtDiaChi.ResetText();
            this.txtThanhPho.ResetText();
            this.txtSDT.ResetText();

            // Cho thao tác trên các nút Lưu / Hủy / CustomerPanel
            this.luuBtn.Enabled = true;
            this.huyBtn.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.themBtn.Enabled = false;
            this.suaBtn.Enabled = false;
            this.xoaBtn.Enabled = false;
            // Đưa con trỏ đến TextField txtKhachHang
            this.txtMaKH.Focus();
        }

        private void suaBtn_Click_1(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên CustomerPanel
            this.panel1.Enabled = true;
            dataGVKhachHang_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / CustomerPanel
            this.luuBtn.Enabled = true;
            this.huyBtn.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.themBtn.Enabled = false;
            this.suaBtn.Enabled = false;
            this.xoaBtn.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaKH.Enabled = false;
            this.txtTenKH.Focus();
        }

        private void luuBtn_Click_1(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    BLKhachHang dbKH = new BLKhachHang();
                    dbKH.ThemKhachHang(this.txtMaKH.Text, this.txtTenKH.Text, this.txtDiaChi.Text, this.txtThanhPho.Text, this.txtSDT.Text);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
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
                    // Thực hiện lệnh
                    BLKhachHang dbKH = new BLKhachHang();

                    dbKH.CapNhatKhachHang(this.txtMaKH.Text, this.txtTenKH.Text, this.txtDiaChi.Text, this.txtThanhPho.Text, this.txtSDT.Text);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã sửa xong!");
                }
                catch
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void huyBtn_Click_1(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong CustomerPanel
            this.txtMaKH.ResetText();
            this.txtTenKH.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.themBtn.Enabled = true;
            this.suaBtn.Enabled = true;
            this.xoaBtn.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / CustomerPanel
            this.luuBtn.Enabled = false;
            this.huyBtn.Enabled = false;
            this.panel1.Enabled = false;
            dataGVKhachHang_CellClick(null, null);
        }

        private void xoaBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dataGVKhachHang.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strKhachHang =
                dataGVKhachHang.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    BLKhachHang dbKH = new BLKhachHang();
                    dbKH.XoaKhachHang(strKhachHang);
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

        private void troVeBtn_Click_1(object sender, EventArgs e)
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

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtThanhPho_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
        }

        private void sortBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortBox.SelectedItem != null)
            {
                switch (sortBox.SelectedItem.ToString())
                {
                    case "Top 10 Khách Hàng Mua Nhiều Nhất":
                        dataGVKhachHang.DataSource = null;
                        dataGVKhachHang.DataSource = dbKH.LayTop10KhachHang();

                        // ẩn các column ref
                        for (int i = 5; i < dataGVKhachHang.Columns.Count; ++i)
                            dataGVKhachHang.Columns[i].Visible = false;

                        // Thay đổi độ rộng cột
                        dataGVKhachHang.AutoResizeColumns();
                        dataGVKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;

                    case "Doanh Thu Bán Hàng Theo Tháng":
                        BLHoaDon dbHD = new BLHoaDon();
                        dataGVKhachHang.DataSource = null;
                        dataGVKhachHang.DataSource = dbHD.LayDoanhThuTheoThang();

                        // Ẩn các cột không cần thiết và điều chỉnh độ rộng cột
                        for (int i = 2; i < dataGVKhachHang.Columns.Count; ++i)
                            dataGVKhachHang.Columns[i].Visible = false;

                        dataGVKhachHang.AutoResizeColumns();
                        dataGVKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        break;

                    default:
                        // Thực hiện các hành động khác tương ứng với các tùy chọn trong ComboBox (nếu có)
                        // Nếu muốn quay lại dữ liệu ban đầu, gọi hàm LoadData()
                        LoadData();
                        break;
                }
            }
            else
            {
                // Nếu SelectedItem là null, gọi hàm LoadData()
                LoadData();
            }
        }


    }
}
