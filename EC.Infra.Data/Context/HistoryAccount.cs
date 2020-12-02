using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class HistoryAccount
    {
        public int HistoryAccountAccountId { get; set; }
        public int HistoryAccAccountId { get; set; }
        public string HistoryAccAccountCode { get; set; }
        public string HistoryAccAccountName { get; set; }
        public string HistoryAccAccountDescription { get; set; }
        public string HistoryAccEmailId { get; set; }
        public string HistoryAccMobileNumber { get; set; }
        public string HistoryAccPhoneNumber { get; set; }
        public string HistoryAccCompanyLogo { get; set; }
        public bool HistoryAccActiveStatus { get; set; }
        public short HistoryAccVersion { get; set; }
        public DateTime HistoryAccCreatedDate { get; set; }
        public int HistoryAccCreatedBy { get; set; }
        public DateTime? HistoryAccModifiedDate { get; set; }
        public int? HistoryAccModifiedBy { get; set; }
        public bool HistoryAccIsDeleted { get; set; }
    }
}
