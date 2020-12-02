using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class VisaType
    {
        public int VisaTypeId { get; set; }
        public string VisaType1 { get; set; }
        public string VisaTypeShortForm { get; set; }
        public bool? StatusId { get; set; }
    }
}
