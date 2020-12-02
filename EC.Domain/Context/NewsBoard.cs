using System;
using System.Collections.Generic;

namespace EC.Domain.Context
{
    public partial class NewsBoard
    {
        public int NewsBoardId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? NewsStatus { get; set; }
        public int? AccountId { get; set; }
    }
}
