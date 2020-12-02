using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class SubPolicy
    {
        public int SubPolicyId { get; set; }
        public int? PolicyId { get; set; }
        public string SubPolicyTitle { get; set; }
        public string Icon { get; set; }
        public bool? IsCss { get; set; }
        public string Purpose { get; set; }
        public bool? SpolActiveStatus { get; set; }
        public DateTime? SpolCreatedDate { get; set; }
        public int? SpolCreatedBy { get; set; }
        public DateTime? SpolModifiedDate { get; set; }
        public int? SpolModifiedBy { get; set; }
        public bool? SpolIsDeleted { get; set; }
    }
}
