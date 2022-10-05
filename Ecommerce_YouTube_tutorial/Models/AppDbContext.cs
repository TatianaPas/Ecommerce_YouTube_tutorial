using Microsoft.EntityFrameworkCore;

namespace Ecommerce_YouTube_tutorial.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating (ModelBuilder model)
        {
            base.OnModelCreating (model);
        }

        public DbSet<Product> Products { get; set; }
    }
}
