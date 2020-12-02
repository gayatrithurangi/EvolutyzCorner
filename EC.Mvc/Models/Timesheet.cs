using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class Timesheet
    {
        public Timesheet()
        {
            AttachmentsinTimesheets = new HashSet<AttachmentsinTimesheets>();
        }

        public int TimesheetId { get; set; }
        public int UserId { get; set; }
        public DateTime? TaskDate { get; set; }
        public DateTime TimesheetMonth { get; set; }
        public string Comments { get; set; }
        public DateTime CreatedDate { get; set; }
        public string TaskId { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public bool? SubmittedType { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string L1Manager { get; set; }
        public int? L1ApproverStatus { get; set; }
        public DateTime? L1ApproverDate { get; set; }
        public DateTime? L1RejectedDate { get; set; }
        public string L2Manager { get; set; }
        public int? L2ApproverStatus { get; set; }
        public DateTime? L2ApproverDate { get; set; }
        public DateTime? L2RejectedDate { get; set; }
        public int? DeviceTypeId { get; set; }
        public DateTime? ByWeeklyStartDate { get; set; }
        public DateTime? ByWeeklyEndDate { get; set; }
        public int? ClientProjtId { get; set; }

        public virtual ICollection<AttachmentsinTimesheets> AttachmentsinTimesheets { get; set; }
    }
}
