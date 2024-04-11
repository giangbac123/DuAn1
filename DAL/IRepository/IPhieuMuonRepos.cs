using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface IPhieuMuonRepos
    {
        public bool AddHoaDon(Phieumuon pm);

        public bool DeleteHoaDon(string id);

        public bool UpdateHoaDon(string id, Phieumuon ct);
        public List<Phieumuon> GetAllPhieumuon();
        List<Phieumuon> GetByIDPhieumuon(string id);
    }
}
