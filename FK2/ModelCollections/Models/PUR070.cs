namespace ModelCollections.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PUR070
    {
        [Key]
        [StringLength(10)]
        public string PUR07_NO { get; set; }

        
        [StringLength(10)]
        public string CUST_NO { get; set; }

        // 以下新增
        // [ForeignKey("CUST_NO")]
        public PUR010 Pur010 { get; set; }

        
        [StringLength(10)]
        public string JOB_NO { get; set; }

        
        [StringLength(20)]
        public string DIE_NO { get; set; }

        
        [StringLength(20)]
        public string SUB_NO { get; set; }

        
        public decimal QTY1 { get; set; }

        
        [StringLength(50)]
        public string SPECF { get; set; }

        
        [StringLength(3)]
        public string MD_NO { get; set; }

        
        [StringLength(30)]
        public string MD_NA { get; set; }

        // has a column type text
        [Column(TypeName = "text")]
        public string REMARK1 { get; set; }

        public decimal TIME1 { get; set; }

        
        public decimal DAYS { get; set; }

        public DateTime? DATE0 { get; set; }

        public DateTime? DATE_A { get; set; }

        public DateTime? DATE_B { get; set; }

//        [Key]
//        [Column(Order = 12)]
        [StringLength(1)]
        public string CHK_FLG { get; set; }

        public DateTime? DATE1 { get; set; }

        public DateTime? DATE2 { get; set; }

        public DateTime? DATE3 { get; set; }

        public DateTime? DATE4 { get; set; }

//        [Key]
//        [Column(Order = 13)]
        [StringLength(1)]
        public string OK_FLG { get; set; }

//        [Key]
//        [Column(Order = 14)]
        [StringLength(20)]
        public string PLACE2 { get; set; }

//        [Key]
//        [Column(Order = 15)]
        [StringLength(20)]
        public string PLACE { get; set; }

        public DateTime? DATE_C { get; set; }

//        [Key]
//        [Column(Order = 16)]
        [StringLength(10)]
        public string PUR03_NO { get; set; }

//        [Key]
//        [Column(Order = 17)]
        [StringLength(10)]
        public string PSS02_NO { get; set; }

//        [Key]
//        [Column(Order = 18)]
        [StringLength(10)]
        public string PUR03_SEQ { get; set; }

//        [Key]
//        [Column(Order = 19)]
        [StringLength(10)]
        public string PUB04_NO { get; set; }

        [StringLength(1)]
        public string DEL_MARK { get; set; }

        public DateTime? UTIME { get; set; }

//        [Key]
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TIMESTAMP { get; set; }
    }
}
