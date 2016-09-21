namespace ModelCollections.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PCM010
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string PCM01_NO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string DIE_NO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(45)]
        public string DIE_NAME { get; set; }

        public DateTime? DATE1 { get; set; }

        public DateTime? DATE2 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string CUST_NO { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string TON { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string TON2 { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "text")]
        public string REMARK { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(40)]
        public string MDC { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(6)]
        public string W_DIE { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(10)]
        public string PROD_MTRL { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(8)]
        public string DESIGNER { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(10)]
        public string NAME2 { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(6)]
        public string THICK { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(6)]
        public string PITCH { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(6)]
        public string WIDE { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(10)]
        public string MTRL { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(6)]
        public string HIGH { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(6)]
        public string WEIGHT_1 { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(6)]
        public string WEIGHT_U { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(20)]
        public string CUST_DRAW { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal SET1 { get; set; }

        [Key]
        [Column(Order = 21)]
        public decimal CAV { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(15)]
        public string INSERT1 { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(15)]
        public string INSERT2 { get; set; }

        [Key]
        [Column(Order = 24)]
        public decimal SHRINK { get; set; }

        [Key]
        [Column(Order = 25)]
        [StringLength(100)]
        public string PHOTO { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(15)]
        public string MODEL { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(20)]
        public string DIETYPE { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(3)]
        public string EDITION { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(15)]
        public string BASE { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(4)]
        public string TYPE_A { get; set; }

        [Key]
        [Column(Order = 31)]
        [StringLength(45)]
        public string YM_NAME { get; set; }

        public DateTime? EXPORT { get; set; }

        public DateTime? EXPORT2 { get; set; }

        public DateTime? T_DATE { get; set; }

        [Key]
        [Column(Order = 32)]
        [StringLength(3)]
        public string TEST_NO { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(30)]
        public string MDC2 { get; set; }

        [Key]
        [Column(Order = 34)]
        public decimal WEIGHT { get; set; }

        [Key]
        [Column(Order = 35)]
        [StringLength(16)]
        public string BROKER { get; set; }

        public DateTime? ETA { get; set; }

        public DateTime? ETD { get; set; }

        [Key]
        [Column(Order = 36)]
        [StringLength(16)]
        public string OUT_PORT { get; set; }

        [Key]
        [Column(Order = 37)]
        [StringLength(1)]
        public string PUR_CHK { get; set; }

        [Key]
        [Column(Order = 38)]
        [StringLength(1)]
        public string OK_CHK { get; set; }

        public DateTime? OK_DATE { get; set; }

        public DateTime? T1_DATE { get; set; }

        [Key]
        [Column(Order = 39)]
        [StringLength(1)]
        public string PAUSE { get; set; }

        [Key]
        [Column(Order = 40)]
        [StringLength(8)]
        public string CAM_OK { get; set; }

        [Key]
        [Column(Order = 41)]
        [StringLength(10)]
        public string INSERT_OK { get; set; }

        [Key]
        [Column(Order = 42)]
        [StringLength(8)]
        public string CAM_DESI { get; set; }

        [Key]
        [Column(Order = 43)]
        [StringLength(10)]
        public string INSERT_PR { get; set; }

        [Key]
        [Column(Order = 44)]
        [StringLength(10)]
        public string CAM_PR { get; set; }

        [Key]
        [Column(Order = 45)]
        [StringLength(15)]
        public string INSERT3 { get; set; }

        [Key]
        [Column(Order = 46)]
        [StringLength(15)]
        public string INSERT4 { get; set; }

        [Key]
        [Column(Order = 47)]
        [StringLength(1)]
        public string OK_FLG1 { get; set; }

        [Key]
        [Column(Order = 48)]
        [StringLength(8)]
        public string CAM_HT { get; set; }

        [Key]
        [Column(Order = 49)]
        [StringLength(8)]
        public string BASE_OK { get; set; }

        [Key]
        [Column(Order = 50)]
        [StringLength(8)]
        public string BASE_DESI { get; set; }

        [Key]
        [Column(Order = 51)]
        [StringLength(8)]
        public string BASE_DWG { get; set; }

        [Key]
        [Column(Order = 52)]
        [StringLength(1)]
        public string INS_PUR { get; set; }

        [Key]
        [Column(Order = 53)]
        [StringLength(8)]
        public string CAD_D1 { get; set; }

        [Key]
        [Column(Order = 54)]
        [StringLength(8)]
        public string CAD_D2 { get; set; }

        [Key]
        [Column(Order = 55)]
        [StringLength(8)]
        public string CAD_D3 { get; set; }

        [Key]
        [Column(Order = 56)]
        [StringLength(10)]
        public string CAD_D4 { get; set; }

        [Key]
        [Column(Order = 57)]
        [StringLength(10)]
        public string CAD_D5 { get; set; }

        [Key]
        [Column(Order = 58)]
        [StringLength(10)]
        public string SAMPLE { get; set; }

        [Key]
        [Column(Order = 59)]
        [StringLength(10)]
        public string LEGEND { get; set; }

        [Key]
        [Column(Order = 60)]
        public decimal CAD_DAYS { get; set; }

        [Key]
        [Column(Order = 61)]
        public decimal CAM_DAYS { get; set; }

        [Key]
        [Column(Order = 62)]
        [StringLength(10)]
        public string CAM_START { get; set; }

        [Key]
        [Column(Order = 63)]
        [StringLength(10)]
        public string BASE_D1 { get; set; }

        [Key]
        [Column(Order = 64)]
        public decimal CAD_HOUR { get; set; }

        [Key]
        [Column(Order = 65)]
        public decimal CAM_HOUR { get; set; }

        [Key]
        [Column(Order = 66)]
        [StringLength(10)]
        public string APPROVE { get; set; }

        [Key]
        [Column(Order = 67)]
        [StringLength(10)]
        public string DATE5 { get; set; }

        [Key]
        [Column(Order = 68)]
        [StringLength(10)]
        public string INST_D2 { get; set; }

        [Key]
        [Column(Order = 69)]
        [StringLength(20)]
        public string PLACE { get; set; }

        [Key]
        [Column(Order = 70)]
        [StringLength(10)]
        public string ASM_D1 { get; set; }

        [Key]
        [Column(Order = 71)]
        [StringLength(10)]
        public string ASM_D2 { get; set; }

        [Key]
        [Column(Order = 72)]
        [StringLength(10)]
        public string ASM_D3 { get; set; }

        [Key]
        [Column(Order = 73)]
        [StringLength(10)]
        public string ASM_D4 { get; set; }

        [Key]
        [Column(Order = 74)]
        [StringLength(10)]
        public string ASM_D5 { get; set; }

        [Key]
        [Column(Order = 75)]
        [StringLength(10)]
        public string ASM_D6 { get; set; }

        [Key]
        [Column(Order = 76)]
        [StringLength(20)]
        public string CAUSE { get; set; }

        [Key]
        [Column(Order = 77)]
        [StringLength(10)]
        public string CR_D1 { get; set; }

        [Key]
        [Column(Order = 78)]
        [StringLength(10)]
        public string CR_D2 { get; set; }

        [Key]
        [Column(Order = 79)]
        [StringLength(10)]
        public string CR_D3 { get; set; }

        [Key]
        [Column(Order = 80)]
        public decimal CR_HR1 { get; set; }

        [Key]
        [Column(Order = 81)]
        public decimal CR_HR2 { get; set; }

        [Key]
        [Column(Order = 82)]
        public decimal CR_HR3 { get; set; }

        [Key]
        [Column(Order = 83)]
        [StringLength(6)]
        public string HD1 { get; set; }

        [Key]
        [Column(Order = 84)]
        [StringLength(6)]
        public string HD2 { get; set; }

        [Key]
        [Column(Order = 85)]
        [StringLength(1)]
        public string HD3 { get; set; }

        [Key]
        [Column(Order = 86)]
        [StringLength(12)]
        public string HD4 { get; set; }

        [Key]
        [Column(Order = 87)]
        [StringLength(12)]
        public string HD5 { get; set; }

        [Key]
        [Column(Order = 88)]
        [StringLength(10)]
        public string BUSH_DATE { get; set; }

        [Key]
        [Column(Order = 89)]
        [StringLength(10)]
        public string PRE_OK { get; set; }

        [Key]
        [Column(Order = 90)]
        [StringLength(10)]
        public string ATTACHMENT { get; set; }

        public DateTime? GR_OKDATE { get; set; }

        [Key]
        [Column(Order = 91)]
        [StringLength(10)]
        public string GR_D1 { get; set; }

        [Key]
        [Column(Order = 92)]
        [StringLength(10)]
        public string GR_D2 { get; set; }

        [Key]
        [Column(Order = 93)]
        [StringLength(10)]
        public string GR_D3 { get; set; }

        [Key]
        [Column(Order = 94)]
        [StringLength(10)]
        public string CUST_DIENO { get; set; }

        [Key]
        [Column(Order = 95)]
        [StringLength(20)]
        public string CUST_DROW { get; set; }

        [Key]
        [Column(Order = 96)]
        public decimal W_PROD { get; set; }

        [Key]
        [Column(Order = 97)]
        [StringLength(10)]
        public string FORWARDER { get; set; }

        [Key]
        [Column(Order = 98)]
        [StringLength(10)]
        public string K1 { get; set; }

        [Key]
        [Column(Order = 99)]
        [StringLength(5)]
        public string VER { get; set; }

        [Key]
        [Column(Order = 100)]
        [StringLength(40)]
        public string PROD_MDC { get; set; }

        [Key]
        [Column(Order = 101)]
        public decimal RUNER { get; set; }

        [Key]
        [Column(Order = 102)]
        public decimal S_W { get; set; }

        [Key]
        [Column(Order = 103)]
        [StringLength(30)]
        public string CS { get; set; }

        [Key]
        [Column(Order = 104)]
        public decimal CYCLE { get; set; }

        [Key]
        [Column(Order = 105)]
        [StringLength(20)]
        public string C_CAV { get; set; }

        [Key]
        [Column(Order = 106, TypeName = "text")]
        public string REMARKS { get; set; }

        [Key]
        [Column(Order = 107)]
        [StringLength(6)]
        public string TON3 { get; set; }

        [Key]
        [Column(Order = 108)]
        [StringLength(8)]
        public string W_CORE { get; set; }

        [Key]
        [Column(Order = 109)]
        [StringLength(8)]
        public string W_CAV { get; set; }

        public DateTime? LAST_DATE { get; set; }

        [Key]
        [Column(Order = 110)]
        [StringLength(5)]
        public string LAST_TIME { get; set; }

        [Key]
        [Column(Order = 111)]
        [StringLength(10)]
        public string EDITER { get; set; }

        [Key]
        [Column(Order = 112)]
        public decimal CTS { get; set; }

        [Key]
        [Column(Order = 113)]
        public decimal YR { get; set; }

        [Key]
        [Column(Order = 114)]
        [StringLength(10)]
        public string PROD_NO { get; set; }

        [Key]
        [Column(Order = 115)]
        [StringLength(30)]
        public string FILE_3D { get; set; }

        [Key]
        [Column(Order = 116)]
        [StringLength(30)]
        public string FILE_2D { get; set; }

        [Key]
        [Column(Order = 117)]
        [StringLength(6)]
        public string REV_3D { get; set; }

        [Key]
        [Column(Order = 118)]
        [StringLength(6)]
        public string REV_2D { get; set; }

        [Key]
        [Column(Order = 119)]
        [StringLength(10)]
        public string SHRINK_X { get; set; }

        [Key]
        [Column(Order = 120)]
        [StringLength(10)]
        public string SHRINK_Y { get; set; }

        [Key]
        [Column(Order = 121)]
        [StringLength(16)]
        public string HRS { get; set; }

        [Key]
        [Column(Order = 122)]
        [StringLength(30)]
        public string NOZZLE { get; set; }

        [Key]
        [Column(Order = 123)]
        [StringLength(8)]
        public string ETA_HRS { get; set; }

        [Key]
        [Column(Order = 124)]
        [StringLength(16)]
        public string SLIDE1 { get; set; }

        [Key]
        [Column(Order = 125)]
        [StringLength(16)]
        public string SLIDE2 { get; set; }

        [Key]
        [Column(Order = 126)]
        [StringLength(50)]
        public string NOZ01 { get; set; }

        [Key]
        [Column(Order = 127)]
        [StringLength(30)]
        public string NOZ02 { get; set; }

        [Key]
        [Column(Order = 128)]
        [StringLength(20)]
        public string NOZ03 { get; set; }

        [Key]
        [Column(Order = 129)]
        [StringLength(20)]
        public string NOZ04 { get; set; }

        [Key]
        [Column(Order = 130)]
        [StringLength(12)]
        public string BASE_HD { get; set; }

        [Key]
        [Column(Order = 131)]
        [StringLength(10)]
        public string NAME3 { get; set; }

        [Key]
        [Column(Order = 132)]
        [StringLength(10)]
        public string WELD { get; set; }

        [Key]
        [Column(Order = 133)]
        public decimal OVERFLOW { get; set; }

        [Key]
        [Column(Order = 134)]
        [StringLength(1)]
        public string DIE_SOURCE { get; set; }

        [Key]
        [Column(Order = 135)]
        public decimal QTY3 { get; set; }

        [Key]
        [Column(Order = 136)]
        public decimal OLD_QTY2 { get; set; }

        public DateTime? POOP_DATE { get; set; }

        [Key]
        [Column(Order = 137)]
        [StringLength(30)]
        public string CUST_PROD { get; set; }

        [Key]
        [Column(Order = 138)]
        public decimal AMT1 { get; set; }

        [Key]
        [Column(Order = 139)]
        public decimal QTY1 { get; set; }

        [Key]
        [Column(Order = 140)]
        public decimal QTY2 { get; set; }

        [Key]
        [Column(Order = 141)]
        [StringLength(20)]
        public string MAKER { get; set; }

        [Key]
        [Column(Order = 142)]
        [StringLength(1)]
        public string TYPE2 { get; set; }

        [StringLength(1)]
        public string DEL_MARK { get; set; }

        public DateTime? UTIME { get; set; }

        [Key]
        [Column(Order = 143, TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] TIMESTAMP { get; set; }
    }
}
