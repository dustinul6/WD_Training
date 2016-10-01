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
    }
}