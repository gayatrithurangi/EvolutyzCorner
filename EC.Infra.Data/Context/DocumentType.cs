using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class DocumentType
    {
        public int DocumentTypeId { get; set; }
        public string DocumentTitle { get; set; }
        public string Description { get; set; }
        public bool? DocActiveStatus { get; set; }
        public DateTime? DocCreatedDate { get; set; }
        public int? DocCreatedBy { get; set; }
        public DateTime? DocModifiedDate { get; set; }
        public int? DocModifiedBy { get; set; }
        public bool? DocIsDeleted { get; set; }
    }
}
