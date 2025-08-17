using Microsoft.EntityFrameworkCore;
using System;

namespace CmsProject.Models
{
    public class CmsDbContext : DbContext
    {
        public CmsDbContext() { }
        public CmsDbContext(DbContextOptions<CmsDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // keep empty if using DI + appsettings.json (recommended)
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            // If you later add more models: Menu, Orders, Vendor, Wallet → map them here
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
