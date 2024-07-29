using BUS.IService;
using DAL.IRepo;
using DAL.Models;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Service
{
    public class ChucNangGiaoDich : IChucNangGiaoDich
    {
        private readonly IQuanLyGiaoDich _repo;
        public ChucNangGiaoDich(IQuanLyGiaoDich repo)
        {
            _repo = repo;
        }

        public async Task<CheckResult> AddChiTietGioHang(int idgiohang, int idsanpham)
        {
            if (idsanpham <= 0 ) { return CheckResult.KoTimThaySP; }
            if (idgiohang <= 0 ) { return CheckResult.KoTimThayGH; }
            var adchitiet = await _repo.AddChiTietGioHang(idgiohang, idsanpham);
            switch (adchitiet)
            {
                case CheckResult.KoDuSoLuong:
                    return CheckResult.KoDuSoLuong;
                case CheckResult.ThanhCong:
                    return CheckResult.ThanhCong;
                case CheckResult.KoThanhCong:
                    return CheckResult.KoThanhCong;
                default:
                    return CheckResult.ThanhCong;
            }
        }

        public GioHang AddGioHang()
        {
            return  _repo.AddGioHang();
        }

        public async Task<List<GioHangChiTiet>> AllChiTietTrongXe(int idgiohang)
        {
            try
            {
                var list = await _repo.AllChiTietTrongXe(idgiohang);
                if (list == null)
                {
                    return new List<GioHangChiTiet>();
                }
                return list;
            }
            catch (Exception)
            {

                return new List<GioHangChiTiet>();
            }
        }

        public async Task<IEnumerable<GioHang>> AllGioHangCho()
        {
            try
            {
                var list = await _repo.AllGioHangCho();
                if(list == null)
                {
                    return new List<GioHang>();
                }
                return list;
            }
            catch (Exception)
            {
                return new List<GioHang>();
            }
        }

        public async Task<IEnumerable<SanPham>> AllSanPham()
        {
            try
            {
                var list = await _repo.AllSanPham();
                if (list == null)
                {
                    return new List<SanPham>();
                }
                return list;
            }
            catch (Exception)
            {
                return new List<SanPham>();
            }
        }

        public async Task<bool> DeleteChiTiet(int chitiet)
        {
           if (chitiet == 0)
            {
                return false;
            }
            if (await _repo.DeleteChiTiet(chitiet))
            {
                return true;
            }
            return false;   
        }


        public async Task<CheckResult> ThanhToan(int idgiohang, int userid, decimal tien, bool phuongthuc, int idkhachhang)
        {
            if (idgiohang <= 0) { return CheckResult.KoTimThayGH; } 
            if (userid <= 0) { return CheckResult.KoTimThayUser; }

            var result = await _repo.ThanhToan(idgiohang, userid, tien, phuongthuc, idkhachhang);
            switch (result)
            {
                case CheckResult.KoTimThayGH:
                    return CheckResult.KoTimThayGH;

                case CheckResult.ThieuTien:
                    return CheckResult.ThieuTien;

                case CheckResult.ThanhCong:
                    return CheckResult.ThanhCong;

                case CheckResult.KoThanhCong:
                    return CheckResult.KoThanhCong;

                default:
                    return CheckResult.KoThanhCong;
            }

        }

        public async Task<CheckResult> UpdateChiTiet(int chitiet, int idsp, int soluong)
        {
            var result = await _repo.UpdateChiTiet(chitiet, idsp, soluong);
            switch (result)
            {
                case CheckResult.ThanhCong:
                    return CheckResult.ThanhCong;
                case CheckResult.KoThanhCong:
                    return CheckResult.KoThanhCong;
                case CheckResult.KoTimThayChiTiet:
                    return CheckResult.KoTimThayChiTiet;
                case CheckResult.KoTimThaySP:
                    return CheckResult.KoTimThaySP;
                case CheckResult.KoDuSoLuong:
                    return CheckResult.KoDuSoLuong;
                default:
                    return CheckResult.KoThanhCong;

            }
        }

        public async Task UpdateGioHang(int giohang, bool trangthai)
        {
            await _repo.UpdateGioHang(giohang, trangthai);
        }

        public async Task XoaGioHang(int idgiohang)
        {
            await _repo.XoaGioHang(idgiohang);
        }
    }
}
