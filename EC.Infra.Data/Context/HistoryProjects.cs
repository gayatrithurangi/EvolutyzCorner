using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class HistoryProjects
    {
        public int HistoryProjectId { get; set; }
        public int HistoryProjProjectId { get; set; }
        public int HistoryProjAccountId { get; set; }
        public string HistoryProjProjectCode { get; set; }
        public string HistoryProjProjectName { get; set; }
        public string HistoryProjProjectDescription { get; set; }
        public DateTime HistoryProjStartDate { get; set; }
        public DateTime? HistoryProjEndDate { get; set; }
        public bool HistoryProjActiveStatus { get; set; }
        public short HistoryProjVersion { get; set; }
        public DateTime HistoryProjCreatedDate { get; set; }
        public int HistoryProjCreatedBy { get; set; }
        public DateTime? HistoryProjModifiedDate { get; set; }
        public int? HistoryProjModifiedBy { get; set; }
        public bool HistoryProjIsDeleted { get; set; }
    }
}
