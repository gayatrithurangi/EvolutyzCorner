using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class EmployeeSalaryStructure
    {
        public int EmpsStructureId { get; set; }
        public int? EmpsUserId { get; set; }
        public int? WorkingDays { get; set; }
        public int? WorkedDays { get; set; }
        public int? Payable { get; set; }
        public DateTime? SalaryMonth { get; set; }
        public int? FinancialYearId { get; set; }
        public decimal? Ctc { get; set; }
        public bool? EssActiveStatus { get; set; }
        public int? EssVersion { get; set; }
        public DateTime? EssCreatedDate { get; set; }
        public int? EssCreatedBy { get; set; }
        public DateTime? EssModifiedDate { get; set; }
        public int? EssModifiedBy { get; set; }
        public bool? EssIsDeleted { get; set; }
    }
}
