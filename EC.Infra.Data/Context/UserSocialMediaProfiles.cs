using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class UserSocialMediaProfiles
    {
        public int SocialMediaProfileId { get; set; }
        public int? UsmpUserId { get; set; }
        public int? UsmpSocialMediaId { get; set; }
        public string Url { get; set; }
        public DateTime? UsmpCreatedDate { get; set; }
        public DateTime? UsmpModifiedDate { get; set; }
    }
}
