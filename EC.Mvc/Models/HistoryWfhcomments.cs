using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class HistoryWfhcomments
    {
        public int HistoryWfhcommentId { get; set; }
        public int UserwfhId { get; set; }
        public int Userid { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? Action { get; set; }
        public string Comments { get; set; }
        public int? Managerid { get; set; }
    }
}
