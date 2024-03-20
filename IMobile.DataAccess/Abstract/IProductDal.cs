using IMobile.Core.DataAccess;
using IMobile.Core.Utilities.Results.Abstract;
using IMobile.Entities.Concrete;
using IMobile.Entities.DTO_s.ProductDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.DataAccess.Abstract
{
    public interface IProductDal : IRepositoryBase<Product>
    {
        IResult CreateProduct(ProductCreateDto productCreate);
    }
}
