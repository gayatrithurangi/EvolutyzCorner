using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class ProjectWorkstatus
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string UserName { get; set; }
        public DateTime? FromDt { get; set; }
        public DateTime? ToDt { get; set; }
        public string PercentageCompleted { get; set; }
    }
}
