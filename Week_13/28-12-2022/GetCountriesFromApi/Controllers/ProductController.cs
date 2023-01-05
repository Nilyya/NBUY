using Microsoft.AspNetCore.Mvc;
using DiariesFoodApp.Business.Abstract;
using DiariesFoodApp.Entity.Concrete;
using DiariesFoodApp.Web.Models.Dtos;

namespace DiariesFoodApp.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productManager;

        public ProductController(IProductService productManager)
        {
            _productManager = productManager;
        }

        public async Task<IActionResult> ProductList(string categoryurl)
        {
            List<Product> products = await _productManager.GetProductsByCategoryAsync(categoryurl);
            List<ProductDto> productDtos = new List<ProductDto>();
            foreach (var product in products)
            {
                productDtos.Add(new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Clue = product.Clue,
                    Recipe = product.Recipe,
                    Preparation = product.Preparation,
                    PreparationTime = product.PreparationTime,
                    BakingTime = product.BakingTime,
                    Service = product.Service,
                    ImageUrl = product.ImageUrl,
                    Url = product.Url,


                });
            }
            return View(productDtos);
        }

        public async Task<IActionResult> ProductDetails(string producturl)
        {
            if (producturl == null)
            {
                return NotFound();
            }
            var product = await _productManager.GetProductDetailsByUrlAsync(producturl);
            ProductDetailsDto productDetailsDto = new ProductDetailsDto
            {
                Id = product.Id,
                Name = product.Name,
                ImageUrl = product.ImageUrl,
                Url = product.Url,              
                Categories = product
                    .FoodCategories
                    .Select(fc => fc.Category)
                    .ToList()
            };
            return View(productDetailsDto);
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
