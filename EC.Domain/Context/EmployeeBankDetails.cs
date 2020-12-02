using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class EmployeeBankDetails
    {
        public int EmpBankId { get; set; }
        public int? EmpBUserId { get; set; }
        public long? BankNo { get; set; }
        public string PanNo { get; set; }
        public long? UanNo { get; set; }
        public string PfNo { get; set; }
        public string EsiNo { get; set; }
        public int? PayModeId { get; set; }
    }
}
