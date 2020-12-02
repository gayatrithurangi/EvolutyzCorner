using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class HolidayCalendar
    {
        public int HolidayCalendarId { get; set; }
        public int AccountId { get; set; }
        public string HolidayName { get; set; }
        public int Year { get; set; }
        public DateTime HolidayDate { get; set; }
        public bool IsOptionalHoliday { get; set; }
        public bool? IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
        public int? ProjectId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users ModifiedByNavigation { get; set; }
    }
}
