using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class Users
    {
        public Users()
        {
            Account = new HashSet<Account>();
            HolidayCalendarCreatedByNavigation = new HashSet<HolidayCalendar>();
            HolidayCalendarModifiedByNavigation = new HashSet<HolidayCalendar>();
            UsersProfile = new HashSet<UsersProfile>();
        }

        public int UsrUserId { get; set; }
        public int UsrAccountId { get; set; }
        public int UsrUserTypeId { get; set; }
        public int UsrRoleId { get; set; }
        public string UsrUsername { get; set; }
        public string UsrLoginId { get; set; }
        public string UsrPassword { get; set; }
        public bool? UsrActiveStatus { get; set; }
        public int? UsrTaskId { get; set; }
        public short UsrVersion { get; set; }
        public string UsrSalt { get; set; }
        public int? UsrManager { get; set; }
        public int? UsrManager2 { get; set; }
        public DateTime UsrCreatedDate { get; set; }
        public int? UsrCreatedBy { get; set; }
        public DateTime? UsrModifiedDate { get; set; }
        public int? UsrModifiedBy { get; set; }
        public bool UsrIsDeleted { get; set; }
        public string UrlToken { get; set; }

        public virtual Account UsrAccount { get; set; }
        public virtual UserType UsrUserType { get; set; }
        public virtual ICollection<Account> Account { get; set; }
        public virtual ICollection<HolidayCalendar> HolidayCalendarCreatedByNavigation { get; set; }
        public virtual ICollection<HolidayCalendar> HolidayCalendarModifiedByNavigation { get; set; }
        public virtual ICollection<UsersProfile> UsersProfile { get; set; }
    }
}
