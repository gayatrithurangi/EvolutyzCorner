using System;
using System.Collections.Generic;

namespace EC.Mvc.Models
{
    public partial class States
    {
        public int StateId { get; set; }
        public int Countryid { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? StatusId { get; set; }
    }
}
