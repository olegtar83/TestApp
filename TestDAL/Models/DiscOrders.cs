using System;
using System.Collections.Generic;

namespace TestDAL.Models
{
    public partial class DiscOrders
    {
        public int OrderId { get; set; }
        public int DiscId { get; set; }
        public int Id { get; set; }

        public virtual Discs Disc { get; set; }
        public virtual Orders Order { get; set; }
    }
}
