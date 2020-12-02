using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class MasterModule
    {
        public int ModModuleId { get; set; }
        public string ModModuleCode { get; set; }
        public string ModModuleName { get; set; }
        public string ModDescription { get; set; }
        public bool? ModActiveStatus { get; set; }
        public short ModVersion { get; set; }
        public DateTime ModCreatedDate { get; set; }
        public int ModCreatedBy { get; set; }
        public DateTime? ModModifiedDate { get; set; }
        public int? ModModifiedBy { get; set; }
        public bool ModIsDeleted { get; set; }
    }
}
