using AutoMapper;
using IMobile.Core.DataAccess.EntityFramework;
using IMobile.Core.Utilities.Results.Abstract;
using IMobile.Core.Utilities.Results.Concrete.ErrorResults;
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

            var category = context.Categories.FirstOrDefault(c => c.Id == productCreate.CategoryId);
            // if (category == null)
            // {
            //     // Handle the case where the CategoryId does not exist
            //     return new ErrorResult("Invalid CategoryId");
            // }
            List<Picture> pictures = new();
            productCreate.PhotoUrls.Add("");
            productCreate.PhotoUrls.Add("");
            productCreate.PhotoUrls.Add("");

            for (int i = 0; i < productCreate.PhotoUrls.Count; i++)
            {
                pictures.Add(new Picture { PhotoUrl = productCreate.PhotoUrls[i] });
            }

            Product product = new()
            {
                AppUserId = userId,
                Discount = productCreate.Discount,
                CategoryId = productCreate.CategoryId,
                Price = productCreate.Price,
                Quantity = productCreate.Quantity,
                Pictures = pictures,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };
            context.Products.Add(product);
            context.SaveChanges();



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
                    MoreInfo = "Asskjdfakls",
                    LangCode = i == 0 ? "az" : i == 1 ? "en" : "ru"
                };
                context.ProductLanguages.Add(pl);
            }
            context.SaveChanges();


            return new SuccessResult();
        }
    }
}
