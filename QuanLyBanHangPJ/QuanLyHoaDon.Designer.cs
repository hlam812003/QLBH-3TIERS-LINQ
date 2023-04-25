namespace QuanLyBanHangPJ
{
    partial class QuanLyHoaDon
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
            panel1 = new Panel();
            txtMaKH = new ComboBox();
            txtMaNV = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            dateNgayNH = new DateTimePicker();
            label3 = new Label();
            dateNgayLD = new DateTimePicker();
            label2 = new Label();
            txtMaHD = new TextBox();
            label1 = new Label();
            thoatBtn = new Button();
            reloadBtn = new Button();
            dataGVHoaDon = new DataGridView();
            troVeBtn = new Button();
            xoaBtn = new Button();
            huyBtn = new Button();
            luuBtn = new Button();
            suaBtn = new Button();
            themBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVHoaDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMaKH);
            panel1.Controls.Add(txtMaNV);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateNgayNH);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dateNgayLD);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMaHD);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(27, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 200);
            panel1.TabIndex = 31;
            // 
            // txtMaKH
            // 
            txtMaKH.FormattingEnabled = true;
            txtMaKH.Location = new Point(708, 18);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(309, 28);
            txtMaKH.TabIndex = 33;
            // 
            // txtMaNV
            // 
            txtMaNV.FormattingEnabled = true;
            txtMaNV.Location = new Point(183, 86);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(309, 28);
            txtMaNV.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(43, 94);
            label5.Name = "label5";
            label5.Size = new Size(108, 20);
            label5.TabIndex = 28;
            label5.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(563, 26);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 26;
            label4.Text = "Mã Khách Hàng";
            // 
            // dateNgayNH
            // 
            dateNgayNH.Location = new Point(183, 160);
            dateNgayNH.Name = "dateNgayNH";
            dateNgayNH.Size = new Size(309, 27);
            dateNgayNH.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 165);
            label3.Name = "label3";
            label3.Size = new Size(129, 20);
            label3.TabIndex = 24;
            label3.Text = "Ngày Nhận Hàng";
            // 
            // dateNgayLD
            // 
            dateNgayLD.Location = new Point(708, 89);
            dateNgayLD.Name = "dateNgayLD";
            dateNgayLD.Size = new Size(309, 27);
            dateNgayLD.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(563, 93);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 20;
            label2.Text = "Ngày Lập Đơn";
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(183, 19);
            txtMaHD.MaximumSize = new Size(300, 50);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(300, 27);
            txtMaHD.TabIndex = 16;
            txtMaHD.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 26);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 14;
            label1.Text = "Mã Hóa Đơn";
            // 
            // thoatBtn
            // 
            thoatBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            thoatBtn.Location = new Point(1114, 34);
            thoatBtn.Name = "thoatBtn";
            thoatBtn.Size = new Size(222, 81);
            thoatBtn.TabIndex = 33;
            thoatBtn.Text = "THOÁT";
            thoatBtn.UseVisualStyleBackColor = true;
            thoatBtn.Click += thoatBtn_Click;
            // 
            // reloadBtn
            // 
            reloadBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reloadBtn.Location = new Point(1114, 150);
            reloadBtn.Name = "reloadBtn";
            reloadBtn.Size = new Size(222, 84);
            reloadBtn.TabIndex = 32;
            reloadBtn.Text = "RELOAD";
            reloadBtn.UseVisualStyleBackColor = true;
            reloadBtn.Click += reloadBtn_Click;
            // 
            // dataGVHoaDon
            // 
            dataGVHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVHoaDon.Location = new Point(27, 265);
            dataGVHoaDon.Name = "dataGVHoaDon";
            dataGVHoaDon.RowHeadersWidth = 51;
            dataGVHoaDon.RowTemplate.Height = 29;
            dataGVHoaDon.Size = new Size(1309, 448);
            dataGVHoaDon.TabIndex = 34;
            dataGVHoaDon.CellClick += dataGVHoaDon_CellClick;
            // 
            // troVeBtn
            // 
            troVeBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            troVeBtn.Location = new Point(1125, 748);
            troVeBtn.Name = "troVeBtn";
            troVeBtn.Size = new Size(211, 58);
            troVeBtn.TabIndex = 40;
            troVeBtn.Text = "Trở Về";
            troVeBtn.UseVisualStyleBackColor = true;
            troVeBtn.Click += troVeBtn_Click;
            // 
            // xoaBtn
            // 
            xoaBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            xoaBtn.Location = new Point(901, 748);
            xoaBtn.Name = "xoaBtn";
            xoaBtn.Size = new Size(199, 58);
            xoaBtn.TabIndex = 39;
            xoaBtn.Text = "Xóa";
            xoaBtn.UseVisualStyleBackColor = true;
            xoaBtn.Click += xoaBtn_Click;
            // 
            // huyBtn
            // 
            huyBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            huyBtn.Location = new Point(682, 748);
            huyBtn.Name = "huyBtn";
            huyBtn.Size = new Size(196, 58);
            huyBtn.TabIndex = 38;
            huyBtn.Text = "Hủy";
            huyBtn.UseVisualStyleBackColor = true;
            huyBtn.Click += huyBtn_Click;
            // 
            // luuBtn
            // 
            luuBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            luuBtn.Location = new Point(463, 748);
            luuBtn.Name = "luuBtn";
            luuBtn.Size = new Size(196, 58);
            luuBtn.TabIndex = 37;
            luuBtn.Text = "Lưu";
            luuBtn.UseVisualStyleBackColor = true;
            luuBtn.Click += luuBtn_Click;
            // 
            // suaBtn
            // 
            suaBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            suaBtn.Location = new Point(241, 748);
            suaBtn.Name = "suaBtn";
            suaBtn.Size = new Size(201, 58);
            suaBtn.TabIndex = 36;
            suaBtn.Text = "Sửa";
            suaBtn.UseVisualStyleBackColor = true;
            suaBtn.Click += suaBtn_Click;
            // 
            // themBtn
            // 
            themBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            themBtn.Location = new Point(27, 748);
            themBtn.Name = "themBtn";
            themBtn.Size = new Size(191, 58);
            themBtn.TabIndex = 35;
            themBtn.Text = "Thêm";
            themBtn.UseVisualStyleBackColor = true;
            themBtn.Click += themBtn_Click;
            // 
            // QuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 842);
            Controls.Add(troVeBtn);
            Controls.Add(xoaBtn);
            Controls.Add(huyBtn);
            Controls.Add(luuBtn);
            Controls.Add(suaBtn);
            Controls.Add(themBtn);
            Controls.Add(dataGVHoaDon);
            Controls.Add(thoatBtn);
            Controls.Add(reloadBtn);
            Controls.Add(panel1);
            Name = "QuanLyHoaDon";
            Text = "QuanLyHoaDon";
            Load += QuanLyHoaDon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateNgayLD;
        private Label label2;
        private TextBox txtMaHD;
        private Label label1;
        private Button thoatBtn;
        private Button reloadBtn;
        private Label label5;
        private Label label4;
        private DateTimePicker dateNgayNH;
        private Label label3;
        private DataGridView dataGVHoaDon;
        private Button troVeBtn;
        private Button xoaBtn;
        private Button huyBtn;
        private Button luuBtn;
        private Button suaBtn;
        private Button themBtn;
        private ComboBox txtMaKH;
        private ComboBox txtMaNV;
    }
}