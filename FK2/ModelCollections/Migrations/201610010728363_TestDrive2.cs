namespace ModelCollections.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class TestDrive2 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM dbo.PUR070 WHERE DEL_MARK = 'Y'");
//            DropPrimaryKey("dbo.PUR070");
            AddPrimaryKey("dbo.PUR070", "PUR07_NO");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PUR070");
//            AddPrimaryKey("dbo.PUR070", new[] { "PUR07_NO", "CUST_NO", "JOB_NO", "DIE_NO", "SUB_NO", "QTY1", "SPECF", "MD_NO", "MD_NA", "REMARK1", "TIME1", "DAYS", "CHK_FLG", "OK_FLG", "PLACE2", "PLACE", "PUR03_NO", "PSS02_NO", "PUR03_SEQ", "PUB04_NO", "TIMESTAMP" });
        }
    }
}
