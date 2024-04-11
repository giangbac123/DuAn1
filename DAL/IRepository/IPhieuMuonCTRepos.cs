using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface IPhieuMuonCTRepos
    {
        public bool AddHoaDonCT(string id, Phieumuonct ct);


        public bool DeleteCT(int id);

        public bool UpdateCT(int id, Phieumuonct ct);

        public List<Phieumuonct> GetByPhieumuonCT(string id);
        public List<Phieumuonct> GetAll();
    }
}
