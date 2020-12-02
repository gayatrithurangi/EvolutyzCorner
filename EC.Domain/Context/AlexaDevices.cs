using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class AlexaDevices
    {
        public int Id { get; set; }
        public string DeviceId { get; set; }
        public string UsrPEmployeeId { get; set; }
        public bool? IsAuthenticated { get; set; }
    }
}
