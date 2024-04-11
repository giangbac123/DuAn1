using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface INguoidungRepos
    {
        bool Add(string id, string sdt, Nguoidung ng);
        bool Delete(string id);
        bool Update(string id, Nguoidung ng);
        List<Nguoidung> GetAll();
        List<Nguoidung> GetById(string sreachtext);
        bool Login (string username, string password, bool chucdanh);
        bool ChangePass(string username, string password, string newpass);
        bool ForgetPass(string email, string newpass);
    }
}
