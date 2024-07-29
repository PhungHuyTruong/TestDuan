namespace GUI
{
    partial class VanChuyenWindow
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_xacthuc = new Button();
            btn_xoa = new Button();
            txt_tienthua = new TextBox();
            txt_tiennhap = new TextBox();
            txt_tongtien = new TextBox();
            txt_khachhang = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 178);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 8;
            label3.Text = "Tiền Thừa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 127);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 9;
            label2.Text = "Tiền Nhập:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 80);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 10;
            label1.Text = "Tổng Tiền:";
            // 
            // btn_xacthuc
            // 
            btn_xacthuc.Location = new Point(105, 220);
            btn_xacthuc.Name = "btn_xacthuc";
            btn_xacthuc.Size = new Size(138, 29);
            btn_xacthuc.TabIndex = 6;
            btn_xacthuc.Text = "Hoàn Tất";
            btn_xacthuc.UseVisualStyleBackColor = true;
            btn_xacthuc.Click += btn_xacthuc_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(294, 220);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(138, 29);
            btn_xoa.TabIndex = 7;
            btn_xoa.Text = "Hủy";
            btn_xoa.UseVisualStyleBackColor = true;
            btn_xoa.Click += btn_xoa_Click;
            // 
            // txt_tienthua
            // 
            txt_tienthua.BackColor = Color.White;
            txt_tienthua.Location = new Point(105, 171);
            txt_tienthua.Name = "txt_tienthua";
            txt_tienthua.ReadOnly = true;
            txt_tienthua.Size = new Size(327, 27);
            txt_tienthua.TabIndex = 3;
            // 
            // txt_tiennhap
            // 
            txt_tiennhap.Location = new Point(105, 120);
            txt_tiennhap.Name = "txt_tiennhap";
            txt_tiennhap.Size = new Size(327, 27);
            txt_tiennhap.TabIndex = 4;
            txt_tiennhap.TextChanged += txt_tiennhap_TextChanged;
            // 
            // txt_tongtien
            // 
            txt_tongtien.BackColor = Color.White;
            txt_tongtien.Location = new Point(105, 73);
            txt_tongtien.Name = "txt_tongtien";
            txt_tongtien.ReadOnly = true;
            txt_tongtien.Size = new Size(327, 27);
            txt_tongtien.TabIndex = 5;
            // 
            // txt_khachhang
            // 
            txt_khachhang.BackColor = Color.White;
            txt_khachhang.Location = new Point(105, 24);
            txt_khachhang.Name = "txt_khachhang";
            txt_khachhang.Size = new Size(327, 27);
            txt_khachhang.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 31);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 10;
            label4.Text = "Khách Hàng:";
            // 
            // VanChuyenWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 259);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btn_xacthuc);
            Controls.Add(btn_xoa);
            Controls.Add(txt_tienthua);
            Controls.Add(txt_tiennhap);
            Controls.Add(txt_khachhang);
            Controls.Add(txt_tongtien);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VanChuyenWindow";
            Text = "VanChuyenWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_xacthuc;
        private Button btn_xoa;
        private TextBox txt_tienthua;
        private TextBox txt_tiennhap;
        private TextBox txt_tongtien;
        private TextBox txt_khachhang;
        private Label label4;
    }
}