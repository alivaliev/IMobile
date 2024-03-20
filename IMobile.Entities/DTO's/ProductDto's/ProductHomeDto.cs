using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.Entities.DTO_s.ProductDto_s
{
    public class ProductHomeDto
    {
        public string ProductName { get; set; }
        public string PhotoUrl { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
