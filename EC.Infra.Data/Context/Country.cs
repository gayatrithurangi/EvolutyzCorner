using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class Country
    {
        public int CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string PhoneCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public bool? StatusId { get; set; }
        public bool? IsActive { get; set; }
    }
}
