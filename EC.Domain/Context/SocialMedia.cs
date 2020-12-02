using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public int? SmAccountId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public DateTime? SmCreatedDate { get; set; }
        public int? SmCreatedBy { get; set; }
        public DateTime? SmModifiedDate { get; set; }
        public int? SmModifiedBy { get; set; }
        public bool? SmIsDeleted { get; set; }
        public bool? SmActiveStatus { get; set; }
    }
}
