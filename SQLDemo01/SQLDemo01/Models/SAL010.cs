namespace SQLDemo01.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAL010
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CUST_NO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(12)]
        public string SUBNAME { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(60)]
        public string NAME { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(12)]
        public string COUNTRY { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(6)]
        public string ZIP { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "text")]
        public string ADDR1 { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "text")]
        public string ADDR2 { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(28)]
        public string BOSS { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(28)]
        public string CONTACTER { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string TEL1 { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string FAX { get; set; }

        public DateTime? DATE1 { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(1)]
        public string SEL_FLG { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal CLOSE_DATE { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal TAX_R { get; set; }

        [Key]
        [Column(Order = 14)]
        public decimal TAX_R1 { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(30)]
        public string BANK_NA { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(20)]
        public string BANK_ACCNO { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(15)]
        public string INV_ID { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(8)]
        public string ACCT_NO { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(30)]
        public string HTTP { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(3)]
        public string BIL_NO { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(30)]
        public string E_MAIL { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "text")]
        public string MEMO1 { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(28)]
        public string SERVICE { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(8)]
        public string CUST_TYPE { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(6)]
        public string TYPE_A { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(30)]
        public string TRADE { get; set; }

        public DateTime? DATE2 { get; set; }

        [Key]
        [Column(Order = 27)]
        public bool CHK_CASH { get; set; }

        public DateTime? DATE3 { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(2)]
        public string DAY1 { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(10)]
        public string TAX_TYPE { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(2)]
        public string DOWS { get; set; }

        [Key]
        [Column(Order = 31)]
        [StringLength(100)]
        public string REMARK01 { get; set; }

        [Key]
        [Column(Order = 32)]
        [StringLength(1)]
        public string TYPE2 { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(16)]
        public string SALE_NAME { get; set; }

        [Key]
        [Column(Order = 34, TypeName = "text")]
        public string MARKS { get; set; }

        [Key]
        [Column(Order = 35)]
        [StringLength(12)]
        public string MOD_NAME { get; set; }

        public DateTime? MOD_DATE { get; set; }

        [StringLength(1)]
        public string DEL_MARK { get; set; }

        public DateTime? UTIME { get; set; }

        [Key]
        [Column(Order = 36, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TIMESTAMP { get; set; }
    }
}
