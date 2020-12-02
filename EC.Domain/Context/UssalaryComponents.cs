using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class UssalaryComponents
    {
        public int UssalaryComponentId { get; set; }
        public string UssalaryComponent { get; set; }
        public string UssalaryComponentValue { get; set; }
        public bool? StatusId { get; set; }
    }
}
