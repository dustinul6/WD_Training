using System.Data.Entity;

namespace Demo03.Models
{
    public class AppDbContext : DbContext
    {
        // 指定Connection string
        public AppDbContext()
            :base("name=demo3connection")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Brand> Brands { get; set; }

    }
}