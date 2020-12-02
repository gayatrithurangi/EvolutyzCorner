using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class SubPolicyDocument
    {
        public int SubPolicyDocumentId { get; set; }
        public int? SubPolicyId { get; set; }
        public string SubPolicyDocumenTitle { get; set; }
        public int? DocumentTypeId { get; set; }
        public int? ContentTypeId { get; set; }
        public string DocumentTitle { get; set; }
        public byte[] DocumentFile { get; set; }
        public bool? SubPActiveStatus { get; set; }
        public DateTime? SubPCreatedDate { get; set; }
        public int? SubPCreatedBy { get; set; }
        public DateTime? SubPModifiedDate { get; set; }
        public int? SubPModifiedBy { get; set; }
        public bool? SubPIsDeleted { get; set; }
    }
}
