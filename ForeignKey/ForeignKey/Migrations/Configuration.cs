using ForeignKey.Models;

namespace ForeignKey.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ForeignKey.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ForeignKey.Models.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.Products.AddOrUpdate(
                  new Product() { Id = 1, Name = "Computer", Price = 100, Brand_No = 2},
                  new Product() { Id = 2, Name = "Computer2", Price = 30, Brand_No = 1},
                  new Product() { Id = 3, Name = "Computer3", Price = 20, Brand_No = 1}
                );

            context.Brands.AddOrUpdate(
                new Brand() { Name = "Acer"},
                new Brand() { Name = "ASUS"},
                new Brand() { Name = "HP"}
                );
            //
        }
    }
}
