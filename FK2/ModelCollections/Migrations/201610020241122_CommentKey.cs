namespace ModelCollections.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CommentKey : DbMigration
    {
        public override void Up()
        {
//            DropPrimaryKey("dbo.PCM010");
            Sql("DELETE FROM dbo.PCM010 WHERE DEL_MARK = 'Y'");
            AddPrimaryKey("dbo.PCM010", "DIE_NO");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.PCM010");
//            AddPrimaryKey("dbo.PCM010", new[] { "PCM01_NO", "DIE_NO", "DIE_NAME", "CUST_NO", "TON", "TON2", "REMARK", "MDC", "W_DIE", "PROD_MTRL", "DESIGNER", "NAME2", "THICK", "PITCH", "WIDE", "MTRL", "HIGH", "WEIGHT_1", "WEIGHT_U", "CUST_DRAW", "SET1", "CAV", "INSERT1", "INSERT2", "SHRINK", "PHOTO", "MODEL", "DIETYPE", "EDITION", "BASE", "TYPE_A", "YM_NAME", "TEST_NO", "MDC2", "WEIGHT", "BROKER", "OUT_PORT", "PUR_CHK", "OK_CHK", "PAUSE", "CAM_OK", "INSERT_OK", "CAM_DESI", "INSERT_PR", "CAM_PR", "INSERT3", "INSERT4", "OK_FLG1", "CAM_HT", "BASE_OK", "BASE_DESI", "BASE_DWG", "INS_PUR", "CAD_D1", "CAD_D2", "CAD_D3", "CAD_D4", "CAD_D5", "SAMPLE", "LEGEND", "CAD_DAYS", "CAM_DAYS", "CAM_START", "BASE_D1", "CAD_HOUR", "CAM_HOUR", "APPROVE", "DATE5", "INST_D2", "PLACE", "ASM_D1", "ASM_D2", "ASM_D3", "ASM_D4", "ASM_D5", "ASM_D6", "CAUSE", "CR_D1", "CR_D2", "CR_D3", "CR_HR1", "CR_HR2", "CR_HR3", "HD1", "HD2", "HD3", "HD4", "HD5", "BUSH_DATE", "PRE_OK", "ATTACHMENT", "GR_D1", "GR_D2", "GR_D3", "CUST_DIENO", "CUST_DROW", "W_PROD", "FORWARDER", "K1", "VER", "PROD_MDC", "RUNER", "S_W", "CS", "CYCLE", "C_CAV", "REMARKS", "TON3", "W_CORE", "W_CAV", "LAST_TIME", "EDITER", "CTS", "YR", "PROD_NO", "FILE_3D", "FILE_2D", "REV_3D", "REV_2D", "SHRINK_X", "SHRINK_Y", "HRS", "NOZZLE", "ETA_HRS", "SLIDE1", "SLIDE2", "NOZ01", "NOZ02", "NOZ03", "NOZ04", "BASE_HD", "NAME3", "WELD", "OVERFLOW", "DIE_SOURCE", "QTY3", "OLD_QTY2", "CUST_PROD", "AMT1", "QTY1", "QTY2", "MAKER", "TYPE2", "TIMESTAMP" });
        }
    }
}
