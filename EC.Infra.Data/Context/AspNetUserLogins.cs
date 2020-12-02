using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class AspNetUserLogins
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }
    }
}
