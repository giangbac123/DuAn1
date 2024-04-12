using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PhieuMuonCTRepos : IPhieuMuonCTRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public PhieuMuonCTRepos() { }

        public PhieuMuonCTRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool AddHoaDonCT(Phieumuonct ct)
        {
            _context.Phieumuoncts.Add(ct);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteCT(int id)
        {
            var a = _context.Phieumuoncts.FirstOrDefault(x => x.Mamuonct == id);
            if(a != null)
            {
                _context.Phieumuoncts.Remove(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Phieumuonct> GetAll()
        {
            return _context.Phieumuoncts.ToList();
        }

        public List<Phieumuonct> GetByPhieumuonCT(string id)
        {
            return _context.Phieumuoncts.Where(x=>x.Mamuon==id).ToList();
        }

        public bool UpdateCT(int id, Phieumuonct ct)
        {
            var a = _context.Phieumuoncts.FirstOrDefault(x => x.Mamuonct == id);
            if (a != null)
            {
                a.Masach = ct.Masach;
                a.Soluong = ct.Soluong;
                a.Ngaymuon = ct.Ngaymuon;
                a.Ngaytra = ct.Ngaytra;
                a.Tienphi = ct.Tienphi;
                _context.Phieumuoncts.Update(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
