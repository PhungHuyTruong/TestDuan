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
        public class ChucNangNhanVien : IChucNangNhanVien
        {
            private readonly IQuanLyNhanVien _context;
            public ChucNangNhanVien(IQuanLyNhanVien context)
            {
                _context = context;
            }

            public void CreateNhanVien(NhanVien nhanVien)
            {
                _context.Create(nhanVien);
            }

            public void DeleteNhanVien(int id)
            {
               _context.Delete(id);
            }

        public IEnumerable<NhanVien> FindNhanVien(string timkiem)
        {
            // Ensure no conflicting logic
            return _context.Find(nv => nv.Name.Contains(timkiem) || (nv.RoleId != null && nv.RoleId.Contains(timkiem)));
        }
        public IEnumerable<NhanVien> GetAllNhanVien()
            {
                return _context.GetAll();
            }

            public NhanVien GetNhanVienByID(int id)
            {
                return _context.GetById(id);
            }

            public void UpdateNhanVien(NhanVien nhanVien)
            {
                    _context.Update(nhanVien);
            }
            public bool KiemTraTrungData(NhanVien nhanvien)
            {
                var list = _context.GetAll();
                if(list.Any(nv => nv.Email.Equals(nhanvien.Email) || nv.PhoneNumber.Equals(nhanvien.PhoneNumber)))
                {
                    return false;
                }
                return true;
            }
        }
    }
