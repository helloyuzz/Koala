using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Koala.Models {
    public partial class RequestRecyle {
        public int Id { get; set; }
        [Display(Name ="申请单号")]
        public string RecyleNo { get; set; }
        [Display(Name = "申请日期")]
        public DateTime? RequestOn { get; set; }
        [Display(Name = "申请科室")]
        public int? SectionId { get; set; }
        [Display(Name = "申请人")]
        public int? RequestBy { get; set; }
        [Display(Name = "回收日期")]
        public DateTime? RecyleOn { get; set; }
        [Display(Name = "回收人")]
        public int? RecyleBy { get; set; }
        [Display(Name = "状态")]
        public string Status { get; set; }
        [Display(Name = "包/器械数量")]
        public int? PackageCount { get; set; }
        [Display(Name = "申请单号")]
        public int? InstrumentCount { get; set; }
    }
}