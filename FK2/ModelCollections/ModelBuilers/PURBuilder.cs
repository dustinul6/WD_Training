using ModelCollections.Models;
using System.Data.Entity;

namespace ModelCollections.ModelBuilers
{
    public class PURBuilder
    {
        public void PUR070(DbModelBuilder modelBuilder)
        {
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
        }

        public void PUR010(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PUR010>()
                .HasKey(e => e.CUST_NO);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.CUST_NO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.SUBNAME)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.NAME)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.TEL1)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.TEL2)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.FAX1)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.FAX2)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.CONTACTER1)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.CONTACTER2)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.ADDR1)
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.PAY_TYPE)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.IN_TYPE)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.ITEM)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.REMARK)
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.EMAIL)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.HTTP)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.BIL_NO)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.SEL_FLG)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.ACCT_NO)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.EMP_QTY)
                .HasPrecision(20, 0)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.AMT1)
                .HasPrecision(20, 0)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.AREA)
                .HasPrecision(20, 0)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.APPRAISE)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.ID_NO)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.ADDR2)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.R_TAX)
                .HasPrecision(7, 0)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.PAY_DAYS)
                .HasPrecision(7, 0)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.CAL_NAME)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.BANK_NO)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.APP_CHK)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.BANK_NA)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.CONN_TYPE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.MOD_NAME)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.TYPE2)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.ACC_TYPE1)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.INV_TYPE1)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.PAY_TYPE1)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.CHK_EMP)
                .IsFixedLength()
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.DISCOUNT)
                .HasPrecision(11, 1)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.REMARK2)
                .IsUnicode(false)
                .IsRequired();

            modelBuilder.Entity<PUR010>()
                .Property(e => e.DEL_MARK)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PUR010>()
                .Property(e => e.TIMESTAMP)
                .IsFixedLength()
                .IsRequired();
        }
    }
}