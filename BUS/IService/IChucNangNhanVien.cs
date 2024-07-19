using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IService
{    public interface IChucNangNhanVien
    {
        void CreateNhanVien(NhanVien nhanVien);
        NhanVien GetNhanVienByID(int id);
        IEnumerable<NhanVien> GetAllNhanVien();
        IEnumerable<NhanVien> FindNhanVien(string timkiem);

        void UpdateNhanVien(NhanVien nhanVien);
        void DeleteNhanVien(int id);
        bool KiemTraTrungData(NhanVien nhanvien);
    }
}
