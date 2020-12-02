using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class AccSpecOptionalHolidays
    {
        public int AccSpecOptionalHolidayId { get; set; }
        public int? AccoutId { get; set; }
        public int? ProjectId { get; set; }
        public int FinancialYearId { get; set; }
        public int? NoofOptionalHolidays { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
