using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TieuLuanQuanNet.Database
{
    public partial class CoSoDuLieuTiemNet : DbContext
    {
        public CoSoDuLieuTiemNet()
            : base("name=CoSoDuLieuTiemNet8")
        {
        }

        public virtual DbSet<CauHinhMayTinh> CauHinhMayTinhs { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<DanhSachMayTram> DanhSachMayTrams { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CauHinhMayTinh>()
                .Property(e => e.CauHinh)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachMayTram>()
                .Property(e => e.TenMay)
                .IsUnicode(false);

            modelBuilder.Entity<DanhSachMayTram>()
                .Property(e => e.CauHinh)
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.Ten)
                .IsUnicode(false);

            modelBuilder.Entity<DichVu>()
                .Property(e => e.DonViTinh)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.HoTen)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ChucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);
        }
    }
}
