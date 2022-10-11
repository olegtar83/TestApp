using System;
using System.Collections.Generic;
using System.Text;

namespace TestServices.DTO
{
    public class DiscDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DiscTypeId { get; set; }
        public string DiscType { get; set; }
        public int DiscContentId { get; set; }
        public string DiscContent { get; set; }
        public decimal Price { get; set; }
        public string Barcode { get; set; }
    }
}
