using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class AccountDepartments
    {
        public int AccountDepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DeptDescription { get; set; }
        public DateTime? DeptCreatedDate { get; set; }
        public int? DeptCreatedBy { get; set; }
        public DateTime? DeptModifiedDate { get; set; }
        public int? DeptModifiedBy { get; set; }
        public bool? DeptIsDeleted { get; set; }
        public bool? DeptActiveStatus { get; set; }
    }
}
