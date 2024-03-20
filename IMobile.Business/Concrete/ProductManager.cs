using AutoMapper;
using IMobile.Business.Abstract;
using IMobile.Core.Utilities.Results.Abstract;
using IMobile.Core.Utilities.Results.Concrete.SuccessResults;
using IMobile.DataAccess.Abstract;
using IMobile.Entities.Concrete;
using IMobile.Entities.DTO_s.ProductDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IMapper _mapper;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        public IResult CreateProduct(ProductCreateDto productCreate)
        {
            _productDal.CreateProduct(productCreate);
            return new SuccessResult();
        }
    }
}
