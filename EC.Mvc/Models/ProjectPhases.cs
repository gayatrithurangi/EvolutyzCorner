using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class ProjectPhases
    {
        public int ProjPhaseId { get; set; }
        public int? PhaseId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanEndDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
