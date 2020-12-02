using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class UserGender
    {
        public int UsrGenderId { get; set; }
        public string Gender { get; set; }
        public int? AccAccountId { get; set; }
    }
}
