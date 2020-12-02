using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class AccountSpecificTasks
    {
        public int AccSpecificTaskId { get; set; }
        public int? AccountId { get; set; }
        public string AccSpecificTaskName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? StatusId { get; set; }
        public int? TskTaskId { get; set; }
    }
}
