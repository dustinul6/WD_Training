using System.Data.Entity;

namespace ForeignKey.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=connection")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>()
                        .HasMany<Customer>(p => p.Customers)
                        .WithMany(c => c.Products)
                        .Map(pc =>
                        {
                            pc.MapLeftKey("ProductId");
                            pc.MapRightKey("CustomerId");
                            pc.ToTable("ExistingTable");
                        });

        }
    }
}