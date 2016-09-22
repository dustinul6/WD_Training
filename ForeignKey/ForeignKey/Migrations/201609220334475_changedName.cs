namespace ForeignKey.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Products", name: "BrandId", newName: "Brand_No");
            RenameIndex(table: "dbo.Products", name: "IX_BrandId", newName: "IX_Brand_No");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Products", name: "IX_Brand_No", newName: "IX_BrandId");
            RenameColumn(table: "dbo.Products", name: "Brand_No", newName: "BrandId");
        }
    }
}
