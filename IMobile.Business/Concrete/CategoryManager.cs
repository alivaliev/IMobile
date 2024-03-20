using IMobile.Business.Abstract;
using IMobile.Core.Utilities.Results.Abstract;
using IMobile.Core.Utilities.Results.Concrete.ErrorResults;
using IMobile.Core.Utilities.Results.Concrete.SuccessResults;
using IMobile.DataAccess.Abstract;
using IMobile.Entities.DTO_s.CategoryDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult CreateCategory(CategoryCreateDto categoryCreate)
        {
            try
            {
                _categoryDal.CreateCategory(categoryCreate);
                return new SuccessResult();
            }catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IDataResult<List<CategoryForLanguageDto>> GetCategoriesByLanguage(string langcode)
        {
            try
            {
                var result = _categoryDal.GetCategoryByLanguage(langcode);
                return new SuccessDataResult<List<CategoryForLanguageDto>>(result.Data);

            }catch (Exception ex)
            {
                return new ErrorDataResult<List<CategoryForLanguageDto>>(ex.Message);   
            }
        }
    }
}
