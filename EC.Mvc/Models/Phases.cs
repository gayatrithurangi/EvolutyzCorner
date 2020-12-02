using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class Phases
    {
        public int PhaseId { get; set; }
        public string PhaseTitle { get; set; }
        public string ShortDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
