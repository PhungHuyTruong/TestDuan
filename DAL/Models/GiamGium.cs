using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class GiamGium
{
    public int IdGiamGia { get; set; }

    public string LoaiGiamGia { get; set; } = null!;

    public decimal MucGiamGia { get; set; }

    public DateTime NgayBatDau { get; set; }

    public DateTime NgayKetThuc { get; set; }

    public bool TrangThai { get; set; }

    public virtual ICollection<SanPham> SanPhams { get; set; } = new List<SanPham>();
}
