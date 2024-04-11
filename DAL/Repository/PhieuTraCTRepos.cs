using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PhieuTraCTRepos : IPhieuTraCTRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public PhieuTraCTRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public PhieuTraCTRepos()
        {

        }

        public bool AddHoaDonCT(Phieutract pm)
        {
            _context.Phieutracts.Add(pm);
            _context.SaveChanges();
            return true;
        }



        public bool DeleteCT(int id)
        {
            var b = _context.Phieutracts.FirstOrDefault(x => x.Matract == id);
            if(b!=null)
            {
                _context.Phieutracts.RemoveRange(b);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Phieutract> GetAll()
        {
            return _context.Phieutracts.ToList();
        }

        public List<Phieutract> GetByPhieutraCT(string id)
        {
            return _context.Phieutracts.Where(x => x.Matra==(id)).ToList();
        }


        public bool UpdateCT(int id, Phieutract ct)
        {
            var a = _context.Phieutracts.FirstOrDefault(x => x.Matract == id);
            if (a != null)
            {
                a.Masach = ct.Masach;
                a.Soluong = ct.Soluong;
                a.Trangthai = ct.Trangthai;
                a.Ngaymuon = a.Ngaymuon;
                a.Ngaytra = a.Ngaytra;
                _context.Phieutracts.Update(a);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
