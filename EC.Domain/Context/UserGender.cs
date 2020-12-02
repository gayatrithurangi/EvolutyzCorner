using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class UserGender
    {
        public int UsrGenderId { get; set; }
        public string Gender { get; set; }
        public int? AccAccountId { get; set; }
    }
}
