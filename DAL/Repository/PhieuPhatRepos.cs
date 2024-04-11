using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class PhieuPhatRepos : IPhieuPhatRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public PhieuPhatRepos() { }

        public PhieuPhatRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add(PhieutractXuphat phat)
        {
            _context.PhieutractXuphats.Add(phat);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var a = _context.PhieutractXuphats.FirstOrDefault(x => x.MatractXp == id);
            if(a != null)
            {
                _context.PhieutractXuphats.Remove(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<PhieutractXuphat> GetAll()
        {
            return _context.PhieutractXuphats.ToList();
        }

        public List<PhieutractXuphat> GetById(int id)
        {
            return _context.PhieutractXuphats.Where(x=>x.MatractXp==id).ToList();
        }

        public bool Update(int id, PhieutractXuphat phat)
        {
            var a = _context.PhieutractXuphats.FirstOrDefault(x => x.MatractXp == id);
            if (a != null)
            {
                a.Soluong = phat.Soluong;
                a.Masach = phat.Masach;
                a.Tienphat = a.Tienphat;
                a.Ghichu=phat.Ghichu;
                _context.PhieutractXuphats.Update(a);
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
