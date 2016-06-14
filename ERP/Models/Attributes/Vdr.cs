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
            VdrNo="0";
        }
    }

    public class VdrAttr
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string rowid { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DisplayName("廠商編號")]
        public string VdrNo { get; set; }

        [Required]
        [DisplayName("廠商名稱")]
        public string VdrNa { get; set; }

        [DisplayName("統一編號")]
        public string VdrId { get; set; }

        [DisplayName("廠商電話")]
        public string VdrTel { get; set; }

        [DisplayName("廠商報修電話")]
        public string VdrRmaTel { get; set; }

        [DisplayName("廠商業務")]
        public string VdrSalNa { get; set; }

        [DisplayName("廠商業務電話")]
        public string VdrSalTel { get; set; }

        [DisplayName("廠商報修網址")]
        public string VdrUrl { get; set; }

        [DisplayName("廠商地址")]
        public string VdrAdr { get; set; }

        [DisplayName("廠商付款日")]
        public string VdrDtPay { get; set; }

        [DisplayName("建立日期")]
        public DateTime VdrDtC { get; set; }

        [DisplayName("最後修改日期")]
        public DateTime VdrDtM { get; set; }

        [DisplayName("備註")]
        public string VdrRk { get; set; }

        [DisplayName("是否啟用")]
        public string VdrEn { get; set; }
    }
}
