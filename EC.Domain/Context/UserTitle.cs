using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class UserTitle
    {
        public int UsrTitleid { get; set; }
        public string TitlePrefix { get; set; }
        public int? AccAccountId { get; set; }
    }
}
