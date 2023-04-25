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
    public partial class QuanLyHoaDon : Form
    {
        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        bool Them;
        //string err;
        BLHoaDon dbHD = new BLHoaDon();
        BLKhachHang dbKH = new BLKhachHang();
        BLNhanVien dbNV = new BLNhanVien();

        void LoadData()
        {
            try
            {
                // Lay danh sach ma KH
                var maKHList = dbKH.LayKhachHang().Select(kh => kh.MaKH).ToList();
                txtMaKH.DataSource = maKHList;

                // Lay danh sach ma NV
                var maNVList = dbNV.LayNhanVien().Select(nv => nv.MaNV).ToList();
                txtMaNV.DataSource = maNVList;

                // Reset DataSource của DataGridView
                dataGVHoaDon.DataSource = null;

                // Đưa dữ liệu lên DataGridView
                var hoaDonBindingList = new BindingList<HoaDon>(dbHD.LayHoaDon().ToList());
                var hoaDonBindingSource = new BindingSource(hoaDonBindingList, null);
                dataGVHoaDon.DataSource = hoaDonBindingSource;

                // Ẩn các cột ref
                for (int i = 5; i < dataGVHoaDon.Columns.Count; ++i)
                    dataGVHoaDon.Columns[i].Visible = false;

                // Thay đổi độ rộng cột
                dataGVHoaDon.AutoResizeColumns();
                dataGVHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Xóa trống các đối tượng trong InvoicePanel
                this.txtMaHD.ResetText();
                this.txtMaKH.ResetText();
                this.txtMaNV.ResetText();
                this.dateNgayLD.ResetText();
                this.dateNgayNH.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy
                this.luuBtn.Enabled = false;
                this.huyBtn.Enabled = false;
                this.panel1.Enabled = false;

                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                this.themBtn.Enabled = true;
                this.suaBtn.Enabled = true;
                this.xoaBtn.Enabled = true;

                // Gọi sự kiện CellClick
                dataGVHoaDon_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table HOADON. Lỗi rồi!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGVHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVHoaDon.CurrentCell != null)
            {
                int r = dataGVHoaDon.CurrentCell.RowIndex;
                // Chuyển thông tin lên InvoicePanel
                this.txtMaHD.Text = dataGVHoaDon.Rows[r].Cells[0].Value?.ToString() ?? string.Empty;
                this.txtMaKH.Text = dataGVHoaDon.Rows[r].Cells[1].Value?.ToString() ?? string.Empty;
                this.txtMaNV.Text = dataGVHoaDon.Rows[r].Cells[2].Value?.ToString() ?? string.Empty;

                if (dataGVHoaDon.Rows[r].Cells[3].Value != null)
                    this.dateNgayLD.Value = Convert.ToDateTime(dataGVHoaDon.Rows[r].Cells[3].Value.ToString());

                if (dataGVHoaDon.Rows[r].Cells[4].Value != null)
                    this.dateNgayNH.Value = Convert.ToDateTime(dataGVHoaDon.Rows[r].Cells[4].Value.ToString());
            }
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void themBtn_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong InvoicePanel
            this.txtMaHD.ResetText();
            this.txtMaKH.ResetText();
            this.txtMaNV.ResetText();
            this.dateNgayLD.ResetText();
            this.dateNgayNH.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / InvoicePanel
            this.luuBtn.Enabled = true;
            this.huyBtn.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.themBtn.Enabled = false;
            this.suaBtn.Enabled = false;
            this.xoaBtn.Enabled = false;
            // Đưa con trỏ đến TextField txtHoaDon
            this.txtMaHD.Focus();
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên InvoicePanel
            this.panel1.Enabled = true;
            dataGVHoaDon_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / InvoicePanel
            this.luuBtn.Enabled = true;
            this.huyBtn.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.themBtn.Enabled = false;
            this.suaBtn.Enabled = false;
            this.xoaBtn.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaHD.Enabled = false;
            this.txtMaKH.Focus();
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            BLHoaDon blHD = new BLHoaDon();
            string errString;
            if (Them)
            {
                try
                {
                    blHD.ThemHoaDon(this.txtMaHD.Text, this.txtMaKH.Text, this.txtMaNV.Text, this.dateNgayLD.Value, this.dateNgayNH.Value, out errString);
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
                    blHD.CapNhatHoaDon(this.txtMaHD.Text, this.txtMaKH.Text, this.txtMaNV.Text, this.dateNgayLD.Value, this.dateNgayNH.Value, out errString);
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
            // Xóa trống các đối tượng trong InvoicePanel
            this.txtMaHD.ResetText();
            this.txtMaKH.ResetText();
            this.txtMaNV.ResetText();
            this.dateNgayLD.ResetText();
            this.dateNgayNH.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.themBtn.Enabled = true;
            this.suaBtn.Enabled = true;
            this.xoaBtn.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / InvoicePanel
            this.luuBtn.Enabled = false;
            this.huyBtn.Enabled = false;
            this.panel1.Enabled = false;
            dataGVHoaDon_CellClick(null, null);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            if (dataGVHoaDon.CurrentCell != null)
            {
                try
                {
                    int r = dataGVHoaDon.CurrentCell.RowIndex;
                    string strHoaDon = dataGVHoaDon.Rows[r].Cells[0].Value.ToString();

                    DialogResult traloi;
                    traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (traloi == DialogResult.Yes)
                    {
                        string errString;
                        BLHoaDon blHD = new BLHoaDon();
                        blHD.XoaHoaDon(strHoaDon, out errString);
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

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadData();
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
