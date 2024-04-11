using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface ITheLoaiRepos
    {
        IEnumerable<Theloai> GetAllTheloai();
        bool Add(string id,Theloai theloai);
        bool Update(string id, Theloai theloai);
        bool Delete(string id);
        List<Theloai> GetSearch(string searchText);
    }
}
