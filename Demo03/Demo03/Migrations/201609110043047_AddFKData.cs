namespace Demo03.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddFKData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Products SET BrandId=1 WHERE Id=1");
            Sql("UPDATE Products SET BrandId=2 WHERE Id=2");
            Sql("UPDATE Products SET BrandId=1 WHERE Id=3");
            Sql("UPDATE Products SET BrandId=3 WHERE Id=4");
        }
        
        public override void Down()
        {
            Sql("UPDATE Products SET BrandId=0");
        }
    }
}
