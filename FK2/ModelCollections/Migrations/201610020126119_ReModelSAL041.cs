namespace ModelCollections.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ReModelSAL041 : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM dbo.SAL041 WHERE DEL_MARK = 'Y'");
            //DropPrimaryKey("dbo.SAL041");
            AddPrimaryKey("dbo.SAL041", "SAL04_NO");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SAL041");
            //AddPrimaryKey("dbo.SAL041", new[] { "SAL04_NO", "ORDER_NO", "CUST_NO", "CUST_ORDER", "QUOT_NO", "DELIVERY", "PAYMENT", "TRADE", "BIL_NO", "REMARK", "MEMO1", "OK_FLG", "PRDNA", "TON", "TON2", "CAV", "CHK_R1", "CHK_R2", "R1", "R2", "R3", "R4", "R5", "AMT_R1", "AMT_R2", "AMT_R3", "AMT_R4", "AMT_R5", "INSERT1", "INSERT2", "BASE", "ID", "DIE_NO", "DIE_NAME", "EMP_NA", "TYPE1", "SET1", "NEW_R", "INSERT3", "INSERT4", "HARDNESS", "APPROVE", "SAL022_SEQ", "AMT1", "CUST2", "JOB_NO", "EXCHANGE", "CAV_NO", "CATEGORY", "TYPE2", "DIE_CHK", "MODEL", "AMT_Y", "AMT_N", "SAL045_NO", "ORG_CUST", "TEST_YN", "T1_REMARK", "OD_TYPE", "VENDER", "SALES", "SLIDER", "CYLINDER", "C_CAV", "DIE_NO2", "PROD_NO", "JPG_FILE", "HRS", "SUPP_BASE", "SUPP_NC", "CONTACTER", "S_APPROVE", "PRODUCER", "ECA_NO", "ITEM_NAME", "ATTN", "ORDER_NO2", "AMT_X", "PCNT", "MEMO2", "CAD_DATE", "CAD_EMP", "URGENT", "REMARK_E", "DECLAR_NO", "EXP_RATE", "EXP", "NAME3", "NAME4", "MOD_NAME", "DAYS1", "DAYS2", "SQTY1", "QTY1", "FILE_NAME", "Q_SAMPLE", "Q_RUNER", "TIMESTAMP" });
        }
    }
}
