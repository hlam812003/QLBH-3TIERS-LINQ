using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QuanLyBanHangPJ.BS_layer;

namespace QuanLyBanHangPJ
{
    public partial class QuanLyDmTp : Form
    {
        bool Them;
        string err;
        BLThanhPho dbTP = new BLThanhPho();

        void LoadData()
        {
            try
            {
                dataGVTpho.DataSource = dbTP.LayThanhPho();
                dataGVTpho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                this.tpInput.ResetText();
                this.tenTpInput.ResetText();

                this.luuBtn.Enabled = false;
                this.huyBtn.Enabled = false;
                this.panel1.Enabled = false;

                this.themBtn.Enabled = true;
                this.suaBtn.Enabled = true;
                this.xoaBtn.Enabled = true;
                this.thoatBtn.Enabled = true;

                dataGVTpho_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO! Lỗi rồi!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public QuanLyDmTp()
        {
            InitializeComponent();
        }

        private void QuanLyDmTp_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }


        private void themBtn_Click(object sender, EventArgs e)
        {
            Them = true;
            this.tpInput.Enabled = true;
            this.tpInput.ResetText();
            this.tenTpInput.ResetText();

            this.luuBtn.Enabled = true;
            this.huyBtn.Enabled = true;
            this.panel1.Enabled = true;

            this.themBtn.Enabled = false;
            this.suaBtn.Enabled = false;
            this.xoaBtn.Enabled = false;
            this.thoatBtn.Enabled = false;
            this.tpInput.Focus();
        }

        private void luuBtn_Click(object sender, EventArgs e)
        {

                if (Them)
                {
                    try
                    {
                    // Thực hiện lệnh
                        BLThanhPho bLThanhPho = new BLThanhPho();
                        bLThanhPho.ThemThanhPho(this.tpInput.Text, this.tenTpInput.Text, ref err);
                        // Load lại dữ liệu trên DataGridView
                        LoadData();
                        // Thông báo
                        MessageBox.Show("Đã thêm xong!");
                    }
                    catch
                    {
                        MessageBox.Show("Không thêm được. Lỗi rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                    // Thực hiện lệnh
                        BLThanhPho bLThanhPho = new BLThanhPho();
                        bLThanhPho.CapNhatThanhPho(this.tpInput.Text, this.tenTpInput.Text, ref err);
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

        private void xoaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dataGVTpho.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strThanhPho = dataGVTpho.Rows[r].Cells[0].Value.ToString();
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbTP.XoaThanhPho(ref err, strThanhPho);
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

        private void huyBtn_Click(object sender, EventArgs e)
        {
            this.tpInput.ResetText();
            this.tenTpInput.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            this.themBtn.Enabled = true;
            this.suaBtn.Enabled = true;
            this.xoaBtn.Enabled = true;
            this.thoatBtn.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.luuBtn.Enabled = false;
            this.huyBtn.Enabled = false;
            this.panel1.Enabled = false;
            dataGVTpho_CellClick(null, null);
        }

        private void suaBtn_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            //dgvTHANHPHO_CellClick(null, null);
            // Cho phép thao tác trên Panel
            this.panel1.Enabled = true;
            dataGVTpho_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.luuBtn.Enabled = true;
            this.huyBtn.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.themBtn.Enabled = false;
            this.suaBtn.Enabled = false;
            this.xoaBtn.Enabled = false;
            this.thoatBtn.Enabled = false;
            // Đưa con trỏ đến TextField txtTenCty
            this.tpInput.Enabled = false;
            this.tenTpInput.Focus();
        }

        private void dataGVTpho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dataGVTpho.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.tpInput.Text = dataGVTpho.Rows[r].Cells[0].Value.ToString();
            this.tenTpInput.Text = dataGVTpho.Rows[r].Cells[1].Value.ToString();
        }

        private void dataGVTpho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void troVeBtn_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) this.Close();
        }
    }
}