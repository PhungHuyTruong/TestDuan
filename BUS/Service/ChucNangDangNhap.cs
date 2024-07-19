using BUS.IService;
using DAL.IRepo;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class ChucNangDangNhap : IChucNangDangNhap
    {
        private readonly IQuanLyDangNhap _context;
        public ChucNangDangNhap(IQuanLyDangNhap context)
        {
            _context = context;
        }
        public NhanVien KiemTra(string tk,string mk)
        {
            return _context.KiemTra(tk,mk);
        }
    }
}
