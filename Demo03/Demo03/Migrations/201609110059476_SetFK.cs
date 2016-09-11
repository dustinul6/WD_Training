namespace Demo03.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SetFK : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT Brands (Name) VALUES ('ACER')");
            Sql("INSERT Brands (Name) VALUES ('ASUS')");
            Sql("INSERT Brands (Name) VALUES ('HP')");

            CreateIndex("dbo.Products", "BrandId");
            AddForeignKey("dbo.Products", "BrandId", "dbo.Brands", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "BrandId" });
        }
    }
}
