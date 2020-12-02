using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class LeaveType
    {
        public int LtypLeaveTypeId { get; set; }
        public int LtypAccountId { get; set; }
        public string LtypLeaveType { get; set; }
        public string LtypLeaveTypeDescription { get; set; }
        public bool? LtypActiveStatus { get; set; }
        public short LtypVersion { get; set; }
        public DateTime LtypCreatedDate { get; set; }
        public int LtypCreatedBy { get; set; }
        public DateTime? LtypModifiedDate { get; set; }
        public int? LtypModifiedBy { get; set; }
        public bool LtypIsDeleted { get; set; }
    }
}
