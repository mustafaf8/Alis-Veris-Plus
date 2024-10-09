using Microsoft.EntityFrameworkCore;
using Alis_Veris_Plus.Models;

namespace Alis_Veris_Plus.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Başlangıç verileri ekleme
            modelBuilder.Entity<Product>().HasData(
        new Product { Id = 1, Name = "Ürün 1", Price = 100.00m, ImageUrl = "https://example.com/image1.jpg", Description = "Açıklama 1" },
        new Product { Id = 2, Name = "Ürün 2", Price = 200.00m, ImageUrl = "https://example.com/image2.jpg", Description = "Açıklama 2" },
        new Product { Id = 3, Name = "Ürün 3", Price = 300.00m, ImageUrl = "https://example.com/image3.jpg", Description = "Açıklama 3" }
    );
        }
    }
}
