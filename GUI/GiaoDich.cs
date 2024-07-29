

using DAL.Models;
using BUS.CurrentHolder;
using BUS.IService;
using DAL.Repo;
using GUI.Properties;
using Microsoft.VisualBasic.ApplicationServices;
namespace GUI
{
    public partial class GiaoDich : Form
    {
        private readonly IChucNangKhachHang _khachhangservices;
        private readonly IChucNangGiaoDich _services;
        private NhanVien currentuser = CurrentUser.CurrentNhavien;
        public GiaoDich(IChucNangGiaoDich services, IChucNangKhachHang khachanhservices)
        {
            _khachhangservices = khachanhservices;
            _services = services;
            InitializeComponent();
            taogiohang();
            LoadAsync();

        }
        public void taogiohang()
        {
            txt_giohang.Text = string.Empty;
            if (CurrentCart.currentcart == null)
            {
                var gh = _services.AddGioHang();
                if (gh != null)
                {
                    CurrentCart.SetCurrentGH(gh);
                }
            }
            txt_giohang.Text = $"GH-{CurrentCart.currentcart.IdGioHang}";
        }
        public void cleargiohang()
        {

            if (CurrentCart.currentcart != null)
            {
                CurrentCart.DeleteCurrentGH();
            }

        }

        public async void LoadAsync()
        {
            var ct = await _services.AllChiTietTrongXe(CurrentCart.currentcart.IdGioHang);
            loadsptrongxe(ct);

            var datasp = await _services.AllSanPham();
            loaddatasp(datasp);

            var datagiohang = await _services.AllGioHangCho();
            loaddatagiohang(datagiohang);
        }
        public void loaddatagiohang(IEnumerable<GioHang> data)
        {
            flo_giohangcho.Controls.Clear();
            flo_giohangcho.AutoScroll = true;
            foreach (var item in data)
            {
                Panel itemPanel = new Panel
                {
                    Width = 110,
                    Height = 118,
                    Padding = new Padding(10),
                    Margin = new Padding(5),
                    Cursor = Cursors.Hand,
                    Enabled = true,
                    Visible = true,
                    Tag = item

                };
                PictureBox pic = new PictureBox
                {
                    Image = Resource.order_history,
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Width = 50,
                    Height = 50,
                    Top = 10,
                    Left = 30,
                    Enabled = false
                };
                Label label = new Label
                {
                    Text = $"GH_{item.IdGioHang}",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Width = 90,
                    Top = pic.Bottom,
                    Left = 12,
                    Enabled = false

                };
                itemPanel.Controls.Add(pic);
                itemPanel.Controls.Add(label);
                itemPanel.BringToFront();
                itemPanel.DoubleClick += ItemPanel_DoubleClick;

                flo_giohangcho.Controls.Add(itemPanel);
                flo_giohangcho.SendToBack();
            }
        }
        private void ItemPanel_DoubleClick(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            GioHang selectedCart = (GioHang)panel.Tag;
            ReturnCart(selectedCart);
        }
        private void ReturnCart(GioHang cart)
        {
            // Implement the logic to return the cart
            // For example:
            cleargiohang();
            CurrentCart.SetCurrentGH(cart);
            txt_giohang.Text = $"GH-{CurrentCart.currentcart.IdGioHang}";
            LoadAsync();
            // Add any other necessary logic
        }

        public void loaddatasp(IEnumerable<SanPham> data)
        {
            dtg_sanpham.Rows.Clear();
            dtg_sanpham.ColumnCount = 3;
            dtg_sanpham.Columns[0].Name = "Id";
            dtg_sanpham.Columns[1].Name = "Ten";
            dtg_sanpham.Columns[2].Name = "Gia";

            dtg_sanpham.Columns[0].Visible = false;
            foreach (SanPham item in data)
            {
                dtg_sanpham.Rows.Add(item.IdSanPham, item.TenSanPham, item.Gia);
            }

        }
        private async void dtg_sanpham_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            var spchon = dtg_sanpham.Rows[index];
            if (index >= 0)
            {
                int id = Convert.ToInt32(spchon.Cells[0].Value);
                CheckResult result = await _services.AddChiTietGioHang(CurrentCart.currentcart.IdGioHang, id);
                switch (result)
                {
                    case CheckResult.KoDuSoLuong:
                        MessageBox.Show("Ko Du So Luong");
                        break;
                    case CheckResult.KoThanhCong:
                        MessageBox.Show("Ko Thanh Cong");
                        break;
                    case CheckResult.ThanhCong:
                        LoadAsync();
                        break;
                    default:
                        MessageBox.Show("Ko Thanh Cong");
                        break;
                }
            }
        }

        public void loadsptrongxe(List<GioHangChiTiet> data)
        {
            dtg_xesanpham.Rows.Clear();
            dtg_xesanpham.ColumnCount = 7;
            dtg_xesanpham.RowTemplate.Height = 50;
            dtg_xesanpham.Columns[0].Name = "IdChiTiet";
            dtg_xesanpham.Columns[1].Name = "IdSanPham";
            dtg_xesanpham.Columns[2].Name = "TenSanPham";
            dtg_xesanpham.Columns[3].Name = "Gia";
            dtg_xesanpham.Columns[4].Name = "GiaGiam";
            dtg_xesanpham.Columns[5].Name = "SoLuong";
            dtg_xesanpham.Columns[6].Name = "ThanhTien";

            dtg_xesanpham.Columns[0].ReadOnly = true;
            dtg_xesanpham.Columns[1].ReadOnly = true;
            dtg_xesanpham.Columns[2].ReadOnly = true;
            dtg_xesanpham.Columns[3].ReadOnly = true;
            dtg_xesanpham.Columns[4].ReadOnly = true;
            dtg_xesanpham.Columns[6].ReadOnly = true;

            dtg_xesanpham.Columns[0].Visible = false;
            dtg_xesanpham.Columns[1].Visible = false;

            DataGridViewImageColumn delete = new DataGridViewImageColumn();
            delete.Name = "Delete";
            delete.Image = Properties.Resource.trash_xmark;
            //delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dtg_xesanpham.Columns.Add(delete);
            foreach (var item in data)
            {
                var phantram = item.GiamGia / 100 ?? 0;
                decimal giagiam = item.DonGia * (1 - phantram);
                dtg_xesanpham.Rows.Add(item.IdGioHangChiTiet, item.IdSanPham, item.TenSanPham, item.DonGia, giagiam, item.SoLuong, item.ThanhTien);
            }
            txt_tongtien.Text = data.Sum(ct => ct.ThanhTien).ToString();
        }

        private async void dtg_xesanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtg_xesanpham.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int chitiet = Convert.ToInt32(dtg_xesanpham.Rows[e.RowIndex].Cells["IdChiTiet"].Value);
                var delete = await _services.DeleteChiTiet(chitiet);
                if (delete)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadAsync();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }

            }
        }

        private async void dtg_xesanpham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtg_xesanpham.Columns["SoLuong"].Index && e.RowIndex >= 0)
            {
                int chitiet = Convert.ToInt32(dtg_xesanpham.Rows[e.RowIndex].Cells["IdChiTiet"].Value);
                int sp = Convert.ToInt32(dtg_xesanpham.Rows[e.RowIndex].Cells["IdSanPham"].Value);
                if (int.TryParse(dtg_xesanpham.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out int soluong))
                {
                    var result = await _services.UpdateChiTiet(chitiet, sp, soluong);
                    switch (result)
                    {
                        case CheckResult.ThanhCong:
                            LoadAsync();
                            break;
                        case CheckResult.KoThanhCong:
                            MessageBox.Show("Sua Ko Thanh Cong");
                            LoadAsync();
                            break;
                        case CheckResult.KoTimThayChiTiet:
                            MessageBox.Show("Ko Thay Chi Tiet");
                            LoadAsync();
                            break;
                        case CheckResult.KoTimThaySP:
                            MessageBox.Show("Ko Tim Thay San Pham");
                            LoadAsync();
                            break;
                        case CheckResult.KoDuSoLuong:
                            MessageBox.Show("Ko Du So Luong");
                            LoadAsync();
                            break;
                        default:
                            MessageBox.Show("Sua Ko Thanh Cong");
                            LoadAsync();
                            break;
                    }
                }
            }
        }

        private async void btn_treodon_Click(object sender, EventArgs e)
        {
            bool trangthai = false;
            int giohang = CurrentCart.currentcart.IdGioHang;
            await _services.UpdateGioHang(giohang, trangthai);
            cleargiohang();
            taogiohang();
            LoadAsync();
        }

        private async void btn_huydon_Click(object sender, EventArgs e)
        {
            int idgiohang = CurrentCart.currentcart.IdGioHang;
            await _services.XoaGioHang(idgiohang);
            cleargiohang();
            taogiohang();
            LoadAsync();
        }

        private async void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            decimal tongtien = Convert.ToDecimal(txt_tongtien.Text);
            decimal tien = 0;
            using (var formthanhtoan = new ThanhToanWindow(tongtien))
            {
                if (formthanhtoan.ShowDialog() == DialogResult.OK)
                {
                    tien = formthanhtoan.tiennhap;
                }
                else
                {
                    return;
                }
            }
            int idgiohang = CurrentCart.currentcart.IdGioHang;
            int userid = currentuser.UserId;
            bool phuongthuc = true;

            var result = await _services.ThanhToan(idgiohang, userid, tien, phuongthuc, 0);
            switch (result)
            {
                case CheckResult.ThanhCong:
                    await _services.XoaGioHang(idgiohang);
                    cleargiohang();
                    taogiohang();
                    LoadAsync();
                    break;
                case CheckResult.KoThanhCong:
                    MessageBox.Show("Ko Thanh Cong");
                    break;
                case CheckResult.ThieuTien:
                    MessageBox.Show("Ko Du Tien");
                    break;
                case CheckResult.KoTimThayGH:
                    MessageBox.Show("Ko Co Gio Hang");
                    break;
                default:
                    MessageBox.Show("Ko Thanh Cong");
                    break;
            }

        }

        private async void btn_vanchuyen_Click(object sender, EventArgs e)
        {
            decimal tongtien = Convert.ToDecimal(txt_tongtien.Text);
            using (var formthanhtoan = new VanChuyenWindow(tongtien, _khachhangservices))
            {
                if (formthanhtoan.ShowDialog() == DialogResult.OK)
                {
                    decimal tien = formthanhtoan.tiennhap;
                    int kh = formthanhtoan.KhachHang;
                    int idgiohang = CurrentCart.currentcart.IdGioHang;
                    int userid = currentuser.UserId;
                    bool phuongthuc = false;

                    var result = await _services.ThanhToan(idgiohang, userid, tien, phuongthuc, kh);
                    switch (result)
                    {
                        case CheckResult.ThanhCong:
                            await _services.XoaGioHang(idgiohang);
                            cleargiohang();
                            taogiohang();
                            LoadAsync();
                            break;
                        case CheckResult.KoThanhCong:
                            MessageBox.Show("Ko Thanh Cong");
                            break;
                        case CheckResult.ThieuTien:
                            MessageBox.Show("Ko Du Tien");
                            break;
                        case CheckResult.KoTimThayGH:
                            MessageBox.Show("Ko Co Gio Hang");
                            break;
                        default:
                            MessageBox.Show("Ko Thanh Cong");
                            break;
                    }
                }
                else
                {
                    return;
                }
            }

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
