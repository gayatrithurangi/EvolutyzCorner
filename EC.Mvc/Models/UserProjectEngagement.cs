using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class UserProjectEngagement
    {
        public int UserProjEngId { get; set; }
        public int? UserId { get; set; }
        public int? ProjectId { get; set; }
        public int? TskTaskId { get; set; }
        public int? ProjSpecificTaskId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
