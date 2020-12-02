using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class ModuleAccessType
    {
        public int ModuleAccessTypeId { get; set; }
        public string ModuleAccessType1 { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? StatusId { get; set; }
    }
}
