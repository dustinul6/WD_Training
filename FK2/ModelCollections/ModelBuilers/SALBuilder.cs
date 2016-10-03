using ModelCollections.Models;
using System.Data.Entity;

namespace ModelCollections.ModelBuilers
{
    public class SALBuilder
    {
        public void SAL041(DbModelBuilder modelBuilder)
        {
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