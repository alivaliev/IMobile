using AutoMapper;
using IMobile.Core.DataAccess.EntityFramework;
using IMobile.Core.Utilities.Results.Abstract;
using IMobile.Core.Utilities.Results.Concrete.SuccessResults;
using IMobile.Core.Utilities.SeoHelpers;
using IMobile.DataAccess.Abstract;
using IMobile.Entities.Concrete;
using IMobile.Entities.DTO_s.ProductDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfRepositoryBase<Product, AppDbContext>, IProductDal
    {
        private readonly IMapper _mapper;

        public EfProductDal(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IResult CreateProduct(ProductCreateDto productCreate)
        {
            using var context = new AppDbContext();
            List<Picture> pictures = new();

            for (int i = 0; i < productCreate.PhotoUrls.Count; i++)
            {
                pictures.Add(new Picture { PhotoUrl = productCreate.PhotoUrls[i] });
            }

            var mapper = _mapper.Map<Product>(productCreate);
            context.Products.Add(mapper);
            context.SaveChanges();

            for (int i = 0; i < productCreate.ProductNames.Count; i++)
            {
                ProductLanguage pl = new()
                {
                    ProductId = mapper.Id,
                    ProductName = productCreate.ProductNames[i],
                    Description = productCreate.Descriptions[i],
                    SeoUrl = SeoHelper.SeoUrlCreater(productCreate.ProductNames[i]),
                    LangCode = i == 0 ? "az-Az" : i == 1 ? "en-Us" : "ru-Ru"
                };
                //context.ProductLanguages
            }


            return new SuccessResult();
        }
    }
}
