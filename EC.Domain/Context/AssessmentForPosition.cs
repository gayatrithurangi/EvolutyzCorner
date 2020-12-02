using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class AssessmentForPosition
    {
        public AssessmentForPosition()
        {
            InterviewCandidate = new HashSet<InterviewCandidate>();
            InterviewPositionTechnologyStack = new HashSet<InterviewPositionTechnologyStack>();
        }

        public int Apid { get; set; }
        public string InterviewForPositionname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<InterviewCandidate> InterviewCandidate { get; set; }
        public virtual ICollection<InterviewPositionTechnologyStack> InterviewPositionTechnologyStack { get; set; }
    }
}
