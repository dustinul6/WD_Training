namespace ModelCollections.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PUR010Redefine : DbMigration
    {
        public override void Up()
        {
            //DropPrimaryKey("dbo.PUR010");
            Sql("DELETE FROM dbo.PUR010 WHERE DEL_MARK = 'Y'");
            AddPrimaryKey("dbo.PUR010", "CUST_NO");

        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PUR010");
            //AddPrimaryKey("dbo.PUR010", new[] { "CUST_NO", "SUBNAME", "NAME", "TEL1", "TEL2", "FAX1", "FAX2", "CONTACTER1", "CONTACTER2", "ADDR1", "PAY_TYPE", "IN_TYPE", "ITEM", "REMARK", "EMAIL", "HTTP", "BIL_NO", "SEL_FLG", "ACCT_NO", "EMP_QTY", "AMT1", "AREA", "APPRAISE", "ID_NO", "ADDR2", "R_TAX", "PAY_DAYS", "CAL_NAME", "BANK_NO", "APP_CHK", "BANK_NA", "CONN_TYPE", "MOD_NAME", "TYPE2", "ACC_TYPE1", "INV_TYPE1", "PAY_TYPE1", "CHK_EMP", "DISCOUNT", "REMARK2", "TIMESTAMP" });
        }
    }
}
