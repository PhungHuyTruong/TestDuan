using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class GioHang
{
    public int IdGioHang { get; set; }

    public bool TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; set; } = new List<GioHangChiTiet>();
}
