﻿using ModelCollections.Models;
using System.Data.Entity;

namespace ModelCollections.ModelBuilers
{
    public class PCMBuilder
    {
        public void PCM010(DbModelBuilder modelBuilder)
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
        }

        public void PCM030(DbModelBuilder modelBuilder)
        {
            
        }
    }
}