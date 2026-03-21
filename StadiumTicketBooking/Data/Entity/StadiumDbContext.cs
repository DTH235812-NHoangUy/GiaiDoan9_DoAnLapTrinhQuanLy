using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace StadiumTicketBooking.Data.Entity
{
    public class StadiumDbContext : DbContext
    {
        public DbSet<VaiTro> VaiTro { get; set; }
        public DbSet<SanVanDong> SanVanDong { get; set; }
        public DbSet<KhuVuc> KhuVuc { get; set; }
        public DbSet<Ghe> Ghe { get; set; }
        public DbSet<SuKien> SuKien { get; set; }
        public DbSet<Ve> Ve { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDon_ChiTiet> HoaDon_ChiTiet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connString = ConfigurationManager.ConnectionStrings["StadiumConnection"]?.ConnectionString;

                if (string.IsNullOrEmpty(connString))
                {
                    optionsBuilder.UseSqlServer(
                        @"Server=NGUYEN-HOANG-UY\SQLEXPRESS;Database=StadiumTicketBooking;Integrated Security=True;TrustServerCertificate=True");
                }
                else
                {
                    optionsBuilder.UseSqlServer(connString);
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ===== VE =====
            modelBuilder.Entity<Ve>()
                .HasOne(v => v.SuKien)
                .WithMany(sk => sk.Ve)
                .HasForeignKey(v => v.SuKienID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ve>()
                .HasOne(v => v.Ghe)
                .WithMany()
                .HasForeignKey(v => v.GheID)
                .OnDelete(DeleteBehavior.Restrict);

            // Mỗi ghế trong một sự kiện chỉ có một vé
            modelBuilder.Entity<Ve>()
                .HasIndex(v => new { v.SuKienID, v.GheID })
                .IsUnique();

            // ===== KHÁCH HÀNG =====
            modelBuilder.Entity<KhachHang>()
                .HasIndex(kh => kh.TenDangNhap)
                .IsUnique();

            // ===== HÓA ĐƠN =====
            modelBuilder.Entity<HoaDon>()
                .HasOne(hd => hd.KhachHang)
                .WithMany(kh => kh.HoaDon)
                .HasForeignKey(hd => hd.KhachHangID)
                .OnDelete(DeleteBehavior.Restrict);

            // NhanVienID cho phép null để hỗ trợ khách hàng tự đặt vé
            modelBuilder.Entity<HoaDon>()
                .HasOne(hd => hd.NhanVien)
                .WithMany(nv => nv.HoaDon)
                .HasForeignKey(hd => hd.NhanVienID)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            // ===== HÓA ĐƠN CHI TIẾT =====
            modelBuilder.Entity<HoaDon_ChiTiet>()
                .HasOne(ct => ct.Ve)
                .WithMany()
                .HasForeignKey(ct => ct.VeID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HoaDon_ChiTiet>()
                .HasOne(ct => ct.HoaDon)
                .WithMany(hd => hd.HoaDon_ChiTiet)
                .HasForeignKey(ct => ct.HoaDonID)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}