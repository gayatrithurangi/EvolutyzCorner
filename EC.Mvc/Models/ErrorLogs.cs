using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class ErrorLogs
    {
        public int ErrorlogId { get; set; }
        public string SourceName { get; set; }
        public string MethodName { get; set; }
        public string ErrorMessage { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
