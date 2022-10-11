using System;
using System.Collections.Generic;
using TestDAL.Interfaces;

namespace TestDAL.Models
{
    public partial class Discs: IBaseModel
    {
        public Discs()
        {
            DiscOrders = new HashSet<DiscOrders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscTypeId { get; set; }
        public int DiscContentId { get; set; }
        public decimal Price { get; set; }
        public string Barcode { get; set; }

        public virtual DiscContents DiscContent { get; set; }
        public virtual DiscTypes DiscType { get; set; }
        public virtual ICollection<DiscOrders> DiscOrders { get; set; }
    }
}
