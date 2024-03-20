using IMobile.Core.Utilities.Results.Abstract;
using IMobile.Entities.DTO_s.CategoryDto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMobile.Business.Abstract
{
    public interface ICategoryService
    {
        IResult CreateCategory(CategoryCreateDto categoryCreate);
        IDataResult<List<CategoryForLanguageDto>> GetCategoriesByLanguage(string langcode);
    }
}
