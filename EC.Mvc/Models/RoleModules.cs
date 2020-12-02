using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class RoleModules
    {
        public int RmodRoleModuleId { get; set; }
        public int RmodAccountId { get; set; }
        public int RmodRoleId { get; set; }
        public int SubModuleId { get; set; }
        public int? ModuleAccessTypeId { get; set; }
        public bool? RmodActiveStatus { get; set; }
        public short RmodVersion { get; set; }
        public DateTime RmodCreatedDate { get; set; }
        public int RmodCreatedBy { get; set; }
        public DateTime? RmodModifiedDate { get; set; }
        public int? RmodModifiedBy { get; set; }
        public bool RmodIsDeleted { get; set; }
    }
}
