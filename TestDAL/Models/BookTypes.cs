using System;
using System.Collections.Generic;

namespace TestDAL.Models
{
    public partial class BookTypes
    {
        public BookTypes()
        {
            Books = new HashSet<Books>();
        }

        public int Id { get; set; }
        public string BookTypeName { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
