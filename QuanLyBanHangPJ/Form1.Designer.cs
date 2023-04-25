namespace QuanLyBanHangPJ
{
    partial class QuanLyDmTp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tenTpInput = new System.Windows.Forms.TextBox();
            this.tpInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.thoatBtn = new System.Windows.Forms.Button();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.dataGVTpho = new System.Windows.Forms.DataGridView();
            this.themBtn = new System.Windows.Forms.Button();
            this.suaBtn = new System.Windows.Forms.Button();
            this.luuBtn = new System.Windows.Forms.Button();
            this.huyBtn = new System.Windows.Forms.Button();
            this.xoaBtn = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.troVeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTpho)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tenTpInput);
            this.panel1.Controls.Add(this.tpInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(50, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 152);
            this.panel1.TabIndex = 0;
            // 
            // tenTpInput
            // 
            this.tenTpInput.Location = new System.Drawing.Point(218, 97);
            this.tenTpInput.MinimumSize = new System.Drawing.Size(360, 35);
            this.tenTpInput.Name = "tenTpInput";
            this.tenTpInput.Size = new System.Drawing.Size(388, 35);
            this.tenTpInput.TabIndex = 3;
            this.tenTpInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpInput
            // 
            this.tpInput.Location = new System.Drawing.Point(218, 19);
            this.tpInput.MinimumSize = new System.Drawing.Size(360, 35);
            this.tpInput.Name = "tpInput";
            this.tpInput.Size = new System.Drawing.Size(388, 35);
            this.tpInput.TabIndex = 2;
            this.tpInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.tpInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tpInput_KeyPress);
            //this.tpInput.Leave += new System.EventHandler(this.tpInput_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên T.Phố";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thành Phố";
            // 
            // thoatBtn
            // 
            this.thoatBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thoatBtn.Location = new System.Drawing.Point(735, 48);
            this.thoatBtn.Name = "thoatBtn";
            this.thoatBtn.Size = new System.Drawing.Size(370, 65);
            this.thoatBtn.TabIndex = 1;
            this.thoatBtn.Text = "Thoát";
            this.thoatBtn.UseVisualStyleBackColor = true;
            this.thoatBtn.Click += new System.EventHandler(this.thoatBtn_Click);
            // 
            // reloadBtn
            // 
            this.reloadBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reloadBtn.Location = new System.Drawing.Point(735, 135);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.Size = new System.Drawing.Size(370, 65);
            this.reloadBtn.TabIndex = 2;
            this.reloadBtn.Text = "Reload";
            this.reloadBtn.UseVisualStyleBackColor = true;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // dataGVTpho
            // 
            this.dataGVTpho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVTpho.Location = new System.Drawing.Point(50, 222);
            this.dataGVTpho.Name = "dataGVTpho";
            this.dataGVTpho.RowHeadersWidth = 51;
            this.dataGVTpho.RowTemplate.Height = 29;
            this.dataGVTpho.Size = new System.Drawing.Size(1055, 419);
            this.dataGVTpho.TabIndex = 3;
            this.dataGVTpho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVTpho_CellContentClick);
            // 
            // themBtn
            // 
            this.themBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.themBtn.Location = new System.Drawing.Point(50, 665);
            this.themBtn.Name = "themBtn";
            this.themBtn.Size = new System.Drawing.Size(150, 58);
            this.themBtn.TabIndex = 4;
            this.themBtn.Text = "Thêm";
            this.themBtn.UseVisualStyleBackColor = true;
            this.themBtn.Click += new System.EventHandler(this.themBtn_Click);
            // 
            // suaBtn
            // 
            this.suaBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.suaBtn.Location = new System.Drawing.Point(229, 665);
            this.suaBtn.Name = "suaBtn";
            this.suaBtn.Size = new System.Drawing.Size(150, 58);
            this.suaBtn.TabIndex = 5;
            this.suaBtn.Text = "Sửa";
            this.suaBtn.UseVisualStyleBackColor = true;
            this.suaBtn.Click += new System.EventHandler(this.suaBtn_Click);
            // 
            // luuBtn
            // 
            this.luuBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.luuBtn.Location = new System.Drawing.Point(410, 665);
            this.luuBtn.Name = "luuBtn";
            this.luuBtn.Size = new System.Drawing.Size(150, 58);
            this.luuBtn.TabIndex = 6;
            this.luuBtn.Text = "Lưu";
            this.luuBtn.UseVisualStyleBackColor = true;
            this.luuBtn.Click += new System.EventHandler(this.luuBtn_Click);
            // 
            // huyBtn
            // 
            this.huyBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.huyBtn.Location = new System.Drawing.Point(592, 665);
            this.huyBtn.Name = "huyBtn";
            this.huyBtn.Size = new System.Drawing.Size(150, 58);
            this.huyBtn.TabIndex = 7;
            this.huyBtn.Text = "Hủy";
            this.huyBtn.UseVisualStyleBackColor = true;
            this.huyBtn.Click += new System.EventHandler(this.huyBtn_Click);
            // 
            // xoaBtn
            // 
            this.xoaBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.xoaBtn.Location = new System.Drawing.Point(772, 665);
            this.xoaBtn.Name = "xoaBtn";
            this.xoaBtn.Size = new System.Drawing.Size(150, 58);
            this.xoaBtn.TabIndex = 8;
            this.xoaBtn.Text = "Xóa";
            this.xoaBtn.UseVisualStyleBackColor = true;
            this.xoaBtn.Click += new System.EventHandler(this.xoaBtn_Click);
            // 
            // troVeBtn
            // 
            this.troVeBtn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.troVeBtn.Location = new System.Drawing.Point(955, 665);
            this.troVeBtn.Name = "troVeBtn";
            this.troVeBtn.Size = new System.Drawing.Size(150, 58);
            this.troVeBtn.TabIndex = 9;
            this.troVeBtn.Text = "Trở Về";
            this.troVeBtn.UseVisualStyleBackColor = true;
            this.troVeBtn.Click += new System.EventHandler(this.troVeBtn_Click);
            // 
            // QuanLyDmTp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 765);
            this.Controls.Add(this.troVeBtn);
            this.Controls.Add(this.xoaBtn);
            this.Controls.Add(this.huyBtn);
            this.Controls.Add(this.luuBtn);
            this.Controls.Add(this.suaBtn);
            this.Controls.Add(this.themBtn);
            this.Controls.Add(this.dataGVTpho);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.thoatBtn);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyDmTp";
            this.Text = "Quản Lý Danh Mục Thành Phố";
            this.Load += new System.EventHandler(this.QuanLyDmTp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVTpho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button thoatBtn;
        private Button reloadBtn;
        private TextBox tenTpInput;
        private TextBox tpInput;
        private Label label2;
        private Label label1;
        private DataGridView dataGVTpho;
        private Button themBtn;
        private Button suaBtn;
        private Button luuBtn;
        private Button huyBtn;
        private Button xoaBtn;
        private HelpProvider helpProvider1;
        private Button troVeBtn;
    }
}