using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class UserDevicesToken
    {
        public int UdTokenId { get; set; }
        public int? UserId { get; set; }
        public string TokenId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
