using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class EmployeeSalaryComponent
    {
        public int EmpSalCompId { get; set; }
        public int? EmpScAccountId { get; set; }
        public string ComponentTitle { get; set; }
        public string ComponentDescription { get; set; }
        public int? ComponentTypeId { get; set; }
        public bool? EmpScActiveStatus { get; set; }
        public int? EmpScVersion { get; set; }
        public DateTime? EmpScCreatedDate { get; set; }
        public int? EmpScCreatedBy { get; set; }
        public DateTime? EmpScModifiedDate { get; set; }
        public int? EmpScModifiedBy { get; set; }
        public bool? EmpScIsDeleted { get; set; }
    }
}
