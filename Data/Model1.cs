using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace App_QL_kho.Data
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CT_PhieuNhap> CT_PhieuNhap { get; set; }
        public virtual DbSet<CT_PhieuXuat> CT_PhieuXuat { get; set; }
        public virtual DbSet<LichSuNhapXuat> LichSuNhapXuats { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<NhomSanPham> NhomSanPhams { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TonKho> TonKhoes { get; set; }
        public virtual DbSet<VaiTro> VaiTroes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.VaiTroes)
                .WithMany(e => e.NguoiDungs)
                .Map(m => m.ToTable("NguoiDung_VaiTro").MapLeftKey("MaND").MapRightKey("MaVaiTro"));

            modelBuilder.Entity<NhomSanPham>()
                .HasMany(e => e.SanPhams)
                .WithRequired(e => e.NhomSanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhap>()
                .HasMany(e => e.CT_PhieuNhap)
                .WithRequired(e => e.PhieuNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuXuat>()
                .HasMany(e => e.CT_PhieuXuat)
                .WithRequired(e => e.PhieuXuat)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.CT_PhieuNhap)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.CT_PhieuXuat)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.LichSuNhapXuats)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SanPham>()
                .HasOptional(e => e.TonKho)
                .WithRequired(e => e.SanPham);
        }
    }
}
