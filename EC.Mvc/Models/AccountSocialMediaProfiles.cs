using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class AccountSocialMediaProfiles
    {
        public int AccSocialMediaProfileId { get; set; }
        public int? AsmpAccountId { get; set; }
        public int? AsmpSocialMediaId { get; set; }
        public string Url { get; set; }
        public DateTime? AsmpCreatedDate { get; set; }
        public DateTime? AsmpModifiedDate { get; set; }
    }
}
