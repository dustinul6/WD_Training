namespace ModelCollections.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedSAL041PK : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.SAL041");
            AddPrimaryKey("dbo.SAL041", "ORDER_NO");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SAL041");
            AddPrimaryKey("dbo.SAL041", "SAL04_NO");
        }
    }
}
