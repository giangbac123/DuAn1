using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class TheLoaiRepos : ITheLoaiRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext(); 
        public TheLoaiRepos() { }

        public TheLoaiRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add(string id, Theloai theloai)
        {
            var a = _context.Theloais.FirstOrDefault(s => s.Matl == id);
            if(a == null)
            {
                _context.Theloais.Add(theloai);
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
            var a = _context.Theloais.FirstOrDefault(s => s.Matl == id);
            if (a != null)
            {
                if(b != null)
                {
                    _context.Sachcts.RemoveRange(b);
                    _context.Theloais.Remove(a);
                    _context.SaveChanges();
                    return true;
                }
                else
                {
                    _context.Theloais.Remove(a);
                    _context.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Theloai> GetAllTheloai()
        {
            return _context.Theloais.ToList();
        }

        public List<Theloai> GetSearch(string searchText)
        {
            return _context.Theloais.Where(x=>x.Matl.StartsWith(searchText) ||x.Tentl==(searchText)).ToList();
        }

        public bool Update(string id, Theloai theloai)
        {
            var a = _context.Theloais.FirstOrDefault(s => s.Matl == id);
            if (a != null)
            {
                a.Tentl=theloai.Tentl;
                _context.Theloais.Update(a);
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
