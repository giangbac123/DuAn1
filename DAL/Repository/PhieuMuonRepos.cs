using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PhieuMuonRepos : IPhieuMuonRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public PhieuMuonRepos()
        {

        }

        public PhieuMuonRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool AddHoaDon(Phieumuon pm)
        {
            _context.Phieumuons.Add(pm);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteHoaDon(string id)
        {
            var a = _context.Phieumuons.FirstOrDefault(x=>x.Mamuon==id);
            var b = _context.Phieumuoncts.FirstOrDefault(x => x.Mamuon == id);
            if (a!=null)
            {
                if (b == null)
                {
                    _context.Phieumuons.Remove(a);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    _context.Phieumuoncts.RemoveRange(b);
                    _context.Phieumuons.Remove(a);
                    _context.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public List<Phieumuon> GetAllPhieumuon()
        {
            return _context.Phieumuons.ToList();
        }

        public List<Phieumuon> GetByIDPhieumuon(string id)
        {
            return _context.Phieumuons.Where(x=>x.Mamuon==id).ToList();
        }

        public bool UpdateHoaDon(string id, Phieumuon ct)
        {
            var a = _context.Phieumuons.FirstOrDefault(x => x.Mamuon == id);
            if (a != null)
            {
                a.Tenkh = ct.Tenkh;
                a.Cccd = ct.Cccd;
                a.Trangthai = ct.Trangthai;
                _context.Phieumuons.Update(a);
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
