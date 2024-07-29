using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class GioHangChiTiet
{
    public int IdGioHangChiTiet { get; set; }

    public int IdGioHang { get; set; }

    public int IdSanPham { get; set; }

    public string TenSanPham { get; set; } = null!;

    public int SoLuong { get; set; }

    public decimal DonGia { get; set; }

    public decimal ThanhTien { get; set; }

    public decimal? GiamGia { get; set; }

    public virtual GioHang IdGioHangNavigation { get; set; } = null!;

    public virtual SanPham IdSanPhamNavigation { get; set; } = null!;
}
