using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface ITacGiaRepos
    {
        bool Add(string id, Tacgium tg);
        bool Update(string id, Tacgium tg);
        bool Delete(string id);
        List<Tacgium> GetAll();
        List<Tacgium> GetById(string text);
    }
}
