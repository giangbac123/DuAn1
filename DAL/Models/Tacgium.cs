using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Tacgium
    {
        public Tacgium()
        {
            Sachcts = new HashSet<Sachct>();
        }

        public string Matg { get; set; } = null!;
        public string Tentg { get; set; } = null!;

        public virtual ICollection<Sachct> Sachcts { get; set; }
    }
}
