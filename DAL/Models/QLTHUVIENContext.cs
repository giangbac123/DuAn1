using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class QLTHUVIENContext : DbContext
    {
        public QLTHUVIENContext()
        {
        }

        public QLTHUVIENContext(DbContextOptions<QLTHUVIENContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Nguoidung> Nguoidungs { get; set; } = null!;
        public virtual DbSet<Nhaxuatban> Nhaxuatbans { get; set; } = null!;
        public virtual DbSet<Phieumuon> Phieumuons { get; set; } = null!;
        public virtual DbSet<Phieumuonct> Phieumuoncts { get; set; } = null!;
        public virtual DbSet<Phieutra> Phieutras { get; set; } = null!;
        public virtual DbSet<Phieutract> Phieutracts { get; set; } = null!;
        public virtual DbSet<PhieutractXuphat> PhieutractXuphats { get; set; } = null!;
        public virtual DbSet<Sach> Saches { get; set; } = null!;
        public virtual DbSet<Sachct> Sachcts { get; set; } = null!;
        public virtual DbSet<Tacgium> Tacgia { get; set; } = null!;
        public virtual DbSet<Theloai> Theloais { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=HOANGTHANHGIANG\\SQLEXPRESS;Initial Catalog=QLTHUVIEN;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nguoidung>(entity =>
            {
                entity.HasKey(e => e.Mand)
                    .HasName("PK__NGUOIDUN__603F51062412A90A");

                entity.ToTable("NGUOIDUNG");

                entity.Property(e => e.Mand)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAND");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CCCD");

                entity.Property(e => e.Chucdanh).HasColumnName("CHUCDANH");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(255)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Gioitinh).HasColumnName("GIOITINH");

                entity.Property(e => e.Hoten)
                    .HasMaxLength(50)
                    .HasColumnName("HOTEN");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MATKHAU");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("NGAYSINH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");
            });

            modelBuilder.Entity<Nhaxuatban>(entity =>
            {
                entity.HasKey(e => e.Manxb)
                    .HasName("PK__NHAXUATB__7ABD9EF24FDE2CB3");

                entity.ToTable("NHAXUATBAN");

                entity.Property(e => e.Manxb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANXB");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(255)
                    .HasColumnName("DIACHI");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SDT");

                entity.Property(e => e.Tennxb)
                    .HasMaxLength(50)
                    .HasColumnName("TENNXB");
            });

            modelBuilder.Entity<Phieumuon>(entity =>
            {
                entity.HasKey(e => e.Mamuon)
                    .HasName("PK__PHIEUMUO__5065699E831D17B1");

                entity.ToTable("PHIEUMUON");

                entity.Property(e => e.Mamuon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAMUON");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CCCD");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(50)
                    .HasColumnName("TENKH");

                entity.Property(e => e.Trangthai)
                    .HasMaxLength(50)
                    .HasColumnName("TRANGTHAI");
            });

            modelBuilder.Entity<Phieumuonct>(entity =>
            {
                entity.HasKey(e => e.Mamuonct)
                    .HasName("PK__PHIEUMUO__5102A9AD9B4CF927");

                entity.ToTable("PHIEUMUONCT");

                entity.Property(e => e.Mamuonct).HasColumnName("MAMUONCT");

                entity.Property(e => e.Mamuon)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MAMUON");

                entity.Property(e => e.Masach)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASACH");

                entity.Property(e => e.Ngaymuon)
                    .HasColumnType("date")
                    .HasColumnName("NGAYMUON");

                entity.Property(e => e.Ngaytra)
                    .HasColumnType("date")
                    .HasColumnName("NGAYTRA");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tiencoc)
                    .HasColumnType("money")
                    .HasColumnName("TIENCOC");

                entity.HasOne(d => d.MamuonNavigation)
                    .WithMany(p => p.Phieumuoncts)
                    .HasForeignKey(d => d.Mamuon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHIEUMUON__MAMUO__35BCFE0A");

                entity.HasOne(d => d.MasachNavigation)
                    .WithMany(p => p.Phieumuoncts)
                    .HasForeignKey(d => d.Masach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHIEUMUON__MASAC__36B12243");
            });

            modelBuilder.Entity<Phieutra>(entity =>
            {
                entity.HasKey(e => e.Matra)
                    .HasName("PK__PHIEUTRA__58240C494ED75354");

                entity.ToTable("PHIEUTRA");

                entity.Property(e => e.Matra)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATRA");

                entity.Property(e => e.Cccd)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("CCCD");

                entity.Property(e => e.Tenkh)
                    .HasMaxLength(50)
                    .HasColumnName("TENKH");
            });

            modelBuilder.Entity<Phieutract>(entity =>
            {
                entity.HasKey(e => e.Matract)
                    .HasName("PK__PHIEUTRA__D503DBE761B8523D");

                entity.ToTable("PHIEUTRACT");

                entity.Property(e => e.Matract).HasColumnName("MATRACT");

                entity.Property(e => e.Masach)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASACH");

                entity.Property(e => e.Matra)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATRA");

                entity.Property(e => e.Ngaymuon)
                    .HasColumnType("date")
                    .HasColumnName("NGAYMUON");

                entity.Property(e => e.Ngaytra)
                    .HasColumnType("date")
                    .HasColumnName("NGAYTRA");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tiencoc)
                    .HasColumnType("money")
                    .HasColumnName("TIENCOC");

                entity.Property(e => e.Trangthai)
                    .HasMaxLength(50)
                    .HasColumnName("TRANGTHAI");

                entity.HasOne(d => d.MasachNavigation)
                    .WithMany(p => p.Phieutracts)
                    .HasForeignKey(d => d.Masach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHIEUTRAC__MASAC__3C69FB99");

                entity.HasOne(d => d.MatraNavigation)
                    .WithMany(p => p.Phieutracts)
                    .HasForeignKey(d => d.Matra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHIEUTRAC__MATRA__3B75D760");
            });

            modelBuilder.Entity<PhieutractXuphat>(entity =>
            {
                entity.HasKey(e => e.MatractXp)
                    .HasName("PK__PHIEUTRA__57E68E8245F0C5A1");

                entity.ToTable("PHIEUTRACT_XUPHAT");

                entity.Property(e => e.MatractXp).HasColumnName("MATRACT_XP");

                entity.Property(e => e.Ghichu)
                    .HasMaxLength(255)
                    .HasColumnName("GHICHU");

                entity.Property(e => e.Matra)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATRA");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Tienphat).HasColumnName("TIENPHAT");

                entity.HasOne(d => d.MatraNavigation)
                    .WithMany(p => p.PhieutractXuphats)
                    .HasForeignKey(d => d.Matra)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PHIEUTRAC__MATRA__3F466844");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.Masach)
                    .HasName("PK__SACH__3FC48E4C33349C06");

                entity.ToTable("SACH");

                entity.Property(e => e.Masach)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASACH");

                entity.Property(e => e.Giaban)
                    .HasColumnType("money")
                    .HasColumnName("GIABAN");

                entity.Property(e => e.Ngayxb)
                    .HasColumnType("date")
                    .HasColumnName("NGAYXB");

                entity.Property(e => e.Soluong).HasColumnName("SOLUONG");

                entity.Property(e => e.Sotrang).HasColumnName("SOTRANG");

                entity.Property(e => e.Tensach)
                    .HasMaxLength(50)
                    .HasColumnName("TENSACH");

                entity.Property(e => e.Trangthai)
                    .HasMaxLength(50)
                    .HasColumnName("TRANGTHAI");
            });

            modelBuilder.Entity<Sachct>(entity =>
            {
                entity.HasKey(e => e.Masachct)
                    .HasName("PK__SACHCT__EAD06DB8636A49E2");

                entity.ToTable("SACHCT");

                entity.Property(e => e.Masachct).HasColumnName("MASACHCT");

                entity.Property(e => e.Manxb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANXB");

                entity.Property(e => e.Masach)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MASACH");

                entity.Property(e => e.Matg)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATG");

                entity.Property(e => e.Matl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATL");

                entity.HasOne(d => d.ManxbNavigation)
                    .WithMany(p => p.Sachcts)
                    .HasForeignKey(d => d.Manxb)
                    .HasConstraintName("FK__SACHCT__MANXB__30F848ED");

                entity.HasOne(d => d.MasachNavigation)
                    .WithMany(p => p.Sachcts)
                    .HasForeignKey(d => d.Masach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SACHCT__MASACH__2E1BDC42");

                entity.HasOne(d => d.MatgNavigation)
                    .WithMany(p => p.Sachcts)
                    .HasForeignKey(d => d.Matg)
                    .HasConstraintName("FK__SACHCT__MATG__2F10007B");

                entity.HasOne(d => d.MatlNavigation)
                    .WithMany(p => p.Sachcts)
                    .HasForeignKey(d => d.Matl)
                    .HasConstraintName("FK__SACHCT__MATL__300424B4");
            });

            modelBuilder.Entity<Tacgium>(entity =>
            {
                entity.HasKey(e => e.Matg)
                    .HasName("PK__TACGIA__6023721A7B906115");

                entity.ToTable("TACGIA");

                entity.Property(e => e.Matg)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATG");

                entity.Property(e => e.Tentg)
                    .HasMaxLength(50)
                    .HasColumnName("TENTG");
            });

            modelBuilder.Entity<Theloai>(entity =>
            {
                entity.HasKey(e => e.Matl)
                    .HasName("PK__THELOAI__602372179B11D963");

                entity.ToTable("THELOAI");

                entity.Property(e => e.Matl)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MATL");

                entity.Property(e => e.Tentl)
                    .HasMaxLength(50)
                    .HasColumnName("TENTL");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
