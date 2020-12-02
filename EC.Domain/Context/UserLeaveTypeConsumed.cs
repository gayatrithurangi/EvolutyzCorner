using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class UserLeaveTypeConsumed
    {
        public int UsrltTypeConsumeId { get; set; }
        public int? UsrlLeaveId { get; set; }
        public int? LschmLeaveSchemeId { get; set; }
        public int? NoOfDays { get; set; }
    }
}
