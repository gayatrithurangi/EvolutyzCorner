using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class HistoryUserType
    {
        public int HistoryUserTypeId { get; set; }
        public int HistoryUsTUserTypeId { get; set; }
        public int HistoryAccountId { get; set; }
        public string HistoryUsTUserTypeCode { get; set; }
        public string HistoryUsTUserType { get; set; }
        public string HistoryUsTUserTypeDescription { get; set; }
        public bool HistoryUsTActiveStatus { get; set; }
        public int HistoryUsTVersion { get; set; }
        public DateTime HistoryUsTCreatedDate { get; set; }
        public int HistoryUsTCreatedBy { get; set; }
        public DateTime? HistoryUsTModifiedDate { get; set; }
        public int? HistoryUsTModifiedBy { get; set; }
        public bool HistoryUsTIsDeleted { get; set; }
    }
}
