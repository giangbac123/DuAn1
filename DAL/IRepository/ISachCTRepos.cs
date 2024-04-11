using DAL.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface ISachCTRepos
    {
        bool Add(Sachct ct);
        bool Delete(int id);
        bool Update(int id, Sachct ct);
        List<Sachct> Get(string id);
    }
}
