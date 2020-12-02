using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class CandidateInterviewResult
    {
        public int Cirid { get; set; }
        public int? Candidateid { get; set; }
        public int? Questionid { get; set; }
        public int? Status { get; set; }
        public int? SelectedOption { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string Descriptionforoptionchoosen { get; set; }

        public virtual InterviewCandidate Candidate { get; set; }
    }
}
