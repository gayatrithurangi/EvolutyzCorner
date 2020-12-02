using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class AccountClients
    {
        public int AccClientId { get; set; }
        public string ClientName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string WebsiteUrl { get; set; }
        public string IndustryId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public string PostalCode { get; set; }
        public int? AccAccountId { get; set; }
    }
}
