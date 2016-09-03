namespace Demo03.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddProductData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products (Name, Price) VALUES ('Monitor', '250')");
            Sql("INSERT INTO Products (Name, Price) VALUES ('Cell Phone', '300')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Products WHERE Name='Monitor'");
            Sql("DELETE FROM Products WHERE Name='Cell Phone'");
        }
    }
}
