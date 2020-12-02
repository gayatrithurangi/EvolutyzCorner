using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class ComponentType
    {
        public int ComponentTypeId { get; set; }
        public string ComponentType1 { get; set; }
        public DateTime? ComCreatedDate { get; set; }
        public int? ComCreatedBy { get; set; }
        public DateTime? ComModifiedDate { get; set; }
        public int? ComModifiedBy { get; set; }
        public bool? ComIsDeleted { get; set; }
        public bool? ComActiveStatus { get; set; }
    }
}
