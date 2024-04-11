using DAL.IRepository;
using DAL.Models;
using DAL.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class SachRepos : ISachRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public SachRepos(QLTHUVIENContext context)
        {
            this._context = context;
        }
        public SachRepos()
        {

        }

        public bool Add(string id, Sach sach)
        {
            var a = _context.Saches.FirstOrDefault(x => x.Masach == id);
            if(a == null)
            {
                _context.Saches.Add(sach);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            var c = _context.Phieumuoncts.FirstOrDefault(x => x.Masach == id);
            var d = _context.Phieutracts.FirstOrDefault(x => x.Masach == id);
            var a = _context.Saches.FirstOrDefault(x => x.Masach == id);
            var b = _context.Sachcts.FirstOrDefault(y => y.Masach == id);
            if (a != null)
            {
                _context.Phieutracts.RemoveRange(d);
                _context.Phieumuoncts.RemoveRange(c);
                _context.Sachcts.RemoveRange(b);
                _context.Saches.Remove(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Sach> GetAll()
        {
            return _context.Saches.ToList();
        }

        public List<Sach> GetBy(string text)
        {
            return _context.Saches.Where(x=>x.Tensach.StartsWith(text) ||x.Masach.StartsWith(text)).ToList();
        }

        public bool Update(string id, Sach sach)
        {
            var a = _context.Saches.FirstOrDefault(x => x.Masach == id);
            if (a != null)
            {
                a.Tensach = sach.Tensach;
                a.Soluong = sach.Soluong;
                a.Ngayxb = sach.Ngayxb;
                a.Sotrang = sach.Sotrang;
                a.Giaban = sach.Giaban;
                a.Trangthai = sach.Trangthai;
                _context.Saches.Update(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            } 
        }

        public List<SachThongKe> ThongKe()
        {
            var thongKe = _context.Saches
                    .Select(s => new SachThongKe
                    {
                        MaSach = s.Masach,
                        TenSach = s.Tensach,
                        SoLuongTong = s.Soluong,
                        SoLuongDaMuon = _context.Phieumuoncts
                            .Where(pm => pm.Masach == s.Masach)
                            .Sum(pm => (int?)pm.Soluong) ?? 0
                    })
                    .Select(result => new SachThongKe
                    {
                        MaSach = result.MaSach,
                        TenSach = result.TenSach,
                        SoLuongTong = result.SoLuongTong,
                        SoLuongDaMuon = result.SoLuongDaMuon,
                        SoLuongConLai = result.SoLuongTong - result.SoLuongDaMuon
                    })
                    .ToList();

            return thongKe; 
        }
    }
}
