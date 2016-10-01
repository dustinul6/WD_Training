namespace ModelCollections.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PUR010Redefine : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.PUR010");
            AlterColumn("dbo.PUR010", "CUST_NO", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.PUR010", "SUBNAME", c => c.String(maxLength: 10));
            AlterColumn("dbo.PUR010", "NAME", c => c.String(maxLength: 60));
            AlterColumn("dbo.PUR010", "TEL1", c => c.String(maxLength: 20));
            AlterColumn("dbo.PUR010", "TEL2", c => c.String(maxLength: 20));
            AlterColumn("dbo.PUR010", "FAX1", c => c.String(maxLength: 20));
            AlterColumn("dbo.PUR010", "FAX2", c => c.String(maxLength: 20));
            AlterColumn("dbo.PUR010", "CONTACTER1", c => c.String(maxLength: 20));
            AlterColumn("dbo.PUR010", "CONTACTER2", c => c.String(maxLength: 20));
            AlterColumn("dbo.PUR010", "ADDR1", c => c.String(unicode: false, storeType: "text"));
            AlterColumn("dbo.PUR010", "PAY_TYPE", c => c.String(maxLength: 20));
            AlterColumn("dbo.PUR010", "IN_TYPE", c => c.String(maxLength: 15));
            AlterColumn("dbo.PUR010", "ITEM", c => c.String(maxLength: 50));
            AlterColumn("dbo.PUR010", "REMARK", c => c.String(unicode: false, storeType: "text"));
            AlterColumn("dbo.PUR010", "EMAIL", c => c.String(maxLength: 50));
            AlterColumn("dbo.PUR010", "HTTP", c => c.String(maxLength: 40));
            AlterColumn("dbo.PUR010", "BIL_NO", c => c.String(maxLength: 3));
            AlterColumn("dbo.PUR010", "SEL_FLG", c => c.String(maxLength: 1));
            AlterColumn("dbo.PUR010", "ACCT_NO", c => c.String(maxLength: 30));
            AlterColumn("dbo.PUR010", "EMP_QTY", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PUR010", "AMT1", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PUR010", "AREA", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PUR010", "APPRAISE", c => c.String(maxLength: 1));
            AlterColumn("dbo.PUR010", "ID_NO", c => c.String(maxLength: 10));
            AlterColumn("dbo.PUR010", "ADDR2", c => c.String(maxLength: 50));
            AlterColumn("dbo.PUR010", "R_TAX", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PUR010", "PAY_DAYS", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PUR010", "CAL_NAME", c => c.String(maxLength: 10));
            AlterColumn("dbo.PUR010", "BANK_NO", c => c.String(maxLength: 10));
            AlterColumn("dbo.PUR010", "APP_CHK", c => c.String(maxLength: 1));
            AlterColumn("dbo.PUR010", "BANK_NA", c => c.String(maxLength: 40));
            AlterColumn("dbo.PUR010", "CONN_TYPE", c => c.String(maxLength: 1));
            AlterColumn("dbo.PUR010", "MOD_NAME", c => c.String(maxLength: 12));
            AlterColumn("dbo.PUR010", "TYPE2", c => c.String(maxLength: 1));
            AlterColumn("dbo.PUR010", "ACC_TYPE1", c => c.String(maxLength: 30));
            AlterColumn("dbo.PUR010", "INV_TYPE1", c => c.String(maxLength: 10));
            AlterColumn("dbo.PUR010", "PAY_TYPE1", c => c.String(maxLength: 10));
            AlterColumn("dbo.PUR010", "CHK_EMP", c => c.String(maxLength: 12));
            AlterColumn("dbo.PUR010", "DISCOUNT", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.PUR010", "REMARK2", c => c.String(unicode: false, storeType: "text"));
            AlterColumn("dbo.PUR010", "DEL_MARK", c => c.String(maxLength: 1));
            AddPrimaryKey("dbo.PUR010", "CUST_NO");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PUR010");
            AlterColumn("dbo.PUR010", "DEL_MARK", c => c.String(maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "REMARK2", c => c.String(nullable: false, unicode: false, storeType: "text"));
            AlterColumn("dbo.PUR010", "DISCOUNT", c => c.Decimal(nullable: false, precision: 11, scale: 1));
            AlterColumn("dbo.PUR010", "CHK_EMP", c => c.String(nullable: false, maxLength: 12, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "PAY_TYPE1", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "INV_TYPE1", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "ACC_TYPE1", c => c.String(nullable: false, maxLength: 30, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "TYPE2", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "MOD_NAME", c => c.String(nullable: false, maxLength: 12, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "CONN_TYPE", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "BANK_NA", c => c.String(nullable: false, maxLength: 40, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "APP_CHK", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "BANK_NO", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "CAL_NAME", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "PAY_DAYS", c => c.Decimal(nullable: false, precision: 7, scale: 0));
            AlterColumn("dbo.PUR010", "R_TAX", c => c.Decimal(nullable: false, precision: 7, scale: 0));
            AlterColumn("dbo.PUR010", "ADDR2", c => c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "ID_NO", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "APPRAISE", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "AREA", c => c.Decimal(nullable: false, precision: 20, scale: 0));
            AlterColumn("dbo.PUR010", "AMT1", c => c.Decimal(nullable: false, precision: 20, scale: 0));
            AlterColumn("dbo.PUR010", "EMP_QTY", c => c.Decimal(nullable: false, precision: 20, scale: 0));
            AlterColumn("dbo.PUR010", "ACCT_NO", c => c.String(nullable: false, maxLength: 30, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "SEL_FLG", c => c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "BIL_NO", c => c.String(nullable: false, maxLength: 3, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "HTTP", c => c.String(nullable: false, maxLength: 40, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "EMAIL", c => c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "REMARK", c => c.String(nullable: false, unicode: false, storeType: "text"));
            AlterColumn("dbo.PUR010", "ITEM", c => c.String(nullable: false, maxLength: 50, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "IN_TYPE", c => c.String(nullable: false, maxLength: 15, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "PAY_TYPE", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "ADDR1", c => c.String(nullable: false, unicode: false, storeType: "text"));
            AlterColumn("dbo.PUR010", "CONTACTER2", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "CONTACTER1", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "FAX2", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "FAX1", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "TEL2", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "TEL1", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "NAME", c => c.String(nullable: false, maxLength: 60, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "SUBNAME", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AlterColumn("dbo.PUR010", "CUST_NO", c => c.String(nullable: false, maxLength: 10, fixedLength: true, unicode: false));
            AddPrimaryKey("dbo.PUR010", new[] { "CUST_NO", "SUBNAME", "NAME", "TEL1", "TEL2", "FAX1", "FAX2", "CONTACTER1", "CONTACTER2", "ADDR1", "PAY_TYPE", "IN_TYPE", "ITEM", "REMARK", "EMAIL", "HTTP", "BIL_NO", "SEL_FLG", "ACCT_NO", "EMP_QTY", "AMT1", "AREA", "APPRAISE", "ID_NO", "ADDR2", "R_TAX", "PAY_DAYS", "CAL_NAME", "BANK_NO", "APP_CHK", "BANK_NA", "CONN_TYPE", "MOD_NAME", "TYPE2", "ACC_TYPE1", "INV_TYPE1", "PAY_TYPE1", "CHK_EMP", "DISCOUNT", "REMARK2", "TIMESTAMP" });
        }
    }
}
