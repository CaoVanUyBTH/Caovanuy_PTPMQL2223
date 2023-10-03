using Microsoft.EntityFrameworkCore;
using BTLN1.Models;

namespace BTLN1.Data
{
   public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Account> Account { get; set; }
        public DbSet<AccountViTri> AccountViTri { get; set; }
        public DbSet<Ceo> Ceo { get; set; }
        public DbSet<CeoViTri> CeoViTri { get; set; }
        public DbSet<CongNhan> CongNhan { get; set; }
        public DbSet<HopDong> HopDong { get; set; }
        public DbSet<Luong> Luong { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<SaleViTri> SaleViTri { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<StaffViTri> StaffViTri { get; set; }
        
    }
}