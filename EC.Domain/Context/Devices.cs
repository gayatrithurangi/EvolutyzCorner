using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class Devices
    {
        public int Id { get; set; }
        public string DeviceId { get; set; }
        public int? UserId { get; set; }
    }
}
