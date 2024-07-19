using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class MauSac
{
    public int IdMau { get; set; }

    public string MauSac1 { get; set; } = null!;

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
