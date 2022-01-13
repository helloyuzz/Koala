using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Koala.Models {
    public partial class RequestExternalRecyle {
        [Display(Name = "序号")]
        public int Id { get; set; }
        [Display(Name = "申请单号")]
        public string RequestNo { get; set; }
        [Display(Name = "申请厂家")]
        public int? ManufacturerId { get; set; }
        [Display(Name = "送包人")]
        public int? DespatcherId { get; set; }
        [Display(Name ="申请日期")]
        public DateTime? RequestOn { get; set; }

        [Display(Name = "病人姓名")]
        public string PatientName { get; set; }
        [Display(Name = "手术日期")]
        public DateTime? OperationDate { get; set; }
        [Display(Name = "回收日期")]
        public DateTime? RecyleOn { get; set; }
        [Display(Name = "回收人")]
        public int? RecyleBy { get; set; }
        [Display(Name = "状态")]
        public string Status { get; set; }
        [Display(Name = "包/器械数量")]
        public int? PackageCount { get; set; }
        [Display(Name = "器械数量")]
        public int? InstrumentCount { get; set; }
    }
}