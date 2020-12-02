using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class UserProjects
    {
        public int UprojUserProjectId { get; set; }
        public int UprojProjectId { get; set; }
        public int UprojUserId { get; set; }
        public DateTime UprojStartDate { get; set; }
        public DateTime? UprojEndDate { get; set; }
        public byte UprojParticipationPercentage { get; set; }
        public bool UprojActiveStatus { get; set; }
        public short UprojVersion { get; set; }
        public DateTime UprojCreatedDate { get; set; }
        public int UprojCreatedBy { get; set; }
        public DateTime? UprojModifiedDate { get; set; }
        public int? UprojModifiedBy { get; set; }
        public bool UprojIsDeleted { get; set; }
        public int? UprojL1ManagerId { get; set; }
        public int? UprojL2ManagerId { get; set; }
        public bool? IsL1Manager { get; set; }
        public bool? IsL2Manager { get; set; }
        public int? ClientprojId { get; set; }
        public int? TimesheetMode { get; set; }
        public bool? IsDirectManager { get; set; }
        public bool? Isclientcalendar { get; set; }
    }
}
