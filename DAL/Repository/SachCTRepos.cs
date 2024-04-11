using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class SachCTRepos: ISachCTRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public SachCTRepos() { }

        public SachCTRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add( Sachct ct)
        {
                _context.Sachcts.Add(ct);
                _context.SaveChanges();
                return true;
        }

        public bool Delete(int id)
        {
            var a = _context.Sachcts.FirstOrDefault(x => x.Masachct == id);
            if (a != null)
            {
                _context.Sachcts.Remove(a);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Sachct> Get(string id)
        {
            var join = _context.Sachcts;
            return join.Where(x=>x.Masach==id).ToList();
        }


        public bool Update(int id, Sachct ct)
        {
            var a = _context.Sachcts.FirstOrDefault(x => x.Masachct == id);
            if (a != null)
            {
                a.Matg = ct.Matg;
                a.Matl = ct.Matl;
                a.Manxb = ct.Manxb;
                _context.Sachcts.Update(a);
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
