using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Entities
{
    public class ApplicationDbContext : DbContext
    {
        private const string Connection = @"Server=DESKTOP-F43SE643F8E; Database=Zadanie9; TrustServerCertificate=Yes; Integrated Security=SSPI; Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Connection);
            }
        }

        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Treaty> Treaties { get; set; } = null!;
        public DbSet<HotelRoom> HotelRooms { get; set; } = null!;
        public DbSet<MigrationCard> MigrationCards { get; set; } = null!;
        public DbSet<Passport> Passports { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passport>()
                .HasOne(p => p.Client)
                .WithOne(c => c.Passport)
                .HasForeignKey<Passport>(p => p.PassportId);
            modelBuilder.Entity<MigrationCard>()
                .HasOne(mc => mc.Client)
                .WithOne(c => c.MigrationCard)
                .HasForeignKey<MigrationCard>(mc => mc.MigrationCardId);
        }
    }
}
