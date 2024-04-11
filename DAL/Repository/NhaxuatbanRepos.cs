using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class NhaxuatbanRepos : INhaxuatbanRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public NhaxuatbanRepos() { }

        public NhaxuatbanRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add(string id, Nhaxuatban tl)
        {
            var a = _context.Nhaxuatbans.FirstOrDefault(s => s.Manxb == id);
            if (a == null)
            {
                _context.Nhaxuatbans.Add(tl);
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
            var b = _context.Sachcts.FirstOrDefault(s => s.Manxb == id);
            var a = _context.Nhaxuatbans.FirstOrDefault(s => s.Manxb == id);
            if (a != null)
            { 
                if(b!=null)
                {
                    _context.Sachcts.RemoveRange(b);
                    _context.Nhaxuatbans.Remove(a);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    _context.Nhaxuatbans.Remove(a);
                    _context.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Nhaxuatban> GetAll()
        {
            return _context.Nhaxuatbans.ToList();
        }

        public List<Nhaxuatban> GetSearch(string searchText)
        {
            return _context.Nhaxuatbans.Where(x=>x.Manxb.StartsWith(searchText) || x.Tennxb.StartsWith(searchText)).ToList();
        }

        public bool Update(string id, Nhaxuatban tl)
        {
            var a = _context.Nhaxuatbans.FirstOrDefault(s => s.Manxb == id);
            if (a != null)
            {
                a.Tennxb = tl.Tennxb;
                a.Diachi = tl.Diachi;
                a.Sdt = tl.Sdt;
                _context.Nhaxuatbans.Update(a);
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
