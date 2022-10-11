using System;
using System.Collections.Generic;

namespace TestDAL.Models
{
    public partial class DiscTypes
    {
        public DiscTypes()
        {
            Discs = new HashSet<Discs>();
        }

        public int Id { get; set; }
        public string DiscTypeName { get; set; }

        public virtual ICollection<Discs> Discs { get; set; }
    }
}
