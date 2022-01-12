using System;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Koala.Models {
    public partial class Recyle {
        public int Id { get; set; }
        [Display(Name = "回收序号")]
        public string SeqNo { get; set; }
        [Display(Name = "送包人")]
        public int? UserId { get; set; }
        [Display(Name = "科室/厂家")]
        public int? SectionId { get; set; }
        [Display(Name = "回收日期")]
        public DateTime? RecyleOn { get; set; }
        [Display(Name = "回收人")]
        public int? RecyleBy { get; set; }

        public virtual User User { get; set; }
        public virtual User RecyleUser { get; set; }
        public virtual Section Section { get; set; }
        [Display(Name ="包/器械")]
        public string Summary { get; set; }
        [Display(Name ="状态")]
        public string Status { get; set; }
    }
}