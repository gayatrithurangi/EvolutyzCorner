using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class HistoryUsers
    {
        public int HistoryUserId { get; set; }
        public int HistoryUsrUserId { get; set; }
        public int HistoryUsrAccountId { get; set; }
        public int HistoryUsrUserTypeId { get; set; }
        public int HistoryUsrRoleId { get; set; }
        public int? HistoryUsrManager { get; set; }
        public int? HistoryUsrManager2 { get; set; }
        public string HistoryUsrUsername { get; set; }
        public string HistoryUsrLoginId { get; set; }
        public string HistoryUsrPassword { get; set; }
        public bool HistoryUsrActiveStatus { get; set; }
        public int? HistoryUsrTaskId { get; set; }
        public short HistoryUsrVersion { get; set; }
        public DateTime HistoryUsrCreatedDate { get; set; }
        public int? HistoryUsrCreatedBy { get; set; }
        public DateTime? HistoryUsrModifiedDate { get; set; }
        public int? HistoryUsrModifiedBy { get; set; }
        public bool HistoryUsrIsDeleted { get; set; }
    }
}
