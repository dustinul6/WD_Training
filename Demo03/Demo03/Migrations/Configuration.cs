namespace Demo03.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Demo03.Models.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Demo03.Models.AppDbContext context)
        {
//            var product1 = new Product()
//            {
//                Id = 1,
//                Name = "Computer",
//                Price = 200,
//                Description = "Good product"
//            };
//            var product2 = new Product()
//            {
//                Id = 2,
//                Name = "Laptop",
//                Price = 150,
//                Description = "Wonderful!!"
//            };
//
//            context.Products.AddOrUpdate(product1, product2);
            
//            var brand1 = new Brand()
//            {
//                Id = 1,
//                Name = "Acer"
//            };
//            var brand2 = new Brand()
//            {
//                Id = 2,
//                Name = "Asus"
//            };
//            var brand3 = new Brand()
//            {
//                Id = 3,
//                Name = "HP"
//            };
//            context.Brands.AddOrUpdate(brand1, brand2, brand3);

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
