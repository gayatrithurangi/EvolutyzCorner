using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class UsersProfile
    {
        public int UsrPUserProfileId { get; set; }
        public int UsrPUserId { get; set; }
        public string UsrPFirstName { get; set; }
        public string UsrPLastName { get; set; }
        public string UsrPEmployeeId { get; set; }
        public string UsrPEmailId { get; set; }
        public string UsrpMobileNumber { get; set; }
        public int? UsrpCountryCode { get; set; }
        public string UsrpProfilePicture { get; set; }
        public DateTime? UsrPDob { get; set; }
        public bool? UsrPActiveStatus { get; set; }
        public short UsrPVersion { get; set; }
        public DateTime UsrPCreatedDate { get; set; }
        public int UsrPCreatedBy { get; set; }
        public DateTime? UsrPModifiedDate { get; set; }
        public int? UsrPModifiedBy { get; set; }
        public bool UsrPIsDeleted { get; set; }
        public int? UsrTitleid { get; set; }
        public int? UsrGenderId { get; set; }
        public string MaritalStatus { get; set; }
        public string PermanentAddress { get; set; }
        public string TemporaryAddress { get; set; }
        public string Passcode { get; set; }
        public DateTime? UsrpDoj { get; set; }

        public virtual Users UsrPUser { get; set; }
    }
}
