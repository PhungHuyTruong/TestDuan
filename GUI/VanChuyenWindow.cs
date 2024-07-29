using BUS.IService;
using DAL.Models;
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
    public partial class VanChuyenWindow : Form
    {
        private readonly IChucNangKhachHang _services;
        private decimal _tongtien;
        public decimal tiennhap { get; private set; }
        public int KhachHang { get; private set; }
        public VanChuyenWindow(decimal tongtien , IChucNangKhachHang servicecs)
        {
            InitializeComponent();
            _tongtien = tongtien;
            _services = servicecs;
            this.StartPosition = FormStartPosition.CenterScreen;
            txt_tongtien.Text = Convert.ToString(_tongtien);
        }
       private  void btn_xacthuc_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_tiennhap.Text, out decimal tien))
            {
                string sdtkh = txt_khachhang.Text;
                if (string.IsNullOrWhiteSpace(sdtkh))
                {
                    MessageBox.Show("Please enter a valid phone number.");
                    return;
                }

                try
                {
                    var kh = _services.GetKhachHang(sdtkh);
                    if (kh == null)
                    {
                        MessageBox.Show("Customer not found.");
                        return;
                    }

                    tiennhap = (tien > _tongtien) ? _tongtien : tien;
                    KhachHang = kh.IdKhachHang;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Hay Nhap So");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txt_tiennhap_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_tiennhap.Text, out decimal tien))
            {
                txt_tienthua.Text = (tien - _tongtien).ToString();
            }
            else
            {
                txt_tienthua.Text = _tongtien.ToString(); // Reset to full amount if invalid input
            }
        }
    }
}

