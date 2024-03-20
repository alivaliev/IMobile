using IMobile.Business.Abstract;
using IMobile.Entities.DTO_s.ProductDto_s;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace IMobile.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IHttpContextAccessor _contextAccessor;

        public ProductController(IProductService productService, ICategoryService categoryService, IHttpContextAccessor contextAccessor)
        {
            _productService = productService;
            _categoryService = categoryService;
            _contextAccessor = contextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            var categories = _categoryService.GetCategoriesByLanguage("az");
            ViewBag.Categories = new SelectList(categories.Data,"Id","CategoryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductCreateDto productCreate)
        {
            var userId = _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value; 
            _productService.CreateProduct(productCreate, userId);
            return RedirectToAction("index");
        }
    }
}
