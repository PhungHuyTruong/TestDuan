using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class GioiTinh
{
    public int IdGioiTinh { get; set; }

    public string TenGioiTinh { get; set; } = null!;

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
