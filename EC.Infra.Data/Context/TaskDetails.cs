using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class TaskDetails
    {
        public int TaskDetailsId { get; set; }
        public int TimesheetId { get; set; }
        public int TaskId { get; set; }
        public decimal? HoursWorked { get; set; }
        public DateTime? TaskDate { get; set; }
        public int? ProjSpecificTaskId { get; set; }
        public int? Projectid { get; set; }
    }
}
