using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class ClientProjects
    {
        public int ClProjectId { get; set; }
        public int? ProjProjectId { get; set; }
        public int? Accountid { get; set; }
        public string ClientProjTitle { get; set; }
        public string ClientProjDesc { get; set; }

        public virtual Projects ProjProject { get; set; }
    }
}
