namespace ModelCollections.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAL041
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string SAL04_NO { get; set; }

        public DateTime? DATE1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ORDER_NO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string CUST_NO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string CUST_ORDER { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(13)]
        public string QUOT_NO { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(70)]
        public string DELIVERY { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(6)]
        public string PAYMENT { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string TRADE { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(3)]
        public string BIL_NO { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(60)]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "text")]
        public string MEMO1 { get; set; }

        public DateTime? OK_DATE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(1)]
        public string OK_FLG { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(20)]
        public string PRDNA { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal TON { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal TON2 { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal CAV { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(1)]
        public string CHK_R1 { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(1)]
        public string CHK_R2 { get; set; }

        [Key]
        [Column(Order = 18)]
        public decimal R1 { get; set; }

        [Key]
        [Column(Order = 19)]
        public decimal R2 { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal R3 { get; set; }

        [Key]
        [Column(Order = 21)]
        public decimal R4 { get; set; }

        [Key]
        [Column(Order = 22)]
        public decimal R5 { get; set; }

        [Key]
        [Column(Order = 23)]
        public decimal AMT_R1 { get; set; }

        [Key]
        [Column(Order = 24)]
        public decimal AMT_R2 { get; set; }

        [Key]
        [Column(Order = 25)]
        public decimal AMT_R3 { get; set; }

        [Key]
        [Column(Order = 26)]
        public decimal AMT_R4 { get; set; }

        [Key]
        [Column(Order = 27)]
        public decimal AMT_R5 { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(15)]
        public string INSERT1 { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(15)]
        public string INSERT2 { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(15)]
        public string BASE { get; set; }

        [Key]
        [Column(Order = 31)]
        [StringLength(1)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 32)]
        [StringLength(10)]
        public string DIE_NO { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(45)]
        public string DIE_NAME { get; set; }

        [Key]
        [Column(Order = 34)]
        [StringLength(20)]
        public string EMP_NA { get; set; }

        [Key]
        [Column(Order = 35)]
        [StringLength(6)]
        public string TYPE1 { get; set; }

        [Key]
        [Column(Order = 36)]
        public decimal SET1 { get; set; }

        [Key]
        [Column(Order = 37)]
        public decimal NEW_R { get; set; }

        [Key]
        [Column(Order = 38)]
        [StringLength(15)]
        public string INSERT3 { get; set; }

        [Key]
        [Column(Order = 39)]
        [StringLength(15)]
        public string INSERT4 { get; set; }

        [Key]
        [Column(Order = 40)]
        [StringLength(10)]
        public string HARDNESS { get; set; }

        [Key]
        [Column(Order = 41)]
        [StringLength(50)]
        public string APPROVE { get; set; }

        public DateTime? D_APPROVE { get; set; }

        [Key]
        [Column(Order = 42)]
        [StringLength(10)]
        public string SAL022_SEQ { get; set; }

        [Key]
        [Column(Order = 43)]
        public decimal AMT1 { get; set; }

        [Key]
        [Column(Order = 44)]
        [StringLength(10)]
        public string CUST2 { get; set; }

        [Key]
        [Column(Order = 45)]
        [StringLength(10)]
        public string JOB_NO { get; set; }

        public DateTime? DATE2 { get; set; }

        [Key]
        [Column(Order = 46)]
        public decimal EXCHANGE { get; set; }

        [Key]
        [Column(Order = 47)]
        [StringLength(18)]
        public string CAV_NO { get; set; }

        [Key]
        [Column(Order = 48)]
        [StringLength(6)]
        public string CATEGORY { get; set; }

        [Key]
        [Column(Order = 49)]
        [StringLength(10)]
        public string TYPE2 { get; set; }

        [Key]
        [Column(Order = 50)]
        public bool DIE_CHK { get; set; }

        public DateTime? DIE_IN { get; set; }

        [Key]
        [Column(Order = 51)]
        [StringLength(15)]
        public string MODEL { get; set; }

        [Key]
        [Column(Order = 52)]
        public bool AMT_Y { get; set; }

        [Key]
        [Column(Order = 53)]
        public bool AMT_N { get; set; }

        [Key]
        [Column(Order = 54)]
        [StringLength(10)]
        public string SAL045_NO { get; set; }

        public DateTime? DATE4 { get; set; }

        [Key]
        [Column(Order = 55)]
        [StringLength(10)]
        public string ORG_CUST { get; set; }

        [Key]
        [Column(Order = 56)]
        [StringLength(1)]
        public string TEST_YN { get; set; }

        public DateTime? T1_DATE { get; set; }

        [Key]
        [Column(Order = 57)]
        [StringLength(30)]
        public string T1_REMARK { get; set; }

        [Key]
        [Column(Order = 58)]
        [StringLength(8)]
        public string OD_TYPE { get; set; }

        [Key]
        [Column(Order = 59)]
        [StringLength(10)]
        public string VENDER { get; set; }

        [Key]
        [Column(Order = 60)]
        [StringLength(12)]
        public string SALES { get; set; }

        [Key]
        [Column(Order = 61)]
        [StringLength(2)]
        public string SLIDER { get; set; }

        [Key]
        [Column(Order = 62)]
        [StringLength(2)]
        public string CYLINDER { get; set; }

        [Key]
        [Column(Order = 63)]
        [StringLength(4)]
        public string C_CAV { get; set; }

        public DateTime? DATE3 { get; set; }

        public DateTime? RTN_DATE { get; set; }

        [Key]
        [Column(Order = 64)]
        [StringLength(10)]
        public string DIE_NO2 { get; set; }

        [Key]
        [Column(Order = 65)]
        [StringLength(20)]
        public string PROD_NO { get; set; }

        [Key]
        [Column(Order = 66)]
        [StringLength(254)]
        public string JPG_FILE { get; set; }

        [Key]
        [Column(Order = 67)]
        [StringLength(16)]
        public string HRS { get; set; }

        [Key]
        [Column(Order = 68)]
        [StringLength(16)]
        public string SUPP_BASE { get; set; }

        [Key]
        [Column(Order = 69)]
        [StringLength(16)]
        public string SUPP_NC { get; set; }

        public DateTime? PRINT_DT { get; set; }

        [Key]
        [Column(Order = 70)]
        [StringLength(34)]
        public string CONTACTER { get; set; }

        [Key]
        [Column(Order = 71)]
        [StringLength(1)]
        public string S_APPROVE { get; set; }

        [Key]
        [Column(Order = 72)]
        [StringLength(20)]
        public string PRODUCER { get; set; }

        public DateTime? PSS_DATE { get; set; }

        [Key]
        [Column(Order = 73)]
        [StringLength(10)]
        public string ECA_NO { get; set; }

        [Key]
        [Column(Order = 74)]
        [StringLength(10)]
        public string ITEM_NAME { get; set; }

        public DateTime? DATE6 { get; set; }

        [Key]
        [Column(Order = 75)]
        [StringLength(50)]
        public string ATTN { get; set; }

        public DateTime? DATE5 { get; set; }

        [Key]
        [Column(Order = 76)]
        [StringLength(10)]
        public string ORDER_NO2 { get; set; }

        [Key]
        [Column(Order = 77)]
        public bool AMT_X { get; set; }

        [Key]
        [Column(Order = 78)]
        [StringLength(16)]
        public string PCNT { get; set; }

        [Key]
        [Column(Order = 79, TypeName = "text")]
        public string MEMO2 { get; set; }

        [Key]
        [Column(Order = 80)]
        [StringLength(10)]
        public string CAD_DATE { get; set; }

        [Key]
        [Column(Order = 81)]
        [StringLength(10)]
        public string CAD_EMP { get; set; }

        [Key]
        [Column(Order = 82)]
        [StringLength(1)]
        public string URGENT { get; set; }

        [Key]
        [Column(Order = 83)]
        [StringLength(60)]
        public string REMARK_E { get; set; }

        public DateTime? ETA { get; set; }

        public DateTime? ETD { get; set; }

        [Key]
        [Column(Order = 84)]
        [StringLength(15)]
        public string DECLAR_NO { get; set; }

        [Key]
        [Column(Order = 85)]
        public decimal EXP_RATE { get; set; }

        [Key]
        [Column(Order = 86)]
        [StringLength(1)]
        public string EXP { get; set; }

        [Key]
        [Column(Order = 87)]
        [StringLength(12)]
        public string NAME3 { get; set; }

        [Key]
        [Column(Order = 88)]
        [StringLength(20)]
        public string NAME4 { get; set; }

        [Key]
        [Column(Order = 89)]
        [StringLength(12)]
        public string MOD_NAME { get; set; }

        public DateTime? MOD_DATE { get; set; }

        [Key]
        [Column(Order = 90)]
        public decimal DAYS1 { get; set; }

        [Key]
        [Column(Order = 91)]
        public decimal DAYS2 { get; set; }

        [Key]
        [Column(Order = 92)]
        public decimal SQTY1 { get; set; }

        [Key]
        [Column(Order = 93)]
        public decimal QTY1 { get; set; }

        [Key]
        [Column(Order = 94)]
        [StringLength(250)]
        public string FILE_NAME { get; set; }

        public DateTime? SHIP_DT { get; set; }

        [Key]
        [Column(Order = 95)]
        public decimal Q_SAMPLE { get; set; }

        [Key]
        [Column(Order = 96)]
        public decimal Q_RUNER { get; set; }

        [StringLength(1)]
        public string DEL_MARK { get; set; }

        public DateTime? UTIME { get; set; }

        [Key]
        [Column(Order = 97, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TIMESTAMP { get; set; }
    }
}
