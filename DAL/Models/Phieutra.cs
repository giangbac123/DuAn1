using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Phieutra
    {
        public Phieutra()
        {
            PhieutractXuphats = new HashSet<PhieutractXuphat>();
            Phieutracts = new HashSet<Phieutract>();
        }

        public string Matra { get; set; } = null!;
        public string Tenkh { get; set; } = null!;
        public string? Cccd { get; set; }

        public virtual ICollection<PhieutractXuphat> PhieutractXuphats { get; set; }
        public virtual ICollection<Phieutract> Phieutracts { get; set; }
    }
}
