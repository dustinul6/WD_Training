namespace ForeignKey.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CUST_NAME = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExistingTable",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.CustomerId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExistingTable", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.ExistingTable", "ProductId", "dbo.Products");
            DropIndex("dbo.ExistingTable", new[] { "CustomerId" });
            DropIndex("dbo.ExistingTable", new[] { "ProductId" });
            DropTable("dbo.ExistingTable");
            DropTable("dbo.Customers");
        }
    }
}
