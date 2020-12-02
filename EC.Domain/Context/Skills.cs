using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class Skills
    {
        public int SkillId { get; set; }
        public string SkillTitle { get; set; }
        public string ShortDescription { get; set; }
        public DateTime? SkCreatedDate { get; set; }
        public int? SkCreatedBy { get; set; }
        public DateTime? SkModifiedDate { get; set; }
        public int? SkModifiedBy { get; set; }
        public bool? SkIsDeleted { get; set; }
        public int? AccAccountId { get; set; }
        public int? StatusId { get; set; }
    }
}
