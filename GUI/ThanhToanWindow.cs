using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ThanhToanWindow : Form
    {
        private decimal _tongtien;
        public decimal tiennhap { get; private set; }
        public ThanhToanWindow(decimal tongtien)
        {
            _tongtien = tongtien;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.Text = Convert.ToString(_tongtien);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox2.Text, out decimal tien))
            {
                if(tien > _tongtien)
                {
                    tiennhap = _tongtien;
                }
                tiennhap = tien;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Hay Nhap So");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox2.Text, out decimal tien))
            {
                textBox3.Text = (tien  -  _tongtien ).ToString();
            }
            else
            {
                textBox3.Text = _tongtien.ToString(); // Reset to full amount if invalid input
            }
        }

        private void textBox2_TabStopChanged(object sender, EventArgs e)
        {
        }
    }
}
