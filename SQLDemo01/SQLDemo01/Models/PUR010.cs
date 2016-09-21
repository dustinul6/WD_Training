namespace SQLDemo01.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PUR010
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PUR010()
        {
            PUR070 = new HashSet<PUR070>();
        }

        [StringLength(10)]
        public string CUST_NO { get; set; }

        [StringLength(10)]
        public string SUBNAME { get; set; }

        [StringLength(60)]
        public string NAME { get; set; }

        [StringLength(20)]
        public string TEL1 { get; set; }

        [StringLength(20)]
        public string TEL2 { get; set; }

        [StringLength(20)]
        public string FAX1 { get; set; }

        [StringLength(20)]
        public string FAX2 { get; set; }

        [StringLength(20)]
        public string CONTACTER1 { get; set; }

        [StringLength(20)]
        public string CONTACTER2 { get; set; }

        [Column(TypeName = "text")]
        public string ADDR1 { get; set; }

        public DateTime? DATE1 { get; set; }

        [StringLength(20)]
        public string PAY_TYPE { get; set; }

        [StringLength(15)]
        public string IN_TYPE { get; set; }

        [StringLength(50)]
        public string ITEM { get; set; }

        [Column(TypeName = "text")]
        public string REMARK { get; set; }

        [StringLength(50)]
        public string EMAIL { get; set; }

        [StringLength(40)]
        public string HTTP { get; set; }

        [StringLength(3)]
        public string BIL_NO { get; set; }

        [StringLength(1)]
        public string SEL_FLG { get; set; }

        [StringLength(30)]
        public string ACCT_NO { get; set; }

        public decimal EMP_QTY { get; set; }

        public decimal AMT1 { get; set; }

        public decimal AREA { get; set; }

        [StringLength(1)]
        public string APPRAISE { get; set; }

        public DateTime? APP_DATE { get; set; }

        public DateTime? DATE2 { get; set; }

        [StringLength(10)]
        public string ID_NO { get; set; }

        [StringLength(50)]
        public string ADDR2 { get; set; }

        public decimal R_TAX { get; set; }

        public decimal PAY_DAYS { get; set; }

        [StringLength(10)]
        public string CAL_NAME { get; set; }

        [StringLength(10)]
        public string BANK_NO { get; set; }

        [StringLength(1)]
        public string APP_CHK { get; set; }

        [StringLength(40)]
        public string BANK_NA { get; set; }

        [StringLength(1)]
        public string CONN_TYPE { get; set; }

        [StringLength(12)]
        public string MOD_NAME { get; set; }

        public DateTime? MOD_DATE { get; set; }

        [StringLength(1)]
        public string TYPE2 { get; set; }

        [StringLength(30)]
        public string ACC_TYPE1 { get; set; }

        [StringLength(10)]
        public string INV_TYPE1 { get; set; }

        [StringLength(10)]
        public string PAY_TYPE1 { get; set; }

        [StringLength(12)]
        public string CHK_EMP { get; set; }

        public decimal DISCOUNT { get; set; }

        [Column(TypeName = "text")]
        public string REMARK2 { get; set; }

        [StringLength(1)]
        public string DEL_MARK { get; set; }

        public DateTime? UTIME { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TIMESTAMP { get; set; }

        public Guid Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PUR070> PUR070 { get; set; }
    }
}
