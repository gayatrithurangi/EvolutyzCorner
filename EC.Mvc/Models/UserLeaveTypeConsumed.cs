using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class UserLeaveTypeConsumed
    {
        public int UsrltTypeConsumeId { get; set; }
        public int? UsrlLeaveId { get; set; }
        public int? LschmLeaveSchemeId { get; set; }
        public int? NoOfDays { get; set; }
    }
}
