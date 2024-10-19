using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lab05.DAL.NewFolder3
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<ChiTietDichVu> ChiTietDichVus { get; set; }
        public virtual DbSet<ChiTietDonDep> ChiTietDonDeps { get; set; }
        public virtual DbSet<ChiTietSuaChua> ChiTietSuaChuas { get; set; }
        public virtual DbSet<CoSoVatChatPhong> CoSoVatChatPhongs { get; set; }
        public virtual DbSet<DacTrungPhong> DacTrungPhongs { get; set; }
        public virtual DbSet<DatPhong> DatPhongs { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiDichVu> LoaiDichVus { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<PhongDangThue> PhongDangThues { get; set; }
        public virtual DbSet<PhongHetHan> PhongHetHans { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TienNghiPhong> TienNghiPhongs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoSoVatChatPhong>()
                .HasMany(e => e.LoaiPhongs)
                .WithMany(e => e.CoSoVatChatPhongs)
                .Map(m => m.ToTable("ChiTietCoSoVatChat").MapLeftKey("MaCoSoVatChat").MapRightKey("MaLoaiPhong"));

            modelBuilder.Entity<DacTrungPhong>()
                .HasMany(e => e.LoaiPhongs)
                .WithMany(e => e.DacTrungPhongs)
                .Map(m => m.ToTable("ChiTietDacTrung").MapLeftKey("MaDacTrungPhong").MapRightKey("MaLoaiPhong"));

            modelBuilder.Entity<DichVu>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.ChiTietDichVus)
                .WithRequired(e => e.DichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.DienTichPhong)
                .HasPrecision(10, 2);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.HinhAnh)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.GiaPhong)
                .HasPrecision(10, 2);

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.TienNghiPhongs)
                .WithMany(e => e.LoaiPhongs)
                .Map(m => m.ToTable("ChiTietTienNghi").MapLeftKey("MaLoaiPhong").MapRightKey("MaTienNghi"));

            modelBuilder.Entity<PhongHetHan>()
                .Property(e => e.TraTruoc)
                .HasPrecision(18, 0);
        }
    }
}
