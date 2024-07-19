using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KhachHang
{
    public int IdKhachHang { get; set; }

    public string Ten { get; set; } = null!;

    public string SoDienThoai { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
