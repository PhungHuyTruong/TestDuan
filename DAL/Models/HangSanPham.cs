using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class HangSanPham
{
    public int IdHang { get; set; }

    public string TenHang { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
