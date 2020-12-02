using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class HistoryLeaveType
    {
        public int HistoryLeaveTypeId { get; set; }
        public int HistoryLtypLeaveTypeId { get; set; }
        public int HistoryLtypAccountId { get; set; }
        public string HistoryLtypLeaveType { get; set; }
        public string HistoryLtypLeaveTypeDescription { get; set; }
        public bool HistoryLtypActiveStatus { get; set; }
        public short HistoryLtypVersion { get; set; }
        public DateTime HistoryLtypCreatedDate { get; set; }
        public int HistoryLtypCreatedBy { get; set; }
        public DateTime? HistoryLtypModifiedDate { get; set; }
        public int? HistoryLtypModifiedBy { get; set; }
        public bool HistoryLtypIsDeleted { get; set; }
    }
}
