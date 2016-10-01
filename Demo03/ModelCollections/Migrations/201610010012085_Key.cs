namespace ModelCollections.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Key : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PUR070", "CUST_NO", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "JOB_NO", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "DIE_NO", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "SUB_NO", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "SPECF", c => c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "MD_NO", c => c.String(nullable: false, maxLength: 3, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "MD_NA", c => c.String(nullable: false, maxLength: 30, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "REMARK1", c => c.String(nullable: false, unicode: false));
            AlterColumn("dbo.PUR070", "CHK_FLG", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "OK_FLG", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "PLACE2", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "PLACE", c => c.String(nullable: false, maxLength: 128, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "PUR03_NO", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "PSS02_NO", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "PUR03_SEQ", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "PUB04_NO", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PUR070", "PUB04_NO", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "PUR03_SEQ", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "PSS02_NO", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "PUR03_NO", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "PLACE", c => c.String(maxLength: 128, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "PLACE2", c => c.String(maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "OK_FLG", c => c.String(maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "CHK_FLG", c => c.String(maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "REMARK1", c => c.String(unicode: false));
            AlterColumn("dbo.PUR070", "MD_NA", c => c.String(maxLength: 30, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "MD_NO", c => c.String(maxLength: 3, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "SPECF", c => c.String(maxLength: 50, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "SUB_NO", c => c.String(maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "DIE_NO", c => c.String(maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "JOB_NO", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR070", "CUST_NO", c => c.String(maxLength: 10, fixedLength: true, unicode: false));
        }
    }
}
