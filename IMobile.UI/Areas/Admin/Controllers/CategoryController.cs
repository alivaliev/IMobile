using IMobile.Business.Abstract;
using IMobile.Entities.DTO_s.CategoryDto_s;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IMobile.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var category = _categoryService.GetCategoriesByLanguage("az");
            return View(category.Data);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryCreateDto categoryCreate)
        {
            var result = _categoryService.CreateCategory(categoryCreate);
            if (result.Success)
                return RedirectToAction("Index");
            
            return View(categoryCreate);
        }
    }
}
