using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class TacGiaRepos : ITacGiaRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();

        public TacGiaRepos() { }
        public TacGiaRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add(string id, Tacgium tg)
        {
            var a = _context.Tacgia.FirstOrDefault(x => x.Matg == id);
            if(a == null)
            {
                _context.Tacgia.Add(tg);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(string id)
        {
            var b = _context.Sachcts.FirstOrDefault(s => s.Manxb == id);
            var a = _context.Tacgia.FirstOrDefault(x => x.Matg == id);
            if (a != null)
            {
                _context.Sachcts.RemoveRange(b);
                _context.Tacgia.Remove(a);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Tacgium> GetAll()
        {
            return _context.Tacgia.ToList();
        }

        public List<Tacgium> GetById(string text)
        {
            return _context.Tacgia.Where(x=>x.Tentg.StartsWith(text) || x.Matg.StartsWith(text)).ToList();
        }

        public bool Update(string id, Tacgium tg)
        {
            var a = _context.Tacgia.FirstOrDefault(x => x.Matg == id);
            if (a != null)
            {
                a.Tentg = tg.Tentg;
                _context.Tacgia.Update(a);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
