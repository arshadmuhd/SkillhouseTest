using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Ap1.Models
{
    public static class ModelBuilderExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1,Name="Active Wear -Men"},
                new Category { Id = 2, Name = "Active Wear -WoMen" },
                 new Category { Id = 3, Name = "Active Wear -WoMen" },
                new Category { Id = 4, Name = "Active Wear -Men" }
                );

            modelBuilder.Entity<Product>().HasData(
               new Product { Id = 1, Sku="qwe", Name = "asdf",Description="Good",Price=234,isAvailable=true,CategoryId=1 },
              new Product { Id = 2, Sku = "qwe", Name = "rty", Description = "Good", Price = 895, isAvailable = true, CategoryId = 2 },
                new Product { Id = 3, Sku = "qwe", Name = "hjlk", Description = "okok", Price = 834, isAvailable = false, CategoryId = 3 },
              new Product { Id = 4, Sku = "qwe", Name = "fghj", Description = "osm", Price = 434, isAvailable =false, CategoryId = 4}
               );

        }
    }
}
