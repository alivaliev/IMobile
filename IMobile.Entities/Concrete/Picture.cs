using IMobile.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.Entities.Concrete
{
    public class Picture : IEntity
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
