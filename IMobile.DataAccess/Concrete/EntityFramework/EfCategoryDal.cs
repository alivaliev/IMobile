using AutoMapper;
using IMobile.Core.DataAccess.EntityFramework;
using IMobile.Core.Utilities.Results.Abstract;
using IMobile.Core.Utilities.Results.Concrete;
using IMobile.Core.Utilities.Results.Concrete.ErrorResults;
using IMobile.Core.Utilities.Results.Concrete.SuccessResults;
using IMobile.Core.Utilities.SeoHelpers;
using IMobile.DataAccess.Abstract;
using IMobile.Entities.Concrete;
using IMobile.Entities.DTO_s.CategoryDto_s;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfRepositoryBase<Category, AppDbContext>, ICategoryDal
    {
        public async Task<IResult> CreateCategory(CategoryCreateDto categoryCreate)
        {
            try
            {
                using var context = new AppDbContext();

                var category = new Category()
                {
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                };

                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();

                for (int i = 0; i < categoryCreate.CategoryName.Count; i++)
                {
                    CategoryLanguage cl = new()
                    {
                        CategoryName = categoryCreate.CategoryName[i],
                        LangCode = categoryCreate.LangCode[i],
                        CategoryId = category.Id,
                        SeoUrl = SeoHelper.SeoUrlCreater(categoryCreate.CategoryName[i])
                    };
                    await context.CategoryLanguages.AddAsync(cl);
                }
                await context.SaveChangesAsync();

                return new SuccessResult();
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IDataResult<List<CategoryForLanguageDto>> GetCategoryByLanguage(string langcode)
        {
            try
            {
                using var context = new AppDbContext();

                var result = context.CategoryLanguages
                    .Include(x => x.Category)
                    .Where(x => x.LangCode == langcode)
                    .Select(x => new CategoryForLanguageDto
                    {
                        Id = x.Id,
                        CategoryName = x.CategoryName
                    }).ToList();

                return new SuccessDataResult<List<CategoryForLanguageDto>>(result);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<CategoryForLanguageDto>>("salam");
            }
            

        }
    }
}
