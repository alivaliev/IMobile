using IMobile.Business.Abstract;
using IMobile.Entities.DTO_s.ProductDto_s;
using Microsoft.AspNetCore.Mvc;

namespace IMobile.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductCreateDto productCreate)
        {
            _productService.CreateProduct(productCreate);
            return RedirectToAction("index");
        }
    }
}
