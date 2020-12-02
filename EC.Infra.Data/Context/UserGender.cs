using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class UserGender
    {
        public int UsrGenderId { get; set; }
        public string Gender { get; set; }
        public int? AccAccountId { get; set; }
    }
}
