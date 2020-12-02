using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class TicketImages
    {
        public int Tiid { get; set; }
        public string ImageName { get; set; }
        public int? TicketId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Tickets Ticket { get; set; }
    }
}
