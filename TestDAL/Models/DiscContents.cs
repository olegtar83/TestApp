using System;
using System.Collections.Generic;

namespace TestDAL.Models
{
    public partial class DiscContents
    {
        public DiscContents()
        {
            Discs = new HashSet<Discs>();
        }

        public int Id { get; set; }
        public string DiscContentName { get; set; }

        public virtual ICollection<Discs> Discs { get; set; }
    }
}
