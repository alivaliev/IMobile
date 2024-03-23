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

        public IResult CreateProduct(ProductCreateDto productCreate, string userId)
        {
            using var context = new AppDbContext();


            Product product = new()
            {
                AppUserId = userId,
                Discount = productCreate.Discount,
                Price = productCreate.Price,
                Quantity = productCreate.Quantity,
                CategoryId = productCreate.CategoryId,
            };
            context.Products.Add(product);
            context.SaveChanges();


            List<Picture> pictures = new();
            productCreate.PhotoUrls.Add("");
            productCreate.PhotoUrls.Add("");
            productCreate.PhotoUrls.Add("");

            for (int i = 0; i < productCreate.PhotoUrls.Count; i++)
            {
                pictures.Add(new Picture { PhotoUrl = productCreate.PhotoUrls[i], ProductId = product.Id });
            }


            for (int i = 0; i < productCreate.ProductNames.Count; i++)
            {
                ProductLanguage pl = new()
                {
                    ProductId = product.Id,
                    ProductName = productCreate.ProductNames[i],
                    Description = productCreate.Descriptions[i],
                    SeoUrl = SeoHelper.SeoUrlCreater(productCreate.ProductNames[i]),
                    LangCode = i == 0 ? "az" : i == 1 ? "en" : "ru"
                };
                context.ProductLanguages.Add(pl);
            }
            context.SaveChanges();


            return new SuccessResult();
        }
    }
}
