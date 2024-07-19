using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepo
{
    public interface IQuanLyNhanVien
    {
        void Create(NhanVien nhanVien);
        NhanVien GetById(int id);
        IEnumerable<NhanVien> GetAll();
        IEnumerable<NhanVien> Find(Func<NhanVien, bool> predicate);
        void Update(NhanVien nhanVien);
        void Delete(int id);

    }
}
