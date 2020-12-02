using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class LeaveScheme
    {
        public int LschmLeaveSchemeId { get; set; }
        public int LschmLeaveTypeId { get; set; }
        public int LschmUserTypeId { get; set; }
        public string LschmLeaveFrequency { get; set; }
        public int LschmAccountId { get; set; }
        public string LschmLeaveSchemeCode { get; set; }
        public string LschmLeaveScheme { get; set; }
        public string LschmLeaveSchemeDescription { get; set; }
        public double? LschmLeaveCount { get; set; }
        public bool LschmActiveStatus { get; set; }
        public short? LschmVersion { get; set; }
        public DateTime LschmCreatedDate { get; set; }
        public int LschmCreatedBy { get; set; }
        public DateTime? LschmModifiedDate { get; set; }
        public int? LschmModifiedBy { get; set; }
        public bool LschmIsDeleted { get; set; }
        public int? FinancialYearId { get; set; }
    }
}
