using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class UsersForProjects
    {
        public int UfpUsersForProjectsId { get; set; }
        public int UfpProjectId { get; set; }
        public int UfpUserId { get; set; }
        public DateTime UfpStartDate { get; set; }
        public DateTime? UfpEndDate { get; set; }
        public int? UfpParticipationPercentage { get; set; }
        public bool? UfpActiveStatus { get; set; }
        public short UfpVersion { get; set; }
        public DateTime UfpCreatedDate { get; set; }
        public int UfpCreatedBy { get; set; }
        public DateTime? UfpModifiedDate { get; set; }
        public int? UfpModifiedBy { get; set; }
        public bool UfpIsDeleted { get; set; }
    }
}
