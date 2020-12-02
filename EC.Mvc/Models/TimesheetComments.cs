using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class TimesheetComments
    {
        public int TimesheetCommentId { get; set; }
        public int Timesheetid { get; set; }
        public int Userid { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? Action { get; set; }
        public string Comments { get; set; }
        public int? ManageridL1 { get; set; }
        public int? ManageridL2 { get; set; }
    }
}
