using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class Issuetypes
    {
        public int Itid { get; set; }
        public int? DepartmentId { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? Status { get; set; }

        public virtual Department Department { get; set; }
    }
}
