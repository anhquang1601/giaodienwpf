using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WpfApp1.Database
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Ban> Bans { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<NhomMon> NhomMons { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ThucDon> ThucDons { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>()
                .Property(e => e.MaBan)
                .IsFixedLength();

            modelBuilder.Entity<Ban>()
                .Property(e => e.TenBan)
                .IsFixedLength();

            modelBuilder.Entity<Ban>()
                .Property(e => e.TrangThai)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaChiTietHD)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(e => e.MaMon)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaBan)
                .IsFixedLength();

            modelBuilder.Entity<NhomMon>()
                .Property(e => e.MaLoai)
                .IsFixedLength();

            modelBuilder.Entity<ThucDon>()
                .Property(e => e.MaMon)
                .IsFixedLength();

            modelBuilder.Entity<ThucDon>()
                .Property(e => e.MaLoai)
                .IsFixedLength();
        }
    }
}
