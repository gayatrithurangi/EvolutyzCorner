using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class HistoryRole
    {
        public int HistoryRoleId { get; set; }
        public int HistoryRolRoleId { get; set; }
        public int HistoryRolAccountId { get; set; }
        public string HistoryRolRoleCode { get; set; }
        public string HistoryRolRoleName { get; set; }
        public string HistoryRolRoleDescription { get; set; }
        public bool HistoryRolActiveStatus { get; set; }
        public int HistoryRolVersion { get; set; }
        public DateTime HistoryRolCreatedDate { get; set; }
        public int HistoryRolCreatedBy { get; set; }
        public DateTime? HistoryRolModifiedDate { get; set; }
        public int? HistoryRolModifiedBy { get; set; }
        public bool HistoryRolIsDeleted { get; set; }
    }
}
