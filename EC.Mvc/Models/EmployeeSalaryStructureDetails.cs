using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class EmployeeSalaryStructureDetails
    {
        public int EmpssdetailId { get; set; }
        public int? EmpSalCompId { get; set; }
        public int? EmpsStructureId { get; set; }
        public bool? EssDActiveStatus { get; set; }
        public int? EssDVersion { get; set; }
        public DateTime? EssDCreatedDate { get; set; }
        public int? EssDCreatedBy { get; set; }
        public DateTime? EssDModifiedDate { get; set; }
        public int? EssDModifiedBy { get; set; }
        public bool? EssDIsDeleted { get; set; }
    }
}
