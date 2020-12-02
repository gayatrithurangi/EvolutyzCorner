using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class QuestionBank
    {
        public int Qbid { get; set; }
        public int? TechnologyStackId { get; set; }
        public string Question { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public int? Answer { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual TechnologyStack TechnologyStack { get; set; }
    }
}
