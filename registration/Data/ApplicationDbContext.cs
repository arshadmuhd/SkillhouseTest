using Microsoft.EntityFrameworkCore;
using registration.Models;

namespace registration.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<RegistrationModel> User1 { get; set; }
        public DbSet<OrderModel> Order { get; set; }
       public DbSet<RazorpayOptionsModel> RazorpayOptions { get;set; }
    }
}
