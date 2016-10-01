namespace ModelCollections.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PrimaryKeysPUR070 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM dbo.PUR070 WHERE DEL_MARK = 'Y'");
//            DropPrimaryKey("dbo.PUR070");
//            AlterColumn("dbo.PUR070", "CUST_NO", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "JOB_NO", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "DIE_NO", c => c.String(maxLength: 20, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "SUB_NO", c => c.String(maxLength: 20, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "SPECF", c => c.String(maxLength: 50, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "MD_NO", c => c.String(maxLength: 3, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "MD_NA", c => c.String(maxLength: 30, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "REMARK1", c => c.String(unicode: false));
//            AlterColumn("dbo.PUR070", "CHK_FLG", c => c.String(maxLength: 1, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "OK_FLG", c => c.String(maxLength: 1, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "PLACE2", c => c.String(maxLength: 20, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "PLACE", c => c.String(maxLength: 128, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "PUR03_NO", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "PSS02_NO", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "PUR03_SEQ", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "PUB04_NO", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "TIMESTAMP", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddPrimaryKey("dbo.PUR070", "PUR07_NO");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PUR070");
//            AlterColumn("dbo.PUR070", "TIMESTAMP", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"));
//            AlterColumn("dbo.PUR070", "PUB04_NO", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "PUR03_SEQ", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "PSS02_NO", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "PUR03_NO", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "PLACE", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "PLACE2", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "OK_FLG", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "CHK_FLG", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "REMARK1", c => c.String(nullable: false, unicode: false, storeType: "text"));
//            AlterColumn("dbo.PUR070", "MD_NA", c => c.String(nullable: false, maxLength: 30, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "MD_NO", c => c.String(nullable: false, maxLength: 3, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "SPECF", c => c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "SUB_NO", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "DIE_NO", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "JOB_NO", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
//            AlterColumn("dbo.PUR070", "CUST_NO", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
//            AddPrimaryKey("dbo.PUR070", new[] { "PUR07_NO", "CUST_NO", "JOB_NO", "DIE_NO", "SUB_NO", "QTY1", "SPECF", "MD_NO", "MD_NA", "REMARK1", "TIME1", "DAYS", "CHK_FLG", "OK_FLG", "PLACE2", "PLACE", "PUR03_NO", "PSS02_NO", "PUR03_SEQ", "PUB04_NO", "TIMESTAMP" });
        }
    }
}
