using System;
using System.Collections.Generic;

namespace TestDAL.Models
{
    public partial class OrderStatuses
    {
        public OrderStatuses()
        {
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string OrderStatus { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
