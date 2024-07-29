namespace GUI
{
    partial class GiaoDich
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            tabs = new TabControl();
            tb_thanhtoan = new TabPage();
            flo_giohangcho = new FlowLayoutPanel();
            panel4 = new Panel();
            dtg_sanpham = new DataGridView();
            panel3 = new Panel();
            btn_vanchuyen = new Button();
            btn_treodon = new Button();
            btn_huydon = new Button();
            btn_thanhtoan = new Button();
            panel2 = new Panel();
            txt_tongtien = new TextBox();
            label1 = new Label();
            dtg_xesanpham = new DataGridView();
            panel1 = new Panel();
            txt_giohang = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            tb_hoadon = new TabPage();
            panel5 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridView2 = new DataGridView();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            panel6 = new Panel();
            dataGridView3 = new DataGridView();
            tabs.SuspendLayout();
            tb_thanhtoan.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_sanpham).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_xesanpham).BeginInit();
            panel1.SuspendLayout();
            tb_hoadon.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tabs
            // 
            tabs.Controls.Add(tb_thanhtoan);
            tabs.Controls.Add(tb_hoadon);
            tabs.ItemSize = new Size(100, 35);
            tabs.Location = new Point(1, 0);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1603, 962);
            tabs.TabIndex = 0;
            // 
            // tb_thanhtoan
            // 
            tb_thanhtoan.BackColor = Color.FromArgb(242, 242, 242);
            tb_thanhtoan.Controls.Add(flo_giohangcho);
            tb_thanhtoan.Controls.Add(panel4);
            tb_thanhtoan.Controls.Add(panel3);
            tb_thanhtoan.Controls.Add(panel2);
            tb_thanhtoan.Controls.Add(panel1);
            tb_thanhtoan.Location = new Point(4, 39);
            tb_thanhtoan.Name = "tb_thanhtoan";
            tb_thanhtoan.Size = new Size(1595, 919);
            tb_thanhtoan.TabIndex = 0;
            tb_thanhtoan.Text = "Thanh Toán";
            // 
            // flo_giohangcho
            // 
            flo_giohangcho.BackColor = Color.White;
            flo_giohangcho.Location = new Point(1445, 0);
            flo_giohangcho.Name = "flo_giohangcho";
            flo_giohangcho.Size = new Size(141, 916);
            flo_giohangcho.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dtg_sanpham);
            panel4.Location = new Point(1052, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(375, 916);
            panel4.TabIndex = 2;
            // 
            // dtg_sanpham
            // 
            dtg_sanpham.AllowUserToAddRows = false;
            dtg_sanpham.AllowUserToResizeColumns = false;
            dtg_sanpham.AllowUserToResizeRows = false;
            dtg_sanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_sanpham.BackgroundColor = Color.FromArgb(244, 243, 243);
            dtg_sanpham.BorderStyle = BorderStyle.None;
            dtg_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_sanpham.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dtg_sanpham.DefaultCellStyle = dataGridViewCellStyle3;
            dtg_sanpham.GridColor = SystemColors.MenuBar;
            dtg_sanpham.Location = new Point(13, 82);
            dtg_sanpham.Name = "dtg_sanpham";
            dtg_sanpham.ReadOnly = true;
            dtg_sanpham.RowHeadersVisible = false;
            dtg_sanpham.RowHeadersWidth = 51;
            dtg_sanpham.Size = new Size(348, 815);
            dtg_sanpham.TabIndex = 0;
            dtg_sanpham.CellContentDoubleClick += dtg_sanpham_CellContentDoubleClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btn_vanchuyen);
            panel3.Controls.Add(btn_treodon);
            panel3.Controls.Add(btn_huydon);
            panel3.Controls.Add(btn_thanhtoan);
            panel3.Location = new Point(-3, 837);
            panel3.Name = "panel3";
            panel3.Size = new Size(1033, 79);
            panel3.TabIndex = 1;
            // 
            // btn_vanchuyen
            // 
            btn_vanchuyen.Location = new Point(787, 11);
            btn_vanchuyen.Margin = new Padding(0);
            btn_vanchuyen.Name = "btn_vanchuyen";
            btn_vanchuyen.Size = new Size(238, 59);
            btn_vanchuyen.TabIndex = 0;
            btn_vanchuyen.Text = "VẬN CHUYỂN";
            btn_vanchuyen.UseVisualStyleBackColor = true;
            btn_vanchuyen.Click += btn_vanchuyen_Click;
            // 
            // btn_treodon
            // 
            btn_treodon.Location = new Point(528, 11);
            btn_treodon.Margin = new Padding(0);
            btn_treodon.Name = "btn_treodon";
            btn_treodon.Size = new Size(238, 59);
            btn_treodon.TabIndex = 0;
            btn_treodon.Text = "TREO ĐƠN";
            btn_treodon.UseVisualStyleBackColor = true;
            btn_treodon.Click += btn_treodon_Click;
            // 
            // btn_huydon
            // 
            btn_huydon.Location = new Point(268, 11);
            btn_huydon.Margin = new Padding(0);
            btn_huydon.Name = "btn_huydon";
            btn_huydon.Size = new Size(238, 59);
            btn_huydon.TabIndex = 0;
            btn_huydon.Text = "HỦY ĐƠN";
            btn_huydon.UseVisualStyleBackColor = true;
            btn_huydon.Click += btn_huydon_Click;
            // 
            // btn_thanhtoan
            // 
            btn_thanhtoan.Location = new Point(9, 11);
            btn_thanhtoan.Margin = new Padding(0);
            btn_thanhtoan.Name = "btn_thanhtoan";
            btn_thanhtoan.Size = new Size(238, 59);
            btn_thanhtoan.TabIndex = 0;
            btn_thanhtoan.Text = "THANH TOÁN";
            btn_thanhtoan.UseVisualStyleBackColor = true;
            btn_thanhtoan.Click += btn_thanhtoan_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(txt_tongtien);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dtg_xesanpham);
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1033, 752);
            panel2.TabIndex = 1;
            // 
            // txt_tongtien
            // 
            txt_tongtien.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_tongtien.Location = new Point(831, 712);
            txt_tongtien.Multiline = true;
            txt_tongtien.Name = "txt_tongtien";
            txt_tongtien.Size = new Size(191, 30);
            txt_tongtien.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(670, 712);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 2;
            label1.Text = "TỔNG TIỀN:";
            // 
            // dtg_xesanpham
            // 
            dtg_xesanpham.AllowUserToAddRows = false;
            dtg_xesanpham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_xesanpham.BackgroundColor = Color.FromArgb(244, 243, 243);
            dtg_xesanpham.BorderStyle = BorderStyle.None;
            dtg_xesanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(252, 252, 252);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtg_xesanpham.DefaultCellStyle = dataGridViewCellStyle4;
            dtg_xesanpham.GridColor = SystemColors.ScrollBar;
            dtg_xesanpham.Location = new Point(9, 12);
            dtg_xesanpham.Name = "dtg_xesanpham";
            dtg_xesanpham.RowHeadersVisible = false;
            dtg_xesanpham.RowHeadersWidth = 51;
            dtg_xesanpham.Size = new Size(1013, 683);
            dtg_xesanpham.TabIndex = 0;
            dtg_xesanpham.CellContentClick += dtg_xesanpham_CellContentClick;
            dtg_xesanpham.CellValueChanged += dtg_xesanpham_CellValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txt_giohang);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 55);
            panel1.TabIndex = 1;
            // 
            // txt_giohang
            // 
            txt_giohang.Cursor = Cursors.IBeam;
            txt_giohang.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_giohang.Location = new Point(897, 11);
            txt_giohang.Multiline = true;
            txt_giohang.Name = "txt_giohang";
            txt_giohang.ReadOnly = true;
            txt_giohang.Size = new Size(125, 34);
            txt_giohang.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resource.search;
            button1.Location = new Point(389, 11);
            button1.Name = "button1";
            button1.Size = new Size(64, 34);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 11);
            textBox1.Margin = new Padding(0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(380, 34);
            textBox1.TabIndex = 0;
            // 
            // tb_hoadon
            // 
            tb_hoadon.BackColor = Color.FromArgb(242, 242, 242);
            tb_hoadon.Controls.Add(panel6);
            tb_hoadon.Controls.Add(panel5);
            tb_hoadon.Location = new Point(4, 39);
            tb_hoadon.Name = "tb_hoadon";
            tb_hoadon.Padding = new Padding(3);
            tb_hoadon.Size = new Size(1595, 919);
            tb_hoadon.TabIndex = 1;
            tb_hoadon.Text = "Hóa Đơn";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button3);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(dataGridView2);
            panel5.Controls.Add(textBox6);
            panel5.Controls.Add(textBox5);
            panel5.Controls.Add(textBox4);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(dataGridView1);
            panel5.Location = new Point(-4, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(871, 913);
            panel5.TabIndex = 0;
            panel5.Paint += panel5_Paint;
            // 
            // button4
            // 
            button4.Location = new Point(576, 870);
            button4.Name = "button4";
            button4.Size = new Size(129, 29);
            button4.TabIndex = 3;
            button4.Text = "button2";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(724, 870);
            button3.Name = "button3";
            button3.Size = new Size(129, 29);
            button3.TabIndex = 3;
            button3.Text = "button2";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(424, 870);
            button2.Name = "button2";
            button2.Size = new Size(129, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(424, 458);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(429, 390);
            dataGridView2.TabIndex = 2;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(530, 219);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(323, 204);
            textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(530, 156);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(323, 27);
            textBox5.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(530, 95);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(323, 27);
            textBox4.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(530, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(323, 27);
            textBox2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(388, 889);
            dataGridView1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(dataGridView3);
            panel6.Location = new Point(911, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(669, 912);
            panel6.TabIndex = 1;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(14, 9);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(257, 889);
            dataGridView3.TabIndex = 0;
            // 
            // GiaoDich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1597, 950);
            Controls.Add(tabs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GiaoDich";
            Text = "GiaoDich";
            tabs.ResumeLayout(false);
            tb_thanhtoan.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_sanpham).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_xesanpham).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tb_hoadon.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tb_thanhtoan;
        private TabPage tb_hoadon;
        private TabControl tabs;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private Panel panel3;
        private Button btn_treodon;
        private Button btn_huydon;
        private Button btn_thanhtoan;
        private DataGridView dtg_xesanpham;
        private Panel panel4;
        private DataGridView dtg_sanpham;
        private Button btn_vanchuyen;
        private TextBox txt_tongtien;
        private Label label1;
        private TextBox txt_giohang;
        private FlowLayoutPanel flo_giohangcho;
        private Panel panel5;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dataGridView2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Panel panel6;
        private DataGridView dataGridView3;
    }
}