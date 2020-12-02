using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class Department
    {
        public Department()
        {
            Issuetypes = new HashSet<Issuetypes>();
            Tickets = new HashSet<Tickets>();
            TicketsAuthority = new HashSet<TicketsAuthority>();
        }

        public int Did { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? Status { get; set; }

        public virtual ICollection<Issuetypes> Issuetypes { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }
        public virtual ICollection<TicketsAuthority> TicketsAuthority { get; set; }
    }
}
