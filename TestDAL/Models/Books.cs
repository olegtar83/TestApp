using System;
using System.Collections.Generic;
using TestDAL.Interfaces;

namespace TestDAL.Models
{
    public partial class Books : IBaseModel
    {
        public Books()
        {
            BookOrders = new HashSet<BookOrders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public int BookTypeId { get; set; }
        public string ExtraData { get; set; }
        public int PageCount { get; set; }

        public virtual BookTypes BookType { get; set; }
        public virtual ICollection<BookOrders> BookOrders { get; set; }
    }
}
