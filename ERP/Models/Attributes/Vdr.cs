using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Models
{
    [MetadataType(typeof(VdrAttr))]
    public partial class Vdr
    {
        public Vdr()
        {
            VdrNo = "0";
            VdrEn = true;
        }
    }

    public class VdrAttr
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string rowid { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DisplayName("廠商編號")]
        public string VdrNo { get; set; }

        [Required]
        [DisplayName("廠商名稱")]
        public string VdrNa { get; set; }

        [DisplayName("廠商統編")]
        [MaxLength(8, ErrorMessage = "統編長度太長")]
        [MinLength(1, ErrorMessage = "統編長度太短")]
        public string VdrId { get; set; }

        [DisplayName("廠商電話")]
        [RegularExpression(@"^(\d{0,4}-)?\d{6,10}$", ErrorMessage = "不符合電話格式")]
        public string VdrTel { get; set; }

        [DisplayName("廠商報修電話")]
        [RegularExpression(@"^(\d{0,4}-)?\d{6,10}$", ErrorMessage = "不符合電話格式")]
        public string VdrRmaTel { get; set; }

        [DisplayName("廠商業務")]
        [MaxLength(20, ErrorMessage = "內容過長")]
        public string VdrSalNa { get; set; }

        [DisplayName("廠商業務電話")]
        [RegularExpression(@"^(\d{0,4}-)?\d{6,10}$", ErrorMessage = "不符合電話格式")]
        public string VdrSalTel { get; set; }

        [DisplayName("廠商報修網址")]
        [MaxLength(100, ErrorMessage = "內容過長")]
        public string VdrUrl { get; set; }

        [DisplayName("廠商地址")]
        [MaxLength(100, ErrorMessage = "內容過長")]
        public string VdrAdr { get; set; }

        [DisplayName("廠商付款日")]
        public string VdrDtPay { get; set; }

        [DisplayName("建立日期")]
        public DateTime VdrDtC { get; set; }

        [DisplayName("修改日期")]
        public DateTime VdrDtM { get; set; }

        [DisplayName("備註")]
        [MaxLength(500, ErrorMessage = "內容過長")]
        public string VdrRk { get; set; }

        [DisplayName("啟用")]
        public bool VdrEn { get; set; }
    }
}
