namespace QuanLyBanHangPJ
{
    partial class MenuManager
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
            qlBHBtn = new Button();
            qlTPBtn = new Button();
            qlNVBtn = new Button();
            qlHDCTBtn = new Button();
            qlSPBtn = new Button();
            label1 = new Label();
            qlHDBtn = new Button();
            SuspendLayout();
            // 
            // qlBHBtn
            // 
            qlBHBtn.Location = new Point(75, 127);
            qlBHBtn.Name = "qlBHBtn";
            qlBHBtn.Size = new Size(161, 63);
            qlBHBtn.TabIndex = 0;
            qlBHBtn.Text = "QLy Khách Hàng";
            qlBHBtn.UseVisualStyleBackColor = true;
            qlBHBtn.Click += qlBHBtn_Click;
            // 
            // qlTPBtn
            // 
            qlTPBtn.Location = new Point(328, 127);
            qlTPBtn.Name = "qlTPBtn";
            qlTPBtn.Size = new Size(161, 63);
            qlTPBtn.TabIndex = 1;
            qlTPBtn.Text = "QLy Thành Phố";
            qlTPBtn.UseVisualStyleBackColor = true;
            qlTPBtn.Click += qlTPBtn_Click;
            // 
            // qlNVBtn
            // 
            qlNVBtn.Location = new Point(75, 243);
            qlNVBtn.Name = "qlNVBtn";
            qlNVBtn.Size = new Size(161, 63);
            qlNVBtn.TabIndex = 2;
            qlNVBtn.Text = "QLy Nhân Viên";
            qlNVBtn.UseVisualStyleBackColor = true;
            qlNVBtn.Click += qlNVBtn_Click;
            // 
            // qlHDCTBtn
            // 
            qlHDCTBtn.Location = new Point(579, 243);
            qlHDCTBtn.Name = "qlHDCTBtn";
            qlHDCTBtn.Size = new Size(161, 63);
            qlHDCTBtn.TabIndex = 4;
            qlHDCTBtn.Text = "QLy Hóa Đơn Chi Tiết";
            qlHDCTBtn.UseVisualStyleBackColor = true;
            qlHDCTBtn.Click += qlHDCTBtn_Click;
            // 
            // qlSPBtn
            // 
            qlSPBtn.Location = new Point(579, 127);
            qlSPBtn.Name = "qlSPBtn";
            qlSPBtn.Size = new Size(161, 63);
            qlSPBtn.TabIndex = 5;
            qlSPBtn.Text = "QLy Sản Phẩm";
            qlSPBtn.UseVisualStyleBackColor = true;
            qlSPBtn.Click += qlSPBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(199, 34);
            label1.Name = "label1";
            label1.Size = new Size(399, 37);
            label1.TabIndex = 6;
            label1.Text = "Chọn Menu Quản Lý Dưới Đây";
            // 
            // qlHDBtn
            // 
            qlHDBtn.Location = new Point(328, 243);
            qlHDBtn.Name = "qlHDBtn";
            qlHDBtn.Size = new Size(161, 63);
            qlHDBtn.TabIndex = 7;
            qlHDBtn.Text = "QLy Hóa Đơn";
            qlHDBtn.UseVisualStyleBackColor = true;
            qlHDBtn.Click += qlHDBtn_Click;
            // 
            // MenuManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 360);
            Controls.Add(qlHDBtn);
            Controls.Add(label1);
            Controls.Add(qlSPBtn);
            Controls.Add(qlHDCTBtn);
            Controls.Add(qlNVBtn);
            Controls.Add(qlTPBtn);
            Controls.Add(qlBHBtn);
            Name = "MenuManager";
            Text = "MenuManager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button qlBHBtn;
        private Button qlTPBtn;
        private Button qlNVBtn;
        private Button qlHDCTBtn;
        private Button qlSPBtn;
        private Label label1;
        private Button qlHDBtn;
    }
}