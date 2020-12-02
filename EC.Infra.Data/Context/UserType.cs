using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<Users>();
        }

        public int UsTUserTypeId { get; set; }
        public int UsTAccountId { get; set; }
        public string UsTUserTypeCode { get; set; }
        public string UsTUserType { get; set; }
        public string UsTUserTypeDescription { get; set; }
        public bool? UsTActiveStatus { get; set; }
        public int UsTVersion { get; set; }
        public DateTime UsTCreatedDate { get; set; }
        public int UsTCreatedBy { get; set; }
        public DateTime? UsTModifiedDate { get; set; }
        public int? UsTModifiedBy { get; set; }
        public bool UsTIsDeleted { get; set; }

        public virtual Account UsTAccount { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
