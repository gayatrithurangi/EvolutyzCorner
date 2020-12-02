using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class UserSkills
    {
        public int UsrSkillId { get; set; }
        public int? UsrUserId { get; set; }
        public int? SkillId { get; set; }
        public string Experience { get; set; }
        public DateTime? UskCreatedDate { get; set; }
        public DateTime? UskModifiedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public int? StatusId { get; set; }
    }
}
