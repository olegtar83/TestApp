using System;
using System.Collections.Generic;

namespace TestDAL.Models
{
    public partial class BookOrders
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Id { get; set; }

        public virtual Books Book { get; set; }
        public virtual Orders Order { get; set; }
    }
}
