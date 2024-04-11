using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public  class PhieuTraRepos : IPhieuTraRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public PhieuTraRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public PhieuTraRepos()
        {
            
        }

        public bool AddHoaDon(Phieutra pm)
        {
            _context.Phieutras.Add(pm);
            _context.SaveChanges();
            return true;
        }

        

        public bool DeleteHoaDon(string id)
        {
            var a = _context.Phieutras.FirstOrDefault(x => x.Matra == id);
            var b = _context.Phieutracts.FirstOrDefault(x => x.Matra == id);
            var c = _context.PhieutractXuphats.FirstOrDefault(x => x.Matra == id);
            if (a != null)
            {
                _context.Phieutras.Remove(a);
                _context.SaveChanges();
                return true;
            }
            if (b != null)
            {
                _context.Phieutracts.RemoveRange(b);
                _context.SaveChanges();
                return true;
            }
            if (c != null)
            {
                _context.PhieutractXuphats.RemoveRange(c);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Phieutra> GetAllPhieutra()
        {
            return _context.Phieutras.ToList();
        }

        public List<Phieutra> GetByIDPhieutra(string id)
        {
            return _context.Phieutras.Where(x=>x.Matra.StartsWith(id)).ToList();
        }


        public bool UpdateHoaDon(string id, Phieutra ct)
        {
            var a = _context.Phieutras.FirstOrDefault(x => x.Matra == id);
            if (a != null)
            {
                a.Tenkh = ct.Tenkh;
                a.Cccd = ct.Cccd;
                _context.Phieutras.Update(a);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
