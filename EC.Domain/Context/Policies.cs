using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class Policies
    {
        public int PolicyId { get; set; }
        public string PolicyTitle { get; set; }
        public string Icon { get; set; }
        public bool? IsCss { get; set; }
        public string PolicyDescription { get; set; }
        public bool? PolActiveStatus { get; set; }
        public DateTime? PolCreatedDate { get; set; }
        public int? PolCreatedBy { get; set; }
        public DateTime? PolModifiedDate { get; set; }
        public int? PolModifiedBy { get; set; }
        public bool? PolIsDeleted { get; set; }
    }
}
