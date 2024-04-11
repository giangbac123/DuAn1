using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class PhieutractXuphat
    {
        public int MatractXp { get; set; }
        public string Matra { get; set; } = null!;
        public string Masach { get; set; } = null!;
        public int Soluong { get; set; }
        public int? Tienphat { get; set; }
        public string? Ghichu { get; set; }

        public virtual Sach MasachNavigation { get; set; } = null!;
        public virtual Phieutra MatraNavigation { get; set; } = null!;
    }
}
