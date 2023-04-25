namespace QuanLyBanHangPJ
{
    partial class QuanLySanPham
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
            txtDVT = new TextBox();
            txtTenSP = new TextBox();
            txtMaSP = new TextBox();
            label3 = new Label();
            textBox12 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtHinhSP = new TextBox();
            label5 = new Label();
            txtDG = new TextBox();
            thoatBtn = new Button();
            reloadBtn = new Button();
            dataGVSanPham = new DataGridView();
            troVeBtn = new Button();
            xoaBtn = new Button();
            huyBtn = new Button();
            luuBtn = new Button();
            suaBtn = new Button();
            themBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVSanPham).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtDVT);
            panel1.Controls.Add(txtTenSP);
            panel1.Controls.Add(txtMaSP);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox12);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtHinhSP);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtDG);
            panel1.Location = new Point(37, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 200);
            panel1.TabIndex = 21;
            // 
            // txtDVT
            // 
            txtDVT.Location = new Point(166, 86);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(300, 27);
            txtDVT.TabIndex = 25;
            txtDVT.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(698, 19);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(300, 27);
            txtTenSP.TabIndex = 13;
            txtTenSP.TextAlign = HorizontalAlignment.Center;
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(166, 19);
            txtMaSP.MaximumSize = new Size(300, 50);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(300, 27);
            txtMaSP.TabIndex = 24;
            txtMaSP.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 93);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 23;
            label3.Text = "Đơn Vị Tính";
            // 
            // textBox12
            // 
            textBox12.AutoSize = true;
            textBox12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox12.Location = new Point(526, 26);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(107, 20);
            textBox12.TabIndex = 12;
            textBox12.Text = "Tên Sản Phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 26);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 22;
            label1.Text = "Mã Sản Phẩm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(57, 151);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 3;
            label4.Text = "Hình Sản Phẩm";
            // 
            // txtHinhSP
            // 
            txtHinhSP.Location = new Point(192, 148);
            txtHinhSP.Name = "txtHinhSP";
            txtHinhSP.Size = new Size(300, 27);
            txtHinhSP.TabIndex = 8;
            txtHinhSP.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(526, 89);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Đơn Giá";
            // 
            // txtDG
            // 
            txtDG.Location = new Point(698, 86);
            txtDG.Name = "txtDG";
            txtDG.Size = new Size(300, 27);
            txtDG.TabIndex = 6;
            txtDG.TextAlign = HorizontalAlignment.Center;
            // 
            // thoatBtn
            // 
            thoatBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            thoatBtn.Location = new Point(1132, 39);
            thoatBtn.Name = "thoatBtn";
            thoatBtn.Size = new Size(222, 81);
            thoatBtn.TabIndex = 23;
            thoatBtn.Text = "THOÁT";
            thoatBtn.UseVisualStyleBackColor = true;
            thoatBtn.Click += thoatBtn_Click;
            // 
            // reloadBtn
            // 
            reloadBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reloadBtn.Location = new Point(1132, 155);
            reloadBtn.Name = "reloadBtn";
            reloadBtn.Size = new Size(222, 84);
            reloadBtn.TabIndex = 22;
            reloadBtn.Text = "RELOAD";
            reloadBtn.UseVisualStyleBackColor = true;
            reloadBtn.Click += reloadBtn_Click;
            // 
            // dataGVSanPham
            // 
            dataGVSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVSanPham.Location = new Point(37, 267);
            dataGVSanPham.Name = "dataGVSanPham";
            dataGVSanPham.RowHeadersWidth = 51;
            dataGVSanPham.RowTemplate.Height = 29;
            dataGVSanPham.Size = new Size(1317, 448);
            dataGVSanPham.TabIndex = 24;
            dataGVSanPham.CellClick += dataGVSanPham_CellClick;
            // 
            // troVeBtn
            // 
            troVeBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            troVeBtn.Location = new Point(1143, 739);
            troVeBtn.Name = "troVeBtn";
            troVeBtn.Size = new Size(211, 58);
            troVeBtn.TabIndex = 30;
            troVeBtn.Text = "Trở Về";
            troVeBtn.UseVisualStyleBackColor = true;
            troVeBtn.Click += troVeBtn_Click;
            // 
            // xoaBtn
            // 
            xoaBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            xoaBtn.Location = new Point(918, 739);
            xoaBtn.Name = "xoaBtn";
            xoaBtn.Size = new Size(199, 58);
            xoaBtn.TabIndex = 29;
            xoaBtn.Text = "Xóa";
            xoaBtn.UseVisualStyleBackColor = true;
            xoaBtn.Click += xoaBtn_Click;
            // 
            // huyBtn
            // 
            huyBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            huyBtn.Location = new Point(697, 739);
            huyBtn.Name = "huyBtn";
            huyBtn.Size = new Size(196, 58);
            huyBtn.TabIndex = 28;
            huyBtn.Text = "Hủy";
            huyBtn.UseVisualStyleBackColor = true;
            huyBtn.Click += huyBtn_Click;
            // 
            // luuBtn
            // 
            luuBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            luuBtn.Location = new Point(474, 739);
            luuBtn.Name = "luuBtn";
            luuBtn.Size = new Size(196, 58);
            luuBtn.TabIndex = 27;
            luuBtn.Text = "Lưu";
            luuBtn.UseVisualStyleBackColor = true;
            luuBtn.Click += luuBtn_Click;
            // 
            // suaBtn
            // 
            suaBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            suaBtn.Location = new Point(250, 739);
            suaBtn.Name = "suaBtn";
            suaBtn.Size = new Size(201, 58);
            suaBtn.TabIndex = 26;
            suaBtn.Text = "Sửa";
            suaBtn.UseVisualStyleBackColor = true;
            suaBtn.Click += suaBtn_Click;
            // 
            // themBtn
            // 
            themBtn.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            themBtn.Location = new Point(37, 739);
            themBtn.Name = "themBtn";
            themBtn.Size = new Size(191, 58);
            themBtn.TabIndex = 25;
            themBtn.Text = "Thêm";
            themBtn.UseVisualStyleBackColor = true;
            themBtn.Click += themBtn_Click;
            // 
            // QuanLySanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 833);
            Controls.Add(troVeBtn);
            Controls.Add(xoaBtn);
            Controls.Add(huyBtn);
            Controls.Add(luuBtn);
            Controls.Add(suaBtn);
            Controls.Add(themBtn);
            Controls.Add(dataGVSanPham);
            Controls.Add(thoatBtn);
            Controls.Add(reloadBtn);
            Controls.Add(panel1);
            Name = "QuanLySanPham";
            Text = "QuanLySanPham";
            Load += QuanLySanPham_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtTenSP;
        private Label textBox12;
        private Label label4;
        private TextBox txtHinhSP;
        private Label label5;
        private TextBox txtDG;
        private TextBox txtDVT;
        private TextBox txtMaSP;
        private Label label3;
        private Label label1;
        private Button thoatBtn;
        private Button reloadBtn;
        private DataGridView dataGVSanPham;
        private Button troVeBtn;
        private Button xoaBtn;
        private Button huyBtn;
        private Button luuBtn;
        private Button suaBtn;
        private Button themBtn;
    }
}