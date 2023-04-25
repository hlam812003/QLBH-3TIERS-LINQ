namespace QuanLyBanHangPJ
{
    partial class QuanLyHoaDonChiTiet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            thoatBtn = new Button();
            reloadBtn = new Button();
            panel1 = new Panel();
            txtMaSP = new ComboBox();
            txtMaHopDong = new ComboBox();
            soLuongNumeric = new NumericUpDown();
            label2 = new Label();
            textBox12 = new Label();
            label5 = new Label();
            dataGVHoaDonChiTiet = new DataGridView();
            troVeBtn = new Button();
            xoaBtn = new Button();
            huyBtn = new Button();
            luuBtn = new Button();
            suaBtn = new Button();
            themBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)soLuongNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGVHoaDonChiTiet).BeginInit();
            SuspendLayout();
            // 
            // thoatBtn
            // 
            thoatBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            thoatBtn.Location = new Point(848, 29);
            thoatBtn.Name = "thoatBtn";
            thoatBtn.Size = new Size(222, 81);
            thoatBtn.TabIndex = 22;
            thoatBtn.Text = "THOÁT";
            thoatBtn.UseVisualStyleBackColor = true;
            thoatBtn.Click += thoatBtn_Click;
            // 
            // reloadBtn
            // 
            reloadBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reloadBtn.Location = new Point(848, 145);
            reloadBtn.Name = "reloadBtn";
            reloadBtn.Size = new Size(222, 84);
            reloadBtn.TabIndex = 21;
            reloadBtn.Text = "RELOAD";
            reloadBtn.UseVisualStyleBackColor = true;
            reloadBtn.Click += reloadBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMaSP);
            panel1.Controls.Add(txtMaHopDong);
            panel1.Controls.Add(soLuongNumeric);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox12);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(60, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(745, 200);
            panel1.TabIndex = 23;
            // 
            // txtMaSP
            // 
            txtMaSP.FormattingEnabled = true;
            txtMaSP.Location = new Point(308, 83);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(300, 28);
            txtMaSP.TabIndex = 26;
            // 
            // txtMaHopDong
            // 
            txtMaHopDong.FormattingEnabled = true;
            txtMaHopDong.Location = new Point(308, 25);
            txtMaHopDong.Name = "txtMaHopDong";
            txtMaHopDong.Size = new Size(300, 28);
            txtMaHopDong.TabIndex = 25;
            // 
            // soLuongNumeric
            // 
            soLuongNumeric.Location = new Point(308, 153);
            soLuongNumeric.Name = "soLuongNumeric";
            soLuongNumeric.Size = new Size(300, 27);
            soLuongNumeric.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(136, 155);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 15;
            label2.Text = "Số Lượng";
            // 
            // textBox12
            // 
            textBox12.AutoSize = true;
            textBox12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox12.Location = new Point(136, 28);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(106, 20);
            textBox12.TabIndex = 12;
            textBox12.Text = "Mã Hợp Đồng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(136, 91);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 4;
            label5.Text = "Mã Sản Phẩm";
            // 
            // dataGVHoaDonChiTiet
            // 
            dataGVHoaDonChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVHoaDonChiTiet.Location = new Point(60, 254);
            dataGVHoaDonChiTiet.Name = "dataGVHoaDonChiTiet";
            dataGVHoaDonChiTiet.RowHeadersWidth = 51;
            dataGVHoaDonChiTiet.RowTemplate.Height = 29;
            dataGVHoaDonChiTiet.Size = new Size(1010, 327);
            dataGVHoaDonChiTiet.TabIndex = 24;
            dataGVHoaDonChiTiet.CellClick += dataGVHoaDonChiTiet_CellClick;
            // 
            // troVeBtn
            // 
            troVeBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            troVeBtn.Location = new Point(918, 596);
            troVeBtn.Name = "troVeBtn";
            troVeBtn.Size = new Size(152, 58);
            troVeBtn.TabIndex = 30;
            troVeBtn.Text = "Trở Về";
            troVeBtn.UseVisualStyleBackColor = true;
            troVeBtn.Click += troVeBtn_Click;
            // 
            // xoaBtn
            // 
            xoaBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            xoaBtn.Location = new Point(742, 596);
            xoaBtn.Name = "xoaBtn";
            xoaBtn.Size = new Size(152, 58);
            xoaBtn.TabIndex = 29;
            xoaBtn.Text = "Xóa";
            xoaBtn.UseVisualStyleBackColor = true;
            xoaBtn.Click += xoaBtn_Click;
            // 
            // huyBtn
            // 
            huyBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            huyBtn.Location = new Point(569, 596);
            huyBtn.Name = "huyBtn";
            huyBtn.Size = new Size(152, 58);
            huyBtn.TabIndex = 28;
            huyBtn.Text = "Hủy";
            huyBtn.UseVisualStyleBackColor = true;
            huyBtn.Click += huyBtn_Click;
            // 
            // luuBtn
            // 
            luuBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            luuBtn.Location = new Point(399, 596);
            luuBtn.Name = "luuBtn";
            luuBtn.Size = new Size(152, 58);
            luuBtn.TabIndex = 27;
            luuBtn.Text = "Lưu";
            luuBtn.UseVisualStyleBackColor = true;
            luuBtn.Click += luuBtn_Click;
            // 
            // suaBtn
            // 
            suaBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            suaBtn.Location = new Point(226, 596);
            suaBtn.Name = "suaBtn";
            suaBtn.Size = new Size(152, 58);
            suaBtn.TabIndex = 26;
            suaBtn.Text = "Sửa";
            suaBtn.UseVisualStyleBackColor = true;
            suaBtn.Click += suaBtn_Click;
            // 
            // themBtn
            // 
            themBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            themBtn.Location = new Point(58, 596);
            themBtn.Name = "themBtn";
            themBtn.Size = new Size(152, 58);
            themBtn.TabIndex = 25;
            themBtn.Text = "Thêm";
            themBtn.UseVisualStyleBackColor = true;
            themBtn.Click += themBtn_Click;
            // 
            // QuanLyHoaDonChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 666);
            Controls.Add(troVeBtn);
            Controls.Add(xoaBtn);
            Controls.Add(huyBtn);
            Controls.Add(luuBtn);
            Controls.Add(suaBtn);
            Controls.Add(themBtn);
            Controls.Add(dataGVHoaDonChiTiet);
            Controls.Add(thoatBtn);
            Controls.Add(reloadBtn);
            Controls.Add(panel1);
            Name = "QuanLyHoaDonChiTiet";
            Text = "QuanLyHoaDonChiTiet";
            Load += QuanLyHoaDonChiTiet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)soLuongNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGVHoaDonChiTiet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button thoatBtn;
        private Button reloadBtn;
        private Panel panel1;
        private NumericUpDown soLuongNumeric;
        private Label label2;
        private Label textBox12;
        private Label label5;
        private DataGridView dataGVHoaDonChiTiet;
        private Button troVeBtn;
        private Button xoaBtn;
        private Button huyBtn;
        private Button luuBtn;
        private Button suaBtn;
        private Button themBtn;
        private ComboBox txtMaSP;
        private ComboBox txtMaHopDong;
    }
}