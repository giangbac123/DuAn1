using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Phieumuonct
    {
        public int Mamuonct { get; set; }
        public string Mamuon { get; set; } = null!;
        public string Masach { get; set; } = null!;
        public int Soluong { get; set; }
        public DateTime Ngaymuon { get; set; }
        public DateTime Ngaytra { get; set; }
        public int Tienphi { get; set; }

        public virtual Phieumuon MamuonNavigation { get; set; } = null!;
        public virtual Sach MasachNavigation { get; set; } = null!;
    }
}
