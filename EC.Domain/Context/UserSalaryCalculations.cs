using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class UserSalaryCalculations
    {
        public int UserSalaryCalculationsId { get; set; }
        public string UserName { get; set; }
        public int HireType { get; set; }
        public int? VisaType { get; set; }
        public string AnnualSalary { get; set; }
        public string AnnualSalaryPerhour { get; set; }
        public string PayrollTaxes { get; set; }
        public string PayrollTaxesPerHour { get; set; }
        public string H1bfee { get; set; }
        public string H1bfeePerHour { get; set; }
        public string Gcfee { get; set; }
        public string GcfeePerHour { get; set; }
        public string Insurance { get; set; }
        public string InsurancePerHour { get; set; }
        public string _2weeksPaidVocation { get; set; }
        public string _2weeksPaidVocationPerHour { get; set; }
        public string Holidays { get; set; }
        public string HolidaysPerHour { get; set; }
        public string AdministrativeCost { get; set; }
        public string AdministrativeCostPerHour { get; set; }
        public string Relocation { get; set; }
        public string RelocationPerHour { get; set; }
        public string PaidBench { get; set; }
        public string PaidBenchPerHour { get; set; }
        public string Bonus { get; set; }
        public string BonusPerHour { get; set; }
        public string Total { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
