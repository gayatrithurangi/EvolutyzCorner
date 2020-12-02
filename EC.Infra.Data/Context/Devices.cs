using System;
using System.Collections.Generic;

namespace EC.Infra.Data.Context
{
    public partial class Devices
    {
        public int Id { get; set; }
        public string DeviceId { get; set; }
        public int? UserId { get; set; }
    }
}
