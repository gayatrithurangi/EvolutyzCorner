using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class MasterSubModule
    {
        public int SubModuleId { get; set; }
        public int ModModuleId { get; set; }
        public string SubModuleCode { get; set; }
        public string SubModuleName { get; set; }
        public string SubDescription { get; set; }
        public bool? SubActiveStatus { get; set; }
        public short SubVersion { get; set; }
        public DateTime SubCreatedDate { get; set; }
        public int SubCreatedBy { get; set; }
        public DateTime? SubModifiedDate { get; set; }
        public int? SubModifiedBy { get; set; }
        public bool SubIsDeleted { get; set; }
        public int? Orderby { get; set; }
    }
}
