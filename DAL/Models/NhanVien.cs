using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class NhanVien
{
    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public string Gender { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Role { get; set; } = null!;

    public string? RoleId { get; set; }

    public DateOnly? RegistrationDate { get; set; }

    public string? Avatar { get; set; }

    public string Password { get; set; } = null!;

    public bool TrangThai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
