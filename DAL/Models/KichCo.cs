using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class KichCo
{
    public int IdKichCo { get; set; }

    public int KichCo1 { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
