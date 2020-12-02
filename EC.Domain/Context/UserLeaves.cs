using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class UserLeaves
    {
        public int UsrlLeaveId { get; set; }
        public int? UsrlUserId { get; set; }
        public DateTime? LeaveStartDate { get; set; }
        public DateTime? LeaveEndDate { get; set; }
        public int? TotNoDays { get; set; }
        public string Comments { get; set; }
        public int? LStatusId { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public DateTime? RejectedDate { get; set; }
        public int? ApprovedBy { get; set; }
        public int? RejectedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? OnHoldDate { get; set; }
        public int? OnHoldBy { get; set; }
    }
}
