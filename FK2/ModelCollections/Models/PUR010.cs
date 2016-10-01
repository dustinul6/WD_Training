namespace ModelCollections.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PUR010
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CUST_NO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string SUBNAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(60)]
        public string NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string TEL1 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string TEL2 { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string FAX1 { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string FAX2 { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(20)]
        public string CONTACTER1 { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string CONTACTER2 { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "text")]
        public string ADDR1 { get; set; }

        public DateTime? DATE1 { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string PAY_TYPE { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(15)]
        public string IN_TYPE { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string ITEM { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "text")]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string EMAIL { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(40)]
        public string HTTP { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(3)]
        public string BIL_NO { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(1)]
        public string SEL_FLG { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(30)]
        public string ACCT_NO { get; set; }

        [Key]
        [Column(Order = 19)]
        public decimal EMP_QTY { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal AMT1 { get; set; }

        [Key]
        [Column(Order = 21)]
        public decimal AREA { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(1)]
        public string APPRAISE { get; set; }

        public DateTime? APP_DATE { get; set; }

        public DateTime? DATE2 { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(10)]
        public string ID_NO { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(50)]
        public string ADDR2 { get; set; }

        [Key]
        [Column(Order = 25)]
        public decimal R_TAX { get; set; }

        [Key]
        [Column(Order = 26)]
        public decimal PAY_DAYS { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(10)]
        public string CAL_NAME { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(10)]
        public string BANK_NO { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(1)]
        public string APP_CHK { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(40)]
        public string BANK_NA { get; set; }

        [Key]
        [Column(Order = 31)]
        [StringLength(1)]
        public string CONN_TYPE { get; set; }

        [Key]
        [Column(Order = 32)]
        [StringLength(12)]
        public string MOD_NAME { get; set; }

        public DateTime? MOD_DATE { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(1)]
        public string TYPE2 { get; set; }

        [Key]
        [Column(Order = 34)]
        [StringLength(30)]
        public string ACC_TYPE1 { get; set; }

        [Key]
        [Column(Order = 35)]
        [StringLength(10)]
        public string INV_TYPE1 { get; set; }

        [Key]
        [Column(Order = 36)]
        [StringLength(10)]
        public string PAY_TYPE1 { get; set; }

        [Key]
        [Column(Order = 37)]
        [StringLength(12)]
        public string CHK_EMP { get; set; }

        [Key]
        [Column(Order = 38)]
        public decimal DISCOUNT { get; set; }

        [Key]
        [Column(Order = 39, TypeName = "text")]
        public string REMARK2 { get; set; }

        [StringLength(1)]
        public string DEL_MARK { get; set; }

        public DateTime? UTIME { get; set; }

        [Key]
        [Column(Order = 40, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TIMESTAMP { get; set; }
    }
}
