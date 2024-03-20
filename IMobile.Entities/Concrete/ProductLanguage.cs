using IMobile.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.Entities.Concrete
{
    public class ProductLanguage : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string MoreInfo { get; set; }
        public string SeoUrl { get; set; }
        public string LangCode { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
