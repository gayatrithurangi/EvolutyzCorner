using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class HireType
    {
        public int HireTypeId { get; set; }
        public string HireType1 { get; set; }
        public string HireTypeShortForm { get; set; }
        public bool? StatusId { get; set; }
    }
}
