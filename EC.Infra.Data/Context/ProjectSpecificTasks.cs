﻿using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class ProjectSpecificTasks
    {
        public int ProjSpecificTaskId { get; set; }
        public int? ProjectId { get; set; }
        public string ProjSpecificTaskName { get; set; }
        public string Rtmid { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public DateTime? PlanStartDate { get; set; }
        public DateTime? PlanEndDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? StatusId { get; set; }
        public int? TskTaskId { get; set; }
    }
}
