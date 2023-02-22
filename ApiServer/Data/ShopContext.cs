using Ap1.Models;
using Microsoft.EntityFrameworkCore;

namespace Ap1.Data
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        { 

        }
        public DbSet<Product> products { get; set; }

    }
}
