using ApiDataServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiDataServer.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> products { get; set; }

        internal Task RemoveAsync(Product? product)
        {
            throw new NotImplementedException();
        }
    }
}
