using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class AttachmentsinTimesheets
    {
        public int AttachmentId { get; set; }
        public int? TimeSheetId { get; set; }
        public int? UserId { get; set; }
        public string UploadedImages { get; set; }

        public virtual Timesheet TimeSheet { get; set; }
    }
}
