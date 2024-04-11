using DAL.Models;
using DAL.View;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface ISachRepos
    {
        bool Add(string id,Sach sach);
        bool Update(string id,Sach sach);
        bool Delete(string id);
        List<Sach> GetAll();
        List<Sach> GetBy(string text);
        List<SachThongKe> ThongKe();
    }
}
