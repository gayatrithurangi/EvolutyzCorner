using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class GenericRoles
    {
        public int GenericRoleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? StatusId { get; set; }
    }
}
