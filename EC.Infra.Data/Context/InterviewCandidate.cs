using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class InterviewCandidate
    {
        public InterviewCandidate()
        {
            CandidateInterviewResult = new HashSet<CandidateInterviewResult>();
        }

        public int Icid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Emailid { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }
        public int? AssessmentForPositionid { get; set; }
        public int? RecrutementUserid { get; set; }
        public DateTime? AssessmentDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? Status { get; set; }
        public string AssessmentTime { get; set; }

        public virtual AssessmentForPosition AssessmentForPosition { get; set; }
        public virtual ICollection<CandidateInterviewResult> CandidateInterviewResult { get; set; }
    }
}
