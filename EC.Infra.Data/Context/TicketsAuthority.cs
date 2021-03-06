﻿using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class TicketsAuthority
    {
        public int Taid { get; set; }
        public int? DepartmentId { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? Status { get; set; }

        public virtual Department Department { get; set; }
    }
}
