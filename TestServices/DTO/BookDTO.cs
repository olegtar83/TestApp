using System;
using System.Collections.Generic;
using System.Text;

namespace TestServices.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Barcode { get; set; }
        public int BookTypeId { get; set; }
        public string ExtraData { get; set; }
        public int PageCount { get; set; }
        public string BookType { get; set; }
    }
}
