using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface IPhieuTraCTRepos
    {
        bool AddHoaDonCT(Phieutract ct);
        bool DeleteCT(int id);
        bool UpdateCT(int id, Phieutract ct);
        List<Phieutract> GetByPhieutraCT(string id);
        List<Phieutract> GetAll();
    }
}
