using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface IPhieuTraRepos
    {
        bool AddHoaDon(Phieutra pm);
        bool DeleteHoaDon(string id);
        bool UpdateHoaDon(string id, Phieutra ct);
        List<Phieutra> GetAllPhieutra();
        List<Phieutra> GetByIDPhieutra(string id);
    }
}
