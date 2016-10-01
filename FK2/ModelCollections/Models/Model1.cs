namespace ModelCollections.Models
{
    using System.Data.Entity;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=connection1")
        {
        }

        public virtual DbSet<PCM010> PCM010 { get; set; }
        public virtual DbSet<PUR010> PUR010 { get; set; }
        public virtual DbSet<PUR070> PUR070 { get; set; }
        public virtual DbSet<SAL041> SAL041 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PCM010>()
                .Property(e => e.PCM01_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.DIE_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.DIE_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CUST_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.TON)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.TON2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.MDC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.W_DIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.PROD_MTRL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.DESIGNER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.NAME2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.THICK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.PITCH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.WIDE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.MTRL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.HIGH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.WEIGHT_1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.WEIGHT_U)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CUST_DRAW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.SET1)
                .HasPrecision(10, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAV)
                .HasPrecision(8, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.INSERT1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.INSERT2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.SHRINK)
                .HasPrecision(11, 3);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.PHOTO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.MODEL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.DIETYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.EDITION)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.BASE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.TYPE_A)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.YM_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.TEST_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.MDC2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.WEIGHT)
                .HasPrecision(20, 2);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.BROKER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.OUT_PORT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.PUR_CHK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.OK_CHK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.PAUSE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAM_OK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.INSERT_OK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAM_DESI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.INSERT_PR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAM_PR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.INSERT3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.INSERT4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.OK_FLG1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAM_HT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.BASE_OK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.BASE_DESI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.BASE_DWG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.INS_PUR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAD_D1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAD_D2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAD_D3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAD_D4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAD_D5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.SAMPLE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.LEGEND)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAD_DAYS)
                .HasPrecision(6, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAM_DAYS)
                .HasPrecision(6, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAM_START)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.BASE_D1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAD_HOUR)
                .HasPrecision(6, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAM_HOUR)
                .HasPrecision(6, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.APPROVE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.DATE5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.INST_D2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.PLACE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.ASM_D1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.ASM_D2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.ASM_D3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.ASM_D4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.ASM_D5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.ASM_D6)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CAUSE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CR_D1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CR_D2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CR_D3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CR_HR1)
                .HasPrecision(6, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CR_HR2)
                .HasPrecision(6, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CR_HR3)
                .HasPrecision(6, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.HD1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.HD2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.HD3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.HD4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.HD5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.BUSH_DATE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.PRE_OK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.ATTACHMENT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.GR_D1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.GR_D2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.GR_D3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CUST_DIENO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CUST_DROW)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.W_PROD)
                .HasPrecision(20, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.FORWARDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.K1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.VER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.PROD_MDC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.RUNER)
                .HasPrecision(20, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.S_W)
                .HasPrecision(20, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CYCLE)
                .HasPrecision(20, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.C_CAV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.REMARKS)
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.TON3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.W_CORE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.W_CAV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.LAST_TIME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.EDITER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CTS)
                .HasPrecision(11, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.YR)
                .HasPrecision(11, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.PROD_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.FILE_3D)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.FILE_2D)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.REV_3D)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.REV_2D)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.SHRINK_X)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.SHRINK_Y)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.HRS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.NOZZLE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.ETA_HRS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.SLIDE1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.SLIDE2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.NOZ01)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.NOZ02)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.NOZ03)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.NOZ04)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.BASE_HD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.NAME3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.WELD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.OVERFLOW)
                .HasPrecision(11, 2);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.DIE_SOURCE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.QTY3)
                .HasPrecision(11, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.OLD_QTY2)
                .HasPrecision(11, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.CUST_PROD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.AMT1)
                .HasPrecision(11, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.QTY1)
                .HasPrecision(11, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.QTY2)
                .HasPrecision(11, 0);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.MAKER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.TYPE2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.DEL_MARK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PCM010>()
                .Property(e => e.TIMESTAMP)
                .IsFixedLength();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.CUST_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.SUBNAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.TEL1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.TEL2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.FAX1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.FAX2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.CONTACTER1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.CONTACTER2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.ADDR1)
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.PAY_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.IN_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.ITEM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.REMARK)
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.EMAIL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.HTTP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.BIL_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.SEL_FLG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.ACCT_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.EMP_QTY)
                .HasPrecision(20, 0);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.AMT1)
                .HasPrecision(20, 0);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.AREA)
                .HasPrecision(20, 0);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.APPRAISE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.ID_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.ADDR2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.R_TAX)
                .HasPrecision(7, 0);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.PAY_DAYS)
                .HasPrecision(7, 0);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.CAL_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.BANK_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.APP_CHK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.BANK_NA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.CONN_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.MOD_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.TYPE2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.ACC_TYPE1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.INV_TYPE1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.PAY_TYPE1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.CHK_EMP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.DISCOUNT)
                .HasPrecision(11, 1);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.REMARK2)
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.DEL_MARK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.TIMESTAMP)
                .IsFixedLength();

            modelBuilder.Entity<PUR070>()
                .HasKey(e => e.PUR07_NO);

            modelBuilder.Entity<PUR070>()
                .Property(e => e.PUR07_NO)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();
            

            modelBuilder.Entity<PUR070>()
                .Property(e => e.CUST_NO)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.JOB_NO)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.DIE_NO)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.SUB_NO)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.QTY1)
                .HasPrecision(20, 2)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.SPECF)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.MD_NO)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.MD_NA)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.REMARK1)
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.TIME1)
                .HasPrecision(20, 2)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.DAYS)
                .HasPrecision(20, 2)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.CHK_FLG)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.OK_FLG)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.PLACE2)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.PLACE)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.PUR03_NO)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.PSS02_NO)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.PUR03_SEQ)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.PUB04_NO)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR070>()
                .Property(e => e.DEL_MARK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR070>()
                .Property(e => e.TIMESTAMP)
                .IsFixedLength()
                .IsRequired();

            modelBuilder.Entity<SAL041>()
                .Property(e => e.SAL04_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.ORDER_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.CUST_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.CUST_ORDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.QUOT_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.DELIVERY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.PAYMENT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.TRADE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.BIL_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.REMARK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.MEMO1)
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.OK_FLG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.PRDNA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.TON)
                .HasPrecision(8, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.TON2)
                .HasPrecision(8, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.CAV)
                .HasPrecision(6, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.CHK_R1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.CHK_R2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.R1)
                .HasPrecision(7, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.R2)
                .HasPrecision(7, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.R3)
                .HasPrecision(7, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.R4)
                .HasPrecision(7, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.R5)
                .HasPrecision(7, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.AMT_R1)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.AMT_R2)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.AMT_R3)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.AMT_R4)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.AMT_R5)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.INSERT1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.INSERT2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.BASE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.DIE_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.DIE_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.EMP_NA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.TYPE1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.SET1)
                .HasPrecision(20, 1);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.NEW_R)
                .HasPrecision(20, 1);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.INSERT3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.INSERT4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.HARDNESS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.APPROVE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.SAL022_SEQ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.AMT1)
                .HasPrecision(20, 2);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.CUST2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.JOB_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.EXCHANGE)
                .HasPrecision(14, 4);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.CAV_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.CATEGORY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.TYPE2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.MODEL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.SAL045_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.ORG_CUST)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.TEST_YN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.T1_REMARK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.OD_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.VENDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.SALES)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.SLIDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.CYLINDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.C_CAV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.DIE_NO2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.PROD_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.JPG_FILE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.HRS)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.SUPP_BASE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.SUPP_NC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.CONTACTER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.S_APPROVE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.PRODUCER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.ECA_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.ITEM_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.ATTN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.ORDER_NO2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.PCNT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.MEMO2)
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.CAD_DATE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.CAD_EMP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.URGENT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.REMARK_E)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.DECLAR_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.EXP_RATE)
                .HasPrecision(14, 4);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.EXP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.NAME3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.NAME4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.MOD_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.DAYS1)
                .HasPrecision(11, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.DAYS2)
                .HasPrecision(11, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.SQTY1)
                .HasPrecision(11, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.QTY1)
                .HasPrecision(11, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.FILE_NAME)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.Q_SAMPLE)
                .HasPrecision(12, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.Q_RUNER)
                .HasPrecision(12, 0);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.DEL_MARK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SAL041>()
                .Property(e => e.TIMESTAMP)
                .IsFixedLength();
        }
    }
}
