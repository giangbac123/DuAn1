using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Phieutract
    {
        public int Matract { get; set; }
        public string Matra { get; set; } = null!;
        public string Masach { get; set; } = null!;
        public int Soluong { get; set; }
        public decimal Tiencoc { get; set; }
        public string? Trangthai { get; set; }
        public DateTime Ngaymuon { get; set; }
        public DateTime Ngaytra { get; set; }

        public virtual Sach MasachNavigation { get; set; } = null!;
        public virtual Phieutra MatraNavigation { get; set; } = null!;
    }
}
