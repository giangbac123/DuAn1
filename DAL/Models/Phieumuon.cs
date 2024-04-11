using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Phieumuon
    {
        public Phieumuon()
        {
            Phieumuoncts = new HashSet<Phieumuonct>();
        }

        public string Mamuon { get; set; } = null!;
        public string Tenkh { get; set; } = null!;
        public string? Cccd { get; set; }
        public string? Trangthai { get; set; }

        public virtual ICollection<Phieumuonct> Phieumuoncts { get; set; }
    }
}
