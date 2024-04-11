using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Nhaxuatban
    {
        public Nhaxuatban()
        {
            Sachcts = new HashSet<Sachct>();
        }

        public string Manxb { get; set; } = null!;
        public string Tennxb { get; set; } = null!;
        public string Diachi { get; set; } = null!;
        public string Sdt { get; set; } = null!;

        public virtual ICollection<Sachct> Sachcts { get; set; }
    }
}
