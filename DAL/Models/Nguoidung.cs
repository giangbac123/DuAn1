using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Nguoidung
    {
        public string Mand { get; set; } = null!;
        public string Hoten { get; set; } = null!;
        public bool Gioitinh { get; set; }
        public string Diachi { get; set; } = null!;
        public DateTime Ngaysinh { get; set; }
        public string Sdt { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Cccd { get; set; } = null!;
        public string Matkhau { get; set; } = null!;
        public bool Chucdanh { get; set; }
    }
}
