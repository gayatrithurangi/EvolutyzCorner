using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class ClientsBusiness
    {
        public int BusinessId { get; set; }
        public string BusinessTitle { get; set; }
        public int? AccAccountId { get; set; }
    }
}
