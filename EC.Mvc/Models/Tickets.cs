using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class Tickets
    {
        public Tickets()
        {
            TicketImages = new HashSet<TicketImages>();
        }

        public int Tid { get; set; }
        public int? DepartmentId { get; set; }
        public string Description { get; set; }
        public int? TypeOfIssue { get; set; }
        public DateTime? TicketRaiseDate { get; set; }
        public DateTime? TicketForecastDate { get; set; }
        public DateTime? TicketClosedDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? Priority { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<TicketImages> TicketImages { get; set; }
    }
}
