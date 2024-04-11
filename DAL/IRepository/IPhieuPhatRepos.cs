using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface IPhieuPhatRepos
    {
        bool Add(PhieutractXuphat phat);
        bool Update(int id, PhieutractXuphat phat);
        bool Delete(int id);
        List<PhieutractXuphat> GetAll();
        List<PhieutractXuphat> GetById(int id);
    }
}
