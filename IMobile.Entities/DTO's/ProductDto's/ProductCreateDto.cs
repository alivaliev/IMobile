using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.Entities.DTO_s.ProductDto_s
{
    public class ProductCreateDto
    {
        public List<string> ProductNames { get; set; }
        public List<string> MoreInfos { get; set; }
        public List<string> Descriptions { get; set; }
        public List<string> PhotoUrls { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public int CategoryId { get; set; }
        public string UserId { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsDeleted { get; set; }
    }
}
