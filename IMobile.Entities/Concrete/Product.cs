using IMobile.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsDeleted { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProductLanguage> ProductLanguages { get; set; }
        public List<Picture> Pictures { get; set; }
    }
}
