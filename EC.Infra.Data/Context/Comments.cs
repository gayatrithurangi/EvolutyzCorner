using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class Comments
    {
        public int CommentId { get; set; }
        public int? Userid { get; set; }
        public string Description { get; set; }
        public int? TicketId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public byte[] Timstamp { get; set; }
    }
}
