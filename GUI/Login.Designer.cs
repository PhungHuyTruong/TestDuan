namespace GUI
{
    partial class Login
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
            txt_taikhoan = new TextBox();
            txt_matkhau = new TextBox();
            btn_dangnhap = new Button();
            SuspendLayout();
            // 
            // txt_taikhoan
            // 
            txt_taikhoan.BackColor = SystemColors.ActiveBorder;
            txt_taikhoan.BorderStyle = BorderStyle.None;
            txt_taikhoan.ForeColor = Color.YellowGreen;
            txt_taikhoan.Location = new Point(274, 131);
            txt_taikhoan.Name = "txt_taikhoan";
            txt_taikhoan.Size = new Size(241, 20);
            txt_taikhoan.TabIndex = 0;
            // 
            // txt_matkhau
            // 
            txt_matkhau.Location = new Point(274, 176);
            txt_matkhau.Name = "txt_matkhau";
            txt_matkhau.Size = new Size(241, 27);
            txt_matkhau.TabIndex = 0;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.Location = new Point(276, 237);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Size = new Size(239, 29);
            btn_dangnhap.TabIndex = 1;
            btn_dangnhap.Text = "button1";
            btn_dangnhap.UseVisualStyleBackColor = true;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_dangnhap);
            Controls.Add(txt_matkhau);
            Controls.Add(txt_taikhoan);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_taikhoan;
        private TextBox txt_matkhau;
        private Button btn_dangnhap;
    }
}
