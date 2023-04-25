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
    public partial class QuanLyHoaDonChiTiet : Form
    {
        public QuanLyHoaDonChiTiet()
        {
            InitializeComponent();
        }

        bool Them;
        BLHoaDon dbHD = new BLHoaDon();
        BLSanPham dbSP = new BLSanPham();
        BLHoaDonChiTiet dbHDCT = new BLHoaDonChiTiet();

        void LoadData()
        {
            try
            {
                // Lấy dữ liệu mã Hợp Đồng
                var maHopDongList = dbHD.LayHoaDon().Select(hd => hd.MaHD).ToList();
                txtMaHopDong.Items.Clear();
                txtMaHopDong.Items.AddRange(maHopDongList.ToArray());

                // Lấy dữ liệu mã Sản Phẩm
                var maSPList = dbSP.LaySanPham().Select(sp => sp.MaSP).ToList();
                txtMaSP.Items.Clear();
                txtMaSP.Items.AddRange(maSPList.ToArray());

                // Đưa dữ liệu lên DataGridView
                dataGVHoaDonChiTiet.DataSource = null;
                dataGVHoaDonChiTiet.DataSource = dbHDCT.LayChiTietHoaDon();

                // Thay đổi độ rộng cột
                dataGVHoaDonChiTiet.AutoResizeColumns();
                dataGVHoaDonChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Xóa trống các đối tượng trong ProductPanel
                this.txtMaHopDong.ResetText();
                this.txtMaSP.ResetText();
                this.soLuongNumeric.ResetText();

                // Ẩn các cột ref
                for (int i = 3; i < dataGVHoaDonChiTiet.Columns.Count; ++i)
                    dataGVHoaDonChiTiet.Columns[i].Visible = false;

                // Không cho thao tác trên các nút Lưu / Hủy
                this.luuBtn.Enabled = false;
                this.huyBtn.Enabled = false;
                this.panel1.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                this.themBtn.Enabled = true;
                this.suaBtn.Enabled = true;
                this.xoaBtn.Enabled = true;

                // Gọi sự kiện CellClick
                dataGVHoaDonChiTiet_CellClick(null, null);

            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table HOADON. Lỗi rồi!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuanLyHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGVHoaDonChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVHoaDonChiTiet.CurrentCell != null)
            {
                // Thứ tự dòng hiện hành
                int r = dataGVHoaDonChiTiet.CurrentCell.RowIndex;
                // Chuyển thông tin lên ProductPanel
                this.txtMaHopDong.Text = dataGVHoaDonChiTiet.Rows[r].Cells[0].Value?.ToString() ?? string.Empty;
                this.txtMaSP.Text = dataGVHoaDonChiTiet.Rows[r].Cells[1].Value?.ToString() ?? string.Empty;
                this.soLuongNumeric.Text = dataGVHoaDonChiTiet.Rows[r].Cells[2].Value?.ToString() ?? string.Empty;
            }
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
            this.txtMaHopDong.ResetText();
            this.txtMaSP.ResetText();
            this.soLuongNumeric.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / ProductPanel
            this.luuBtn.Enabled = true;
            this.huyBtn.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.themBtn.Enabled = false;
            this.suaBtn.Enabled = false;
            this.xoaBtn.Enabled = false;

            // Đưa con trỏ đến TextField txtMaChiTietHoaDon
            this.txtMaHopDong.Focus();
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên ProductPanel
            this.panel1.Enabled = true;
            dataGVHoaDonChiTiet_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / ProductPanel
            this.luuBtn.Enabled = true;
            this.huyBtn.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.themBtn.Enabled = false;
            this.suaBtn.Enabled = false;
            this.xoaBtn.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaHopDong.Focus();
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            BLHoaDonChiTiet blHDCT = new BLHoaDonChiTiet();
            string errString = null;
            if (Them)
            {
                try
                {
                    blHDCT.ThemChiTietHoaDon(this.txtMaHopDong.Text, this.txtMaSP.Text, Convert.ToInt32(this.soLuongNumeric.Text), ref errString);
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
                    blHDCT.CapNhatChiTietHoaDon(this.txtMaHopDong.Text, this.txtMaSP.Text, Convert.ToInt32(this.soLuongNumeric.Text), ref errString);
                    LoadData();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void huyBtn_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong ProductPanel
            this.txtMaHopDong.ResetText();
            this.txtMaSP.ResetText();
            this.soLuongNumeric.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.themBtn.Enabled = true;
            this.suaBtn.Enabled = true;
            this.xoaBtn.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / ProductPanel
            this.luuBtn.Enabled = false;
            this.huyBtn.Enabled = false;
            this.panel1.Enabled = false;
            dataGVHoaDonChiTiet_CellClick(null, null);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            if (dataGVHoaDonChiTiet.CurrentCell != null)
            {
                try
                {
                    int r = dataGVHoaDonChiTiet.CurrentCell.RowIndex;
                    string strHoaDonChiTiet = dataGVHoaDonChiTiet.Rows[r].Cells[0].Value.ToString();

                    DialogResult traloi;
                    traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (traloi == DialogResult.Yes)
                    {
                        string errString = null;
                        BLHoaDonChiTiet blHDCT = new BLHoaDonChiTiet();
                        blHDCT.XoaChiTietHoaDon(ref errString, strHoaDonChiTiet);
                        LoadData();
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                    }
                }
                catch
                {
                    MessageBox.Show("Không xóa được. Lỗi rồi!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mẫu tin cần xóa!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
