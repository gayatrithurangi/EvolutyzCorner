using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class TechnologyStack
    {
        public TechnologyStack()
        {
            InterviewPositionTechnologyStack = new HashSet<InterviewPositionTechnologyStack>();
            QuestionBank = new HashSet<QuestionBank>();
        }

        public int Tid { get; set; }
        public string Title { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<InterviewPositionTechnologyStack> InterviewPositionTechnologyStack { get; set; }
        public virtual ICollection<QuestionBank> QuestionBank { get; set; }
    }
}
