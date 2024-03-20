using IMobile.Core.Utilities.Results.Abstract;
using IMobile.Entities.DTO_s.ProductDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.Business.Abstract
{
    public interface IProductService
    {
        IResult CreateProduct(ProductCreateDto productCreate, string userId);
    }
}
