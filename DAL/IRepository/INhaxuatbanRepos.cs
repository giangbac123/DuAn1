using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface INhaxuatbanRepos
    {
        IEnumerable<Nhaxuatban> GetAll();
        bool Add(string id, Nhaxuatban tl);
        bool Update(string id, Nhaxuatban tl);
        bool Delete(string id);
        List<Nhaxuatban> GetSearch(string searchText);
    }
}
