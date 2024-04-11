using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Sachct
    {
        public int Masachct { get; set; }
        public string Masach { get; set; } = null!;
        public string? Matg { get; set; }
        public string? Matl { get; set; }
        public string? Manxb { get; set; }

        public virtual Nhaxuatban? ManxbNavigation { get; set; }
        public virtual Sach MasachNavigation { get; set; } = null!;
        public virtual Tacgium? MatgNavigation { get; set; }
        public virtual Theloai? MatlNavigation { get; set; }
    }
}
