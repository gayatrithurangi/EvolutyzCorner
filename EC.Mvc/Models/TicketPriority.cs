using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class TicketPriority
    {
        public int Tpid { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? Status { get; set; }
    }
}
