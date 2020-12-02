using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class ClientProjectsTasks
    {
        public int ClProjectsTasksId { get; set; }
        public int? Accountid { get; set; }
        public int? RolRoleid { get; set; }
        public int? AccSpecifictaskid { get; set; }
    }
}
