namespace ModelCollections.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public partial class PUR070
    {
        [StringLength(10)]
        [Key]
        public string PUR07_NO { get; set; }

        [StringLength(10)]
        public string CUST_NO { get; set; }

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

        public string REMARK1 { get; set; }

        public decimal TIME1 { get; set; }

        public decimal DAYS { get; set; }

        public DateTime? DATE0 { get; set; }

        public DateTime? DATE_A { get; set; }

        public DateTime? DATE_B { get; set; }

        [StringLength(1)]
        public string CHK_FLG { get; set; }

        public DateTime? DATE1 { get; set; }

        public DateTime? DATE2 { get; set; }

        public DateTime? DATE3 { get; set; }

        public DateTime? DATE4 { get; set; }

        [StringLength(1)]
        public string OK_FLG { get; set; }

        [StringLength(20)]
        public string PLACE2 { get; set; }

        public string PLACE { get; set; }

        public DateTime? DATE_C { get; set; }

        [StringLength(10)]
        public string PUR03_NO { get; set; }

        [StringLength(10)]
        public string PSS02_NO { get; set; }

        [StringLength(10)]
        public string PUR03_SEQ { get; set; }

        [StringLength(10)]
        public string PUB04_NO { get; set; }

        [StringLength(1)]
        public string DEL_MARK { get; set; }

        public DateTime? UTIME { get; set; }

        [MaxLength(8)]
        [Timestamp]
        public byte[] TIMESTAMP { get; set; }
    }
}
