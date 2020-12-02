using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class Account
    {
        public Account()
        {
            HolidayCalendar = new HashSet<HolidayCalendar>();
            Roles = new HashSet<Roles>();
            UserType = new HashSet<UserType>();
            Users = new HashSet<Users>();
        }

        public int AccAccountId { get; set; }
        public string AccAccountCode { get; set; }
        public string AccAccountName { get; set; }
        public string AccAccountDescription { get; set; }
        public string AccEmailId { get; set; }
        public string AccMobileNumber { get; set; }
        public string AccPhoneNumber { get; set; }
        public string AccCompanyLogo { get; set; }
        public bool? AccActiveStatus { get; set; }
        public short AccVersion { get; set; }
        public DateTime AccCreatedDate { get; set; }
        public int AccCreatedBy { get; set; }
        public DateTime? AccModifiedDate { get; set; }
        public int? AccModifiedBy { get; set; }
        public bool AccIsDeleted { get; set; }
        public bool IsUsAccount { get; set; }
        public bool IsPreRequisite { get; set; }

        public virtual Users AccCreatedByNavigation { get; set; }
        public virtual ICollection<HolidayCalendar> HolidayCalendar { get; set; }
        public virtual ICollection<Roles> Roles { get; set; }
        public virtual ICollection<UserType> UserType { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
