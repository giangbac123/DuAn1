using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Sach
    {
        public Sach()
        {
            Phieumuoncts = new HashSet<Phieumuonct>();
            Phieutracts = new HashSet<Phieutract>();
            Sachcts = new HashSet<Sachct>();
        }

        public string Masach { get; set; } = null!;
        public string Tensach { get; set; } = null!;
        public int Soluong { get; set; }
        public DateTime? Ngayxb { get; set; }
        public int? Sotrang { get; set; }
        public decimal Giaban { get; set; }
        public string? Trangthai { get; set; }

        public virtual ICollection<Phieumuonct> Phieumuoncts { get; set; }
        public virtual ICollection<Phieutract> Phieutracts { get; set; }
        public virtual ICollection<Sachct> Sachcts { get; set; }
    }
}
