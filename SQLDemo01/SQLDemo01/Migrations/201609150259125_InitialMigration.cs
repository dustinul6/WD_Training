namespace SQLDemo01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
//            CreateTable(
//                "dbo.PUR010",
//                c => new
//                    {
//                        Id = c.Guid(nullable: false),
//                        CUST_NO = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        SUBNAME = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        NAME = c.String(maxLength: 60, fixedLength: true, unicode: false),
//                        TEL1 = c.String(maxLength: 20, fixedLength: true, unicode: false),
//                        TEL2 = c.String(maxLength: 20, fixedLength: true, unicode: false),
//                        FAX1 = c.String(maxLength: 20, fixedLength: true, unicode: false),
//                        FAX2 = c.String(maxLength: 20, fixedLength: true, unicode: false),
//                        CONTACTER1 = c.String(maxLength: 20, fixedLength: true, unicode: false),
//                        CONTACTER2 = c.String(maxLength: 20, fixedLength: true, unicode: false),
//                        ADDR1 = c.String(unicode: false, storeType: "text"),
//                        DATE1 = c.DateTime(),
//                        PAY_TYPE = c.String(maxLength: 20, fixedLength: true, unicode: false),
//                        IN_TYPE = c.String(maxLength: 15, fixedLength: true, unicode: false),
//                        ITEM = c.String(maxLength: 50, fixedLength: true, unicode: false),
//                        REMARK = c.String(unicode: false, storeType: "text"),
//                        EMAIL = c.String(maxLength: 50, fixedLength: true, unicode: false),
//                        HTTP = c.String(maxLength: 40, fixedLength: true, unicode: false),
//                        BIL_NO = c.String(maxLength: 3, fixedLength: true, unicode: false),
//                        SEL_FLG = c.String(maxLength: 1, fixedLength: true, unicode: false),
//                        ACCT_NO = c.String(maxLength: 30, fixedLength: true, unicode: false),
//                        EMP_QTY = c.Decimal(nullable: false, precision: 20, scale: 0),
//                        AMT1 = c.Decimal(nullable: false, precision: 20, scale: 0),
//                        AREA = c.Decimal(nullable: false, precision: 20, scale: 0),
//                        APPRAISE = c.String(maxLength: 1, fixedLength: true, unicode: false),
//                        APP_DATE = c.DateTime(),
//                        DATE2 = c.DateTime(),
//                        ID_NO = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        ADDR2 = c.String(maxLength: 50, fixedLength: true, unicode: false),
//                        R_TAX = c.Decimal(nullable: false, precision: 7, scale: 0),
//                        PAY_DAYS = c.Decimal(nullable: false, precision: 7, scale: 0),
//                        CAL_NAME = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        BANK_NO = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        APP_CHK = c.String(maxLength: 1, fixedLength: true, unicode: false),
//                        BANK_NA = c.String(maxLength: 40, fixedLength: true, unicode: false),
//                        CONN_TYPE = c.String(maxLength: 1, fixedLength: true, unicode: false),
//                        MOD_NAME = c.String(maxLength: 12, fixedLength: true, unicode: false),
//                        MOD_DATE = c.DateTime(),
//                        TYPE2 = c.String(maxLength: 1, fixedLength: true, unicode: false),
//                        ACC_TYPE1 = c.String(maxLength: 30, fixedLength: true, unicode: false),
//                        INV_TYPE1 = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        PAY_TYPE1 = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        CHK_EMP = c.String(maxLength: 12, fixedLength: true, unicode: false),
//                        DISCOUNT = c.Decimal(nullable: false, precision: 11, scale: 1),
//                        REMARK2 = c.String(unicode: false, storeType: "text"),
//                        DEL_MARK = c.String(maxLength: 1, fixedLength: true, unicode: false),
//                        UTIME = c.DateTime(),
//                        TIMESTAMP = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"),
//                    })
//                .PrimaryKey(t => t.Id);
//            
//            CreateTable(
//                "dbo.PUR070",
//                c => new
//                    {
//                        Id = c.Guid(nullable: false),
//                        PUR07_NO = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        CUST_NO = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        JOB_NO = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        DIE_NO = c.String(maxLength: 20, fixedLength: true, unicode: false),
//                        SUB_NO = c.String(maxLength: 20, fixedLength: true, unicode: false),
//                        QTY1 = c.Decimal(nullable: false, precision: 20, scale: 2),
//                        SPECF = c.String(maxLength: 50, fixedLength: true, unicode: false),
//                        MD_NO = c.String(maxLength: 3, fixedLength: true, unicode: false),
//                        MD_NA = c.String(maxLength: 30, fixedLength: true, unicode: false),
//                        REMARK1 = c.String(unicode: false, storeType: "text"),
//                        TIME1 = c.Decimal(nullable: false, precision: 20, scale: 2),
//                        DAYS = c.Decimal(nullable: false, precision: 20, scale: 2),
//                        DATE0 = c.DateTime(),
//                        DATE_A = c.DateTime(),
//                        DATE_B = c.DateTime(),
//                        CHK_FLG = c.String(maxLength: 1, fixedLength: true, unicode: false),
//                        DATE1 = c.DateTime(),
//                        DATE2 = c.DateTime(),
//                        DATE3 = c.DateTime(),
//                        DATE4 = c.DateTime(),
//                        OK_FLG = c.String(maxLength: 1, fixedLength: true, unicode: false),
//                        PLACE2 = c.String(maxLength: 20, fixedLength: true, unicode: false),
//                        PLACE = c.String(maxLength: 20, fixedLength: true, unicode: false),
//                        DATE_C = c.DateTime(),
//                        PUR03_NO = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        PSS02_NO = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        PUR03_SEQ = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        PUB04_NO = c.String(maxLength: 10, fixedLength: true, unicode: false),
//                        DEL_MARK = c.String(maxLength: 1, fixedLength: true, unicode: false),
//                        UTIME = c.DateTime(),
//                        TIMESTAMP = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"),
//                        Pur010ContractorId = c.Guid(nullable: false),
//                    })
//                .PrimaryKey(t => t.Id)
//                .ForeignKey("dbo.PUR010", t => t.Pur010ContractorId, cascadeDelete: true)
//                .Index(t => t.Pur010ContractorId);
            
        }
        
        public override void Down()
        {
//            DropForeignKey("dbo.PUR070", "Pur010ContractorId", "dbo.PUR010");
//            DropIndex("dbo.PUR070", new[] { "Pur010ContractorId" });
//            DropTable("dbo.PUR070");
//            DropTable("dbo.PUR010");
        }
    }
}
