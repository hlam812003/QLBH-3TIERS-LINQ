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
    public partial class QuanLyNhanVien : Form
    {
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        bool Them;
        string err;
        BLNhanVien dbNV = new BLNhanVien();

        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                dataGVNhanVien.DataSource = dbNV.LayNhanVien();
                // Thay đổi độ rộng cột
                dataGVNhanVien.AutoResizeColumns();
                dataGVNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                // Xóa trống các đối tượng trong NhanVienPanel
                this.txtMaNV.ResetText();
                this.txtHO.ResetText();
                this.txtTen.ResetText();
                this.txtSDT.ResetText();
                this.txtDiaChi.ResetText();
                this.txtHinhAnhLink.ResetText();
                this.radioNam.Checked = false;
                this.radioNu.Checked = false;
                this.radioKhac.Checked = false;
                // Không cho thao tác trên các nút Lưu / Hủy
                this.luuBtn.Enabled = false;
                this.huyBtn.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.themBtn.Enabled = true;
                this.suaBtn.Enabled = true;
                this.xoaBtn.Enabled = true;

                //
                dataGVNhanVien_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table NHANVIEN. Lỗi rồi!!!");
            }
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGVNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVNhanVien.CurrentCell != null)
            {
                int r = dataGVNhanVien.CurrentCell.RowIndex;
                // Chuyển thông tin lên NhanVienPanel
                this.txtMaNV.Text = dataGVNhanVien.Rows[r].Cells[0].Value?.ToString() ?? "";
                this.txtHO.Text = dataGVNhanVien.Rows[r].Cells[1].Value?.ToString() ?? "";
                this.txtTen.Text = dataGVNhanVien.Rows[r].Cells[2].Value?.ToString() ?? "";

                string gender = dataGVNhanVien.Rows[r].Cells[3].Value?.ToString() ?? "";
                if (gender == "Nam")
                {
                    radioNam.Checked = true;
                }
                else if (gender == "Nu")
                {
                    radioNu.Checked = true;
                }
                else
                {
                    radioKhac.Checked = true;
                }

                if (dataGVNhanVien.Rows[r].Cells[4].Value != null)
                {
                    this.datePickerNV.Value = Convert.ToDateTime(dataGVNhanVien.Rows[r].Cells[4].Value.ToString());
                }
                else
                {
                    // Xử lý trường hợp giá trị null, ví dụ: thiết lập một giá trị mặc định
                    this.datePickerNV.Value = DateTime.Now;
                }

                this.txtDiaChi.Text = dataGVNhanVien.Rows[r].Cells[5].Value?.ToString() ?? "";
                this.txtSDT.Text = dataGVNhanVien.Rows[r].Cells[6].Value?.ToString() ?? "";
                this.txtHinhAnhLink.Text = dataGVNhanVien.Rows[r].Cells[7].Value?.ToString() ?? "";
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
            // Xóa trống các đối tượng trong NhanVienPanel
            this.txtMaNV.ResetText();
            this.txtHO.ResetText();
            this.txtTen.ResetText();
            this.txtDiaChi.ResetText();
            this.txtSDT.ResetText();
            this.txtHinhAnhLink.ResetText();
            this.radioNam.Checked = false;
            this.radioNu.Checked = false;
            this.radioKhac.Checked = true; // Set radioKhac as the default
            // Cho thao tác trên các nút Lưu / Hủy / NhanVienPanel
            this.luuBtn.Enabled = true;
            this.huyBtn.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.themBtn.Enabled = false;
            this.suaBtn.Enabled = false;
            this.xoaBtn.Enabled = false;
            this.txtMaNV.Enabled = false;

            // Đưa con trỏ đến TextField txtMANV
            this.txtMaNV.Focus();

            // Thiết lập index cho dối tượng mới
            if (dataGVNhanVien.RowCount > 1) // Kiểm tra xem có dữ liệu trong DataGridView không
            {
                int lastRow = dataGVNhanVien.RowCount - 2;
                this.txtMaNV.Text = (Convert.ToInt16(dataGVNhanVien.Rows[lastRow].Cells[0].Value.ToString()) + 1).ToString();
            }
            else
            {
                this.txtMaNV.Text = "1";
            }
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên panel
            this.panel1.Enabled = true;
            dataGVNhanVien_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / NhanVienPanel
            this.luuBtn.Enabled = true;
            this.huyBtn.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.radioKhac.Checked = false; // Reset radioKhac when editing
            this.themBtn.Enabled = false;
            this.suaBtn.Enabled = false;
            this.xoaBtn.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaNV.Enabled = false;
            this.txtHO.Focus();
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            // Thêm dữ liệu
            BLNhanVien blNV = new BLNhanVien();
            string gender;
            if (radioNam.Checked)
            {
                gender = "Nam";
            }
            else if (radioNu.Checked)
            {
                gender = "Nu";
            }
            else
            {
                gender = "Khac";
            }

            bool isFemale = gender == "Nu";
            DateTime ngayNV = new DateTime(this.datePickerNV.Value.Year, this.datePickerNV.Value.Month, this.datePickerNV.Value.Day);

            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    blNV.ThemNhanVien(this.txtMaNV.Text, this.txtHO.Text, this.txtTen.Text, isFemale, ngayNV,
                        this.txtDiaChi.Text, this.txtSDT.Text, this.txtHinhAnhLink.Text, ref err);
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
                    blNV.CapNhatNhanVien(this.txtMaNV.Text, this.txtHO.Text, this.txtTen.Text, isFemale, ngayNV,
                        this.txtDiaChi.Text, this.txtSDT.Text, this.txtHinhAnhLink.Text, ref err);
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

        private void huyBtn_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong NhanVienPanel
            this.txtMaNV.ResetText();
            this.txtHO.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.themBtn.Enabled = true;
            this.suaBtn.Enabled = true;
            this.xoaBtn.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / NhanVienPanel
            this.luuBtn.Enabled = false;
            this.huyBtn.Enabled = false;
            this.panel1.Enabled = false;
            dataGVNhanVien_CellClick(null, null);
        }

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dataGVNhanVien.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strNHANVIEN =
                dataGVNhanVien.Rows[r].Cells[0].Value.ToString();
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
                    dbNV.XoaNhanVien(ref err, strNHANVIEN);
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
