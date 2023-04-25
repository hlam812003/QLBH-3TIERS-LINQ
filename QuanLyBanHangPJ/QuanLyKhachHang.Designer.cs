namespace QuanLyBanHangPJ
{
    partial class QuanLyKhachHang
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaKH = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            txtThanhPho = new TextBox();
            reloadBtn = new Button();
            thoatBtn = new Button();
            dataGVKhachHang = new DataGridView();
            troVeBtn = new Button();
            xoaBtn = new Button();
            huyBtn = new Button();
            luuBtn = new Button();
            suaBtn = new Button();
            themBtn = new Button();
            panel1 = new Panel();
            label2 = new Label();
            sortBox = new ComboBox();
            txtTenKH = new TextBox();
            textBox12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGVKhachHang).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 43);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã KH";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(98, 110);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Địa Chỉ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(57, 151);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Thành Phố";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(526, 89);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 4;
            label5.Text = "Số Điện Thoại";
            label5.Click += label5_Click;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(207, 36);
            txtMaKH.MaximumSize = new Size(300, 50);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(300, 27);
            txtMaKH.TabIndex = 5;
            txtMaKH.TextAlign = HorizontalAlignment.Center;
            txtMaKH.TextChanged += txtMaKH_TextChanged;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(698, 86);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(300, 27);
            txtSDT.TabIndex = 6;
            txtSDT.TextAlign = HorizontalAlignment.Center;
            txtSDT.TextChanged += txtSDT_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(207, 103);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(300, 27);
            txtDiaChi.TabIndex = 7;
            txtDiaChi.TextAlign = HorizontalAlignment.Center;
            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            // 
            // txtThanhPho
            // 
            txtThanhPho.Location = new Point(166, 148);
            txtThanhPho.Name = "txtThanhPho";
            txtThanhPho.Size = new Size(300, 27);
            txtThanhPho.TabIndex = 8;
            txtThanhPho.TextAlign = HorizontalAlignment.Center;
            txtThanhPho.TextChanged += txtThanhPho_TextChanged;
            // 
            // reloadBtn
            // 
            reloadBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reloadBtn.Location = new Point(1117, 141);
            reloadBtn.Name = "reloadBtn";
            reloadBtn.Size = new Size(222, 84);
            reloadBtn.TabIndex = 10;
            reloadBtn.Text = "RELOAD";
            reloadBtn.UseVisualStyleBackColor = true;
            reloadBtn.Click += reloadBtn_Click;
            // 
            // thoatBtn
            // 
            thoatBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            thoatBtn.Location = new Point(1117, 21);
            thoatBtn.Name = "thoatBtn";
            thoatBtn.Size = new Size(222, 81);
            thoatBtn.TabIndex = 11;
            thoatBtn.Text = "THOÁT";
            thoatBtn.UseVisualStyleBackColor = true;
            thoatBtn.Click += thoatBtn_Click;
            // 
            // dataGVKhachHang
            // 
            dataGVKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVKhachHang.Location = new Point(41, 242);
            dataGVKhachHang.Name = "dataGVKhachHang";
            dataGVKhachHang.RowHeadersWidth = 51;
            dataGVKhachHang.RowTemplate.Height = 29;
            dataGVKhachHang.Size = new Size(1298, 448);
            dataGVKhachHang.TabIndex = 12;
            dataGVKhachHang.CellClick += dataGVKhachHang_CellClick;
            dataGVKhachHang.CellContentClick += dataGVKhachHang_CellContentClick;
            // 
            // troVeBtn
            // 
            troVeBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            troVeBtn.Location = new Point(1128, 716);
            troVeBtn.Name = "troVeBtn";
            troVeBtn.Size = new Size(211, 58);
            troVeBtn.TabIndex = 19;
            troVeBtn.Text = "Trở Về";
            troVeBtn.UseVisualStyleBackColor = true;
            troVeBtn.Click += troVeBtn_Click_1;
            // 
            // xoaBtn
            // 
            xoaBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            xoaBtn.Location = new Point(910, 716);
            xoaBtn.Name = "xoaBtn";
            xoaBtn.Size = new Size(199, 58);
            xoaBtn.TabIndex = 18;
            xoaBtn.Text = "Xóa";
            xoaBtn.UseVisualStyleBackColor = true;
            xoaBtn.Click += xoaBtn_Click_1;
            // 
            // huyBtn
            // 
            huyBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            huyBtn.Location = new Point(693, 716);
            huyBtn.Name = "huyBtn";
            huyBtn.Size = new Size(196, 58);
            huyBtn.TabIndex = 17;
            huyBtn.Text = "Hủy";
            huyBtn.UseVisualStyleBackColor = true;
            huyBtn.Click += huyBtn_Click_1;
            // 
            // luuBtn
            // 
            luuBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            luuBtn.Location = new Point(476, 716);
            luuBtn.Name = "luuBtn";
            luuBtn.Size = new Size(196, 58);
            luuBtn.TabIndex = 16;
            luuBtn.Text = "Lưu";
            luuBtn.UseVisualStyleBackColor = true;
            luuBtn.Click += luuBtn_Click_1;
            // 
            // suaBtn
            // 
            suaBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            suaBtn.Location = new Point(254, 716);
            suaBtn.Name = "suaBtn";
            suaBtn.Size = new Size(201, 58);
            suaBtn.TabIndex = 15;
            suaBtn.Text = "Sửa";
            suaBtn.UseVisualStyleBackColor = true;
            suaBtn.Click += suaBtn_Click_1;
            // 
            // themBtn
            // 
            themBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            themBtn.Location = new Point(41, 716);
            themBtn.Name = "themBtn";
            themBtn.Size = new Size(191, 58);
            themBtn.TabIndex = 14;
            themBtn.Text = "Thêm";
            themBtn.UseVisualStyleBackColor = true;
            themBtn.Click += themBtn_Click_1;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(sortBox);
            panel1.Controls.Add(txtTenKH);
            panel1.Controls.Add(textBox12);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtThanhPho);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtSDT);
            panel1.Location = new Point(41, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 200);
            panel1.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(526, 151);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 15;
            label2.Text = "Tìm Kiếm";
            // 
            // sortBox
            // 
            sortBox.FormattingEnabled = true;
            sortBox.Items.AddRange(new object[] { "Top 10 Khách Hàng Mua Nhiều Nhất", "Doanh Thu Bán Hàng Theo Tháng" });
            sortBox.Location = new Point(697, 148);
            sortBox.Name = "sortBox";
            sortBox.Size = new Size(301, 28);
            sortBox.TabIndex = 14;
            sortBox.SelectedIndexChanged += sortBox_SelectedIndexChanged;
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(698, 19);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(300, 27);
            txtTenKH.TabIndex = 13;
            txtTenKH.TextAlign = HorizontalAlignment.Center;
            txtTenKH.TextChanged += txtTenKH_TextChanged;
            // 
            // textBox12
            // 
            textBox12.AutoSize = true;
            textBox12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox12.Location = new Point(526, 26);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(122, 20);
            textBox12.TabIndex = 12;
            textBox12.Text = "Tên Khách Hàng";
            textBox12.Click += textBox12_Click;
            // 
            // QuanLyKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 804);
            Controls.Add(troVeBtn);
            Controls.Add(xoaBtn);
            Controls.Add(thoatBtn);
            Controls.Add(huyBtn);
            Controls.Add(luuBtn);
            Controls.Add(suaBtn);
            Controls.Add(themBtn);
            Controls.Add(dataGVKhachHang);
            Controls.Add(reloadBtn);
            Controls.Add(txtDiaChi);
            Controls.Add(txtMaKH);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "QuanLyKhachHang";
            Text = "QuanLyKhachHang";
            Load += QuanLyKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVKhachHang).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaKH;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private TextBox txtThanhPho;
        private Button reloadBtn;
        private Button thoatBtn;
        private DataGridView dataGVKhachHang;
        private Button troVeBtn;
        private Button xoaBtn;
        private Button huyBtn;
        private Button luuBtn;
        private Button suaBtn;
        private Button themBtn;
        private Panel panel1;
        private TextBox txtTenKH;
        private Label textBox12;
        private Label label2;
        private ComboBox sortBox;
    }
}