using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class EmployeeSalarySlips
    {
        public int EmpSalarySlipId { get; set; }
        public int? EpmssUserId { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
    }
}
