using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class MobileNotificationTemplate
    {
        public int MobileNotificationId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public int? AccAccountId { get; set; }
    }
}
