using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class Projects
    {
        public Projects()
        {
            ClientProjects = new HashSet<ClientProjects>();
        }

        public int ProjProjectId { get; set; }
        public int ProjAccountId { get; set; }
        public string ProjClientName { get; set; }
        public string ProjProjectCode { get; set; }
        public string ProjProjectName { get; set; }
        public string ProjProjectDescription { get; set; }
        public DateTime PlanStartDate { get; set; }
        public DateTime? PlanEndDate { get; set; }
        public bool? ProjActiveStatus { get; set; }
        public short ProjVersion { get; set; }
        public DateTime ProjCreatedDate { get; set; }
        public int ProjCreatedBy { get; set; }
        public DateTime? ProjModifiedDate { get; set; }
        public int? ProjModifiedBy { get; set; }
        public bool ProjIsDeleted { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public bool? IsTimesheetProjectSpecific { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public string WebUrl { get; set; }

        public virtual ICollection<ClientProjects> ClientProjects { get; set; }
    }
}
