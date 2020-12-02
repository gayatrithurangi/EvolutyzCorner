using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class EmployeeSalarySlips
    {
        public int EmpSalarySlipId { get; set; }
        public int? EpmssUserId { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
    }
}
