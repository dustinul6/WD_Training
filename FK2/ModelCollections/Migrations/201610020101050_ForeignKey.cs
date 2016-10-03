namespace ModelCollections.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKey : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.PUR070", "CUST_NO");
            AddForeignKey("dbo.PUR070", "CUST_NO", "dbo.PUR010", "CUST_NO", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PUR070", "CUST_NO", "dbo.PUR010");
            DropIndex("dbo.PUR070", new[] { "CUST_NO" });
        }
    }
}
