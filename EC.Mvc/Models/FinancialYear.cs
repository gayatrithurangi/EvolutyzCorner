using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class FinancialYear
    {
        public int FinancialYearId { get; set; }
        public int? StartDate { get; set; }
        public int? EndDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
