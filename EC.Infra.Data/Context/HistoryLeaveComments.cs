using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class HistoryLeaveComments
    {
        public int HistoryCommentId { get; set; }
        public int UsrlLeaveId { get; set; }
        public int Userid { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? Action { get; set; }
        public string Comments { get; set; }
        public int? Managerid { get; set; }
    }
}
