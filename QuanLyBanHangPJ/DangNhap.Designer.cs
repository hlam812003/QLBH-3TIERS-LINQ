namespace QuanLyBanHangPJ
{
    partial class DangNhap
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
            label2 = new Label();
            DangNhapInput = new TextBox();
            MatKhauInput = new TextBox();
            dangNhap_btn = new Button();
            xoa_btn = new Button();
            huy_btn = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(68, 66);
            label1.Name = "label1";
            label1.Size = new Size(190, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(68, 163);
            label2.Name = "label2";
            label2.Size = new Size(124, 32);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // DangNhapInput
            // 
            DangNhapInput.Location = new Point(330, 63);
            DangNhapInput.MinimumSize = new Size(277, 35);
            DangNhapInput.Name = "DangNhapInput";
            DangNhapInput.Size = new Size(277, 35);
            DangNhapInput.TabIndex = 3;
            DangNhapInput.TextAlign = HorizontalAlignment.Center;
            // 
            // MatKhauInput
            // 
            MatKhauInput.Location = new Point(330, 160);
            MatKhauInput.MinimumSize = new Size(277, 35);
            MatKhauInput.Name = "MatKhauInput";
            MatKhauInput.Size = new Size(277, 35);
            MatKhauInput.TabIndex = 3;
            MatKhauInput.TextAlign = HorizontalAlignment.Center;
            MatKhauInput.KeyPress += MatKhauInput_KeyPress;
            // 
            // dangNhap_btn
            // 
            dangNhap_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dangNhap_btn.Location = new Point(68, 307);
            dangNhap_btn.Name = "dangNhap_btn";
            dangNhap_btn.Size = new Size(133, 51);
            dangNhap_btn.TabIndex = 4;
            dangNhap_btn.Text = "Đăng Nhập";
            dangNhap_btn.UseVisualStyleBackColor = true;
            dangNhap_btn.Click += dangNhap_btn_Click;
            // 
            // xoa_btn
            // 
            xoa_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            xoa_btn.Location = new Point(272, 307);
            xoa_btn.Name = "xoa_btn";
            xoa_btn.Size = new Size(133, 51);
            xoa_btn.TabIndex = 5;
            xoa_btn.Text = "Xóa";
            xoa_btn.UseVisualStyleBackColor = true;
            xoa_btn.Click += xoa_btn_Click;
            // 
            // huy_btn
            // 
            huy_btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            huy_btn.Location = new Point(474, 307);
            huy_btn.Name = "huy_btn";
            huy_btn.Size = new Size(133, 51);
            huy_btn.TabIndex = 6;
            huy_btn.Text = "Hủy";
            huy_btn.UseVisualStyleBackColor = true;
            huy_btn.Click += huy_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 236);
            label3.Name = "label3";
            label3.Size = new Size(171, 20);
            label3.TabIndex = 7;
            label3.Text = "* Tên Đăng Nhập: admin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 236);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 8;
            label4.Text = "* Mật Khẩu: 123";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 405);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(huy_btn);
            Controls.Add(xoa_btn);
            Controls.Add(dangNhap_btn);
            Controls.Add(MatKhauInput);
            Controls.Add(DangNhapInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangNhap";
            Text = "Đăng Nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox DangNhapInput;
        private TextBox MatKhauInput;
        private Button dangNhap_btn;
        private Button xoa_btn;
        private Button huy_btn;
        private Label label3;
        private Label label4;
    }
}