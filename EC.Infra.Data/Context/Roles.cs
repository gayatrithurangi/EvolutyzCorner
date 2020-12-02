using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class Roles
    {
        public int RolRoleId { get; set; }
        public int RolAccountId { get; set; }
        public string RolRoleCode { get; set; }
        public int? RolRoleName { get; set; }
        public string RolRoleDescription { get; set; }
        public bool? RolActiveStatus { get; set; }
        public int RolVersion { get; set; }
        public DateTime RolCreatedDate { get; set; }
        public int RolCreatedBy { get; set; }
        public DateTime? RolModifiedDate { get; set; }
        public int? RolModifiedBy { get; set; }
        public bool RolIsDeleted { get; set; }
        public bool? IsManagerRole { get; set; }

        public virtual Account RolAccount { get; set; }
    }
}
