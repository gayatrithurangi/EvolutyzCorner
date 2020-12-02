using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class HistoryLeaveScheme
    {
        public int HistoryLeaveSchemeId { get; set; }
        public int HistoryLschmLeaveSchemeId { get; set; }
        public int HistoryLschmLeaveTypeId { get; set; }
        public int HistoryLschmUserTypeId { get; set; }
        public string HistoryLschmLeaveFrequency { get; set; }
        public int HistoryLschmAccountId { get; set; }
        public string HistoryLschmLeaveSchemeCode { get; set; }
        public string HistoryLschmLeaveScheme { get; set; }
        public string HistoryLschmLeaveSchemeDescription { get; set; }
        public short HistoryLschmLeaveCount { get; set; }
        public bool HistoryLschmActiveStatus { get; set; }
        public short HistoryLschmVersion { get; set; }
        public DateTime HistoryLschmCreatedDate { get; set; }
        public int HistoryLschmCreatedBy { get; set; }
        public DateTime? HistoryLschmModifiedDate { get; set; }
        public int? HistoryLschmModifiedBy { get; set; }
        public bool HistoryLschmIsDeleted { get; set; }
    }
}
