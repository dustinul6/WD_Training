namespace Demo03.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedFK : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "BrandId", c => c.Int(nullable: false));
           
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "BrandId");
        }
    }
}
