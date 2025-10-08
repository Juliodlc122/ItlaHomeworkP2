using Microsoft.EntityFrameworkCore;
using TechStoreWebApp_.Models;

namespace TechStoreWebApp_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
