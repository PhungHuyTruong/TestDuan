namespace GUI
{
    partial class ThanhToanWindow
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Location = new Point(102, 23);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(327, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(327, 27);
            textBox2.TabIndex = 0;
            textBox2.TabStopChanged += textBox2_TabStopChanged;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(102, 121);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(327, 27);
            textBox3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(291, 170);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 1;
            button1.Text = "Hủy";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(102, 170);
            button2.Name = "button2";
            button2.Size = new Size(138, 29);
            button2.TabIndex = 1;
            button2.Text = "Hoàn Tất";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Tổng Tiền:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 2;
            label2.Text = "Tiền Nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Tiền Thừa:";
            // 
            // ThanhToanWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 211);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ThanhToanWindow";
            Text = "ThanhToanWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}