using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Theloai
    {
        public Theloai()
        {
            Sachcts = new HashSet<Sachct>();
        }

        public string Matl { get; set; } = null!;
        public string Tentl { get; set; } = null!;

        public virtual ICollection<Sachct> Sachcts { get; set; }
    }
}
