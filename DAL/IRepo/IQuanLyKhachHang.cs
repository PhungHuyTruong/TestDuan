using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepo
{
    public interface IQuanLyKhachHang
    {
        Task<IEnumerable<KhachHang>> GetAllKHachHang();
        void AddKhachHang(KhachHang kh);
        void UpdateKhachHang(KhachHang kh);
        KhachHang GetKhachHang(string sdt);
    }
}
