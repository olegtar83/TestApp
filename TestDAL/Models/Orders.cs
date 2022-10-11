using System;
using System.Collections.Generic;

namespace TestDAL.Models
{
    public partial class Orders
    {
        public Orders()
        {
            BookOrders = new HashSet<BookOrders>();
            DiscOrders = new HashSet<DiscOrders>();
        }

        public int Id { get; set; }
        public int OrderStatusId { get; set; }
        public string ClientEmail { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual OrderStatuses OrderStatus { get; set; }
        public virtual ICollection<BookOrders> BookOrders { get; set; }
        public virtual ICollection<DiscOrders> DiscOrders { get; set; }
    }
}
