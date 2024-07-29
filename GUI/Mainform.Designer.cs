namespace GUI
{
    partial class Mainform
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
            components = new System.ComponentModel.Container();
            showform = new Panel();
            panel2 = new Panel();
            btn_thuoctinh = new Button();
            panel6 = new Panel();
            btn_quanlynguoidung = new Button();
            panel7 = new Panel();
            btn_thongke = new Button();
            panel1 = new Panel();
            btn_trangchu = new Button();
            panel5 = new Panel();
            btn_sanpham = new Button();
            panel4 = new Panel();
            btn_banhang = new Button();
            panel3 = new Panel();
            btn_menu = new Button();
            menuexpand = new System.Windows.Forms.Timer(components);
            panel8 = new Panel();
            btn_logoff = new Button();
            menubar = new Panel();
            btn_formkhachhang = new Button();
            panel9 = new Panel();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            menubar.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // showform
            // 
            showform.BackColor = Color.White;
            showform.Location = new Point(123, 29);
            showform.Name = "showform";
            showform.Size = new Size(1581, 950);
            showform.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_thuoctinh);
            panel2.Location = new Point(0, 510);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 77);
            panel2.TabIndex = 0;
            // 
            // btn_thuoctinh
            // 
            btn_thuoctinh.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_thuoctinh.Image = Properties.Resource.attribution_pencil__1_;
            btn_thuoctinh.ImageAlign = ContentAlignment.MiddleLeft;
            btn_thuoctinh.Location = new Point(-19, -17);
            btn_thuoctinh.Name = "btn_thuoctinh";
            btn_thuoctinh.Padding = new Padding(40, 0, 0, 0);
            btn_thuoctinh.Size = new Size(252, 112);
            btn_thuoctinh.TabIndex = 2;
            btn_thuoctinh.Text = "                THUỘC TÍNH";
            btn_thuoctinh.TextAlign = ContentAlignment.MiddleLeft;
            btn_thuoctinh.UseVisualStyleBackColor = true;
            btn_thuoctinh.Click += btn_thuoctinh_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btn_quanlynguoidung);
            panel6.Location = new Point(0, 433);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(225, 77);
            panel6.TabIndex = 0;
            // 
            // btn_quanlynguoidung
            // 
            btn_quanlynguoidung.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_quanlynguoidung.Image = Properties.Resource.user;
            btn_quanlynguoidung.ImageAlign = ContentAlignment.MiddleLeft;
            btn_quanlynguoidung.Location = new Point(-19, -14);
            btn_quanlynguoidung.Name = "btn_quanlynguoidung";
            btn_quanlynguoidung.Padding = new Padding(40, 0, 0, 0);
            btn_quanlynguoidung.Size = new Size(252, 112);
            btn_quanlynguoidung.TabIndex = 1;
            btn_quanlynguoidung.Text = "                   QUẢN LÝ \r\n                NGƯỜI DÙNG";
            btn_quanlynguoidung.TextAlign = ContentAlignment.MiddleLeft;
            btn_quanlynguoidung.UseVisualStyleBackColor = true;
            btn_quanlynguoidung.Click += btn_quanlynguoidung_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(btn_thongke);
            panel7.Location = new Point(0, 587);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(225, 77);
            panel7.TabIndex = 0;
            // 
            // btn_thongke
            // 
            btn_thongke.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_thongke.Image = Properties.Resource.dashboard_panel;
            btn_thongke.ImageAlign = ContentAlignment.MiddleLeft;
            btn_thongke.Location = new Point(-19, -14);
            btn_thongke.Name = "btn_thongke";
            btn_thongke.Padding = new Padding(40, 0, 0, 0);
            btn_thongke.Size = new Size(252, 112);
            btn_thongke.TabIndex = 1;
            btn_thongke.Text = "                THỐNG KÊ";
            btn_thongke.TextAlign = ContentAlignment.MiddleLeft;
            btn_thongke.UseVisualStyleBackColor = true;
            btn_thongke.Click += btn_thongke_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_trangchu);
            panel1.Location = new Point(0, 125);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 77);
            panel1.TabIndex = 0;
            // 
            // btn_trangchu
            // 
            btn_trangchu.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_trangchu.Image = Properties.Resource.home;
            btn_trangchu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_trangchu.Location = new Point(-19, -18);
            btn_trangchu.Name = "btn_trangchu";
            btn_trangchu.Padding = new Padding(40, 0, 0, 0);
            btn_trangchu.Size = new Size(257, 112);
            btn_trangchu.TabIndex = 2;
            btn_trangchu.Text = "                TRANG CHỦ";
            btn_trangchu.TextAlign = ContentAlignment.MiddleLeft;
            btn_trangchu.UseVisualStyleBackColor = true;
            btn_trangchu.Click += btn_trangchu_Click_1;
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_sanpham);
            panel5.Location = new Point(0, 279);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 77);
            panel5.TabIndex = 0;
            // 
            // btn_sanpham
            // 
            btn_sanpham.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sanpham.Image = Properties.Resource.box;
            btn_sanpham.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sanpham.Location = new Point(-19, -14);
            btn_sanpham.Name = "btn_sanpham";
            btn_sanpham.Padding = new Padding(40, 0, 0, 0);
            btn_sanpham.Size = new Size(252, 112);
            btn_sanpham.TabIndex = 1;
            btn_sanpham.Text = "                SẢN PHẨM";
            btn_sanpham.TextAlign = ContentAlignment.MiddleLeft;
            btn_sanpham.UseVisualStyleBackColor = true;
            btn_sanpham.Click += btn_sanpham_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_banhang);
            panel4.Location = new Point(0, 202);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 77);
            panel4.TabIndex = 0;
            // 
            // btn_banhang
            // 
            btn_banhang.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_banhang.Image = Properties.Resource.shopping_cart;
            btn_banhang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_banhang.Location = new Point(-19, -14);
            btn_banhang.Name = "btn_banhang";
            btn_banhang.Padding = new Padding(40, 0, 0, 0);
            btn_banhang.Size = new Size(252, 112);
            btn_banhang.TabIndex = 1;
            btn_banhang.Text = "                GIAO DỊCH";
            btn_banhang.TextAlign = ContentAlignment.MiddleLeft;
            btn_banhang.UseVisualStyleBackColor = true;
            btn_banhang.Click += btn_banhang_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_menu);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 125);
            panel3.TabIndex = 0;
            // 
            // btn_menu
            // 
            btn_menu.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_menu.Image = Properties.Resource.menu_burger;
            btn_menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_menu.Location = new Point(-19, -14);
            btn_menu.Name = "btn_menu";
            btn_menu.Padding = new Padding(40, 0, 0, 0);
            btn_menu.Size = new Size(252, 157);
            btn_menu.TabIndex = 1;
            btn_menu.Text = "                MENU";
            btn_menu.TextAlign = ContentAlignment.MiddleLeft;
            btn_menu.UseVisualStyleBackColor = true;
            btn_menu.Click += btn_menu_Click;
            // 
            // menuexpand
            // 
            menuexpand.Interval = 1;
            menuexpand.Tick += menuexpand_Tick;
            // 
            // panel8
            // 
            panel8.Controls.Add(btn_logoff);
            panel8.Location = new Point(0, 932);
            panel8.Margin = new Padding(0);
            panel8.Name = "panel8";
            panel8.Size = new Size(225, 77);
            panel8.TabIndex = 0;
            // 
            // btn_logoff
            // 
            btn_logoff.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logoff.Image = Properties.Resource.power;
            btn_logoff.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logoff.Location = new Point(-19, -14);
            btn_logoff.Name = "btn_logoff";
            btn_logoff.Padding = new Padding(40, 0, 0, 0);
            btn_logoff.Size = new Size(252, 112);
            btn_logoff.TabIndex = 1;
            btn_logoff.Text = "                ĐĂNG XUẤT";
            btn_logoff.TextAlign = ContentAlignment.MiddleLeft;
            btn_logoff.UseVisualStyleBackColor = true;
            btn_logoff.Click += btn_logoff_Click;
            // 
            // menubar
            // 
            menubar.BackColor = Color.White;
            menubar.Controls.Add(panel2);
            menubar.Controls.Add(panel3);
            menubar.Controls.Add(panel9);
            menubar.Controls.Add(panel6);
            menubar.Controls.Add(panel1);
            menubar.Controls.Add(panel7);
            menubar.Controls.Add(panel8);
            menubar.Controls.Add(panel5);
            menubar.Controls.Add(panel4);
            menubar.Dock = DockStyle.Left;
            menubar.Location = new Point(0, 0);
            menubar.MaximumSize = new Size(225, 0);
            menubar.MinimumSize = new Size(81, 0);
            menubar.Name = "menubar";
            menubar.Size = new Size(81, 1009);
            menubar.TabIndex = 4;
            // 
            // btn_formkhachhang
            // 
            btn_formkhachhang.BackgroundImageLayout = ImageLayout.None;
            btn_formkhachhang.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_formkhachhang.Image = Properties.Resource.users_alt;
            btn_formkhachhang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_formkhachhang.Location = new Point(-19, -17);
            btn_formkhachhang.Name = "btn_formkhachhang";
            btn_formkhachhang.Padding = new Padding(40, 0, 0, 0);
            btn_formkhachhang.Size = new Size(252, 112);
            btn_formkhachhang.TabIndex = 2;
            btn_formkhachhang.Text = "                   QUẢN LÝ \r\n                KHÁCH HÀNG";
            btn_formkhachhang.TextAlign = ContentAlignment.MiddleLeft;
            btn_formkhachhang.UseVisualStyleBackColor = true;
            btn_formkhachhang.Click += btn_formkhachhang_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(btn_formkhachhang);
            panel9.Location = new Point(0, 356);
            panel9.Margin = new Padding(0);
            panel9.Name = "panel9";
            panel9.Size = new Size(225, 77);
            panel9.TabIndex = 0;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1742, 1009);
            Controls.Add(menubar);
            Controls.Add(showform);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mainform";
            Text = "Mainform";
            Load += Mainform_Load;
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            menubar.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel showform;
        private Panel panel3;
        private Button btn_menu;
        private Panel panel4;
        private Button btn_banhang;
        private Panel panel5;
        private Button btn_sanpham;
        private Panel panel6;
        private Button btn_quanlynguoidung;
        private Panel panel7;
        private Button btn_thongke;
        private System.Windows.Forms.Timer menuexpand;
        private Panel panel8;
        private Button btn_logoff;
        private Panel menubar;
        private Panel panel1;
        private Panel panel2;
        private Button btn_trangchu;
        private Button btn_thuoctinh;
        private Panel panel10;
        private Button btn_formkhachhang;
        private Panel panel9;
        private Button btn_khachhang;
    }
}