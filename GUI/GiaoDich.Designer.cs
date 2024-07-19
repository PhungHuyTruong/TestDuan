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
            tabs = new TabControl();
            tb_thanhtoan = new TabPage();
            panel5 = new Panel();
            panel4 = new Panel();
            dtg_sanpham = new DataGridView();
            panel3 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            dtg_xesanpham = new DataGridView();
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            tb_hoadon = new TabPage();
            tabs.SuspendLayout();
            tb_thanhtoan.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_sanpham).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_xesanpham).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabs
            // 
            tabs.Controls.Add(tb_thanhtoan);
            tabs.Controls.Add(tb_hoadon);
            tabs.ItemSize = new Size(100, 35);
            tabs.Location = new Point(-4, -1);
            tabs.Name = "tabs";
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(1600, 962);
            tabs.TabIndex = 0;
            // 
            // tb_thanhtoan
            // 
            tb_thanhtoan.BackColor = Color.FromArgb(242, 242, 242);
            tb_thanhtoan.Controls.Add(panel5);
            tb_thanhtoan.Controls.Add(panel4);
            tb_thanhtoan.Controls.Add(panel3);
            tb_thanhtoan.Controls.Add(panel2);
            tb_thanhtoan.Controls.Add(panel1);
            tb_thanhtoan.Location = new Point(4, 39);
            tb_thanhtoan.Name = "tb_thanhtoan";
            tb_thanhtoan.Size = new Size(1592, 919);
            tb_thanhtoan.TabIndex = 0;
            tb_thanhtoan.Text = "Thanh Toán";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(1448, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(129, 913);
            panel5.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(dtg_sanpham);
            panel4.Location = new Point(1052, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(375, 913);
            panel4.TabIndex = 2;
            // 
            // dtg_sanpham
            // 
            dtg_sanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_sanpham.Location = new Point(17, 209);
            dtg_sanpham.Name = "dtg_sanpham";
            dtg_sanpham.RowHeadersWidth = 51;
            dtg_sanpham.Size = new Size(345, 688);
            dtg_sanpham.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Location = new Point(-3, 837);
            panel3.Name = "panel3";
            panel3.Size = new Size(1033, 79);
            panel3.TabIndex = 1;
            // 
            // button5
            // 
            button5.Location = new Point(787, 11);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(238, 59);
            button5.TabIndex = 0;
            button5.Text = "VAN CHUYEN";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(532, 11);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(238, 59);
            button4.TabIndex = 0;
            button4.Text = "TREO ĐƠN";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(269, 11);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(238, 59);
            button3.TabIndex = 0;
            button3.Text = "HỦY ĐƠN";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(9, 11);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(238, 59);
            button2.TabIndex = 0;
            button2.Text = "THANH TOÁN";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dtg_xesanpham);
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(1033, 752);
            panel2.TabIndex = 1;
            // 
            // dtg_xesanpham
            // 
            dtg_xesanpham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_xesanpham.Location = new Point(9, 12);
            dtg_xesanpham.Name = "dtg_xesanpham";
            dtg_xesanpham.RowHeadersWidth = 51;
            dtg_xesanpham.Size = new Size(1013, 665);
            dtg_xesanpham.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1033, 55);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(389, 11);
            button1.Name = "button1";
            button1.Size = new Size(64, 34);
            button1.TabIndex = 1;
            button1.Text = "button1";
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
            tb_hoadon.Location = new Point(4, 39);
            tb_hoadon.Name = "tb_hoadon";
            tb_hoadon.Padding = new Padding(3);
            tb_hoadon.Size = new Size(1592, 919);
            tb_hoadon.TabIndex = 1;
            tb_hoadon.Text = "Hóa Đơn";
            tb_hoadon.UseVisualStyleBackColor = true;
            // 
            // GiaoDich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(1581, 950);
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
            ((System.ComponentModel.ISupportInitialize)dtg_xesanpham).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button4;
        private Button button3;
        private Button button2;
        private DataGridView dtg_xesanpham;
        private Panel panel4;
        private DataGridView dtg_sanpham;
        private Panel panel5;
        private Button button5;
    }
}