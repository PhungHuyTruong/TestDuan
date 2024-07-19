using DAL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class QuanLyDangNhap : IQuanLyDangNhap
    {
        private readonly ShopSanPhamContext _context;
        public QuanLyDangNhap()
        {
            _context = new ShopSanPhamContext();
        }
        public NhanVien KiemTra(string tk,string mk)
        {
            return _context.NhanViens.FirstOrDefault(nv => nv.Email.Equals(tk) && nv.Password.Equals(mk));
        }
    }
}
