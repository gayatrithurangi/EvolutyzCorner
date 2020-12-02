using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class InterviewPositionTechnologyStack
    {
        public int Ipid { get; set; }
        public int? TechnologyStackId { get; set; }
        public int? AssessmentForPositionPositionid { get; set; }
        public int? NoOfQuestions { get; set; }
        public int? AssessmentTimePeriodInSec { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual AssessmentForPosition AssessmentForPositionPosition { get; set; }
        public virtual TechnologyStack TechnologyStack { get; set; }
    }
}
