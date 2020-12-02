using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class ContentType
    {
        public int ContentTypeId { get; set; }
        public string ContentTitle { get; set; }
        public string Description { get; set; }
        public bool? ConActiveStatus { get; set; }
        public DateTime? ConCreatedDate { get; set; }
        public int? ConCreatedBy { get; set; }
        public DateTime? ConModifiedDate { get; set; }
        public int? ConModifiedBy { get; set; }
        public bool? ConIsDeleted { get; set; }
    }
}
