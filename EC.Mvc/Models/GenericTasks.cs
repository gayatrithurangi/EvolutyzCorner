using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class GenericTasks
    {
        public int TskTaskId { get; set; }
        public string TskTaskName { get; set; }
        public string TskTaskDescription { get; set; }
        public bool TskActiveStatus { get; set; }
        public short TskVersion { get; set; }
        public DateTime TskCreatedDate { get; set; }
        public int TskCreatedBy { get; set; }
        public DateTime? TskModifiedDate { get; set; }
        public int? TskModifiedBy { get; set; }
        public bool? TskIsDeleted { get; set; }
        public int? AccAccountId { get; set; }
    }
}
