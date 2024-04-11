using DAL.IRepository;
using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class NguoidungRepos : INguoidungRepos
    {
        QLTHUVIENContext _context = new QLTHUVIENContext();
        public NguoidungRepos() { }
        public NguoidungRepos(QLTHUVIENContext context)
        {
            _context = context;
        }

        public bool Add(string id, string sdt, Nguoidung ng)
        {
            var a = _context.Nguoidungs.FirstOrDefault(x => x.Mand == id && x.Sdt==sdt);
            if (a == null)
            {
                _context.Nguoidungs.Add(ng);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ChangePass(string username, string password, string newpass)
        {
            var a = _context.Nguoidungs.FirstOrDefault(x => x.Mand == username && x.Matkhau == password);
            if (a != null)
            {
                a.Matkhau = newpass;
                _context.Nguoidungs.Update(a);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(string id)
        {
            var a = _context.Nguoidungs.FirstOrDefault(x => x.Mand== id);
            if (a != null)
            {
                _context.Nguoidungs.Remove(a);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool ForgetPass(string email, string newpass)
        {
            var a = _context.Nguoidungs.FirstOrDefault(x => x.Email == email);
            if (a != null)
            {
                a.Matkhau = newpass;
                _context.Nguoidungs.Update(a);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Nguoidung> GetAll()
        {
            return _context.Nguoidungs.ToList();
        }

        public List<Nguoidung> GetById(string sreachtext)
        {
            return _context.Nguoidungs.Where(x => x.Mand.StartsWith(sreachtext)||x.Hoten.StartsWith(sreachtext) || x.Sdt.StartsWith(sreachtext)).ToList();
        }

        public bool Login(string username, string password, bool chucdanh)
        {
            var a = _context.Nguoidungs.FirstOrDefault(x=>(x.Mand==username||x.Email==username)&&x.Matkhau==password&&x.Chucdanh==chucdanh);
            if(a != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(string id, Nguoidung ng)
        {
            var a = _context.Nguoidungs.FirstOrDefault(x => x.Mand == id);
            if (a != null)
            {
                a.Hoten = ng.Hoten;
                a.Gioitinh = ng.Gioitinh;
                a.Diachi=ng.Diachi;
                a.Email= ng.Email;
                a.Cccd=ng.Cccd;
                a.Sdt = ng.Sdt;
                a.Chucdanh=ng.Chucdanh;
                _context.Nguoidungs.Update(a);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
