using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class HistoryUserProjects
    {
        public int HuprojUserProjectId { get; set; }
        public int HuprojProjectId { get; set; }
        public int HuprojUserId { get; set; }
        public DateTime HuprojStartDate { get; set; }
        public DateTime? HuprojEndDate { get; set; }
        public byte HuprojParticipationPercentage { get; set; }
        public bool HuprojActiveStatus { get; set; }
        public short HuprojVersion { get; set; }
        public DateTime HuprojCreatedDate { get; set; }
        public int HuprojCreatedBy { get; set; }
        public DateTime? HuprojModifiedDate { get; set; }
        public int? HuprojModifiedBy { get; set; }
        public bool HuprojIsDeleted { get; set; }
    }
}
