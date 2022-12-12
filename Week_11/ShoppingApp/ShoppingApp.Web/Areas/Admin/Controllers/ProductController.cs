using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Core;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetProductsWithCategories();//productları getiriyotuz
            var productListDto = products
                .Select(p => new ProductListDto
                {
                    Product = p,
                   
                }).ToList();
           
            return View(productListDto);
        }
        [HttpGet]
        public async Task<IActionResult> Create()//yeni product eklemekiçin açılan formu açıyor
        {
            var categories = await _categoryService.GetAllAsync();
            var productAddDto = new ProductAddDto
            {
                Categories = categories//sag taraftaki kategorileri listeler
            };
            return View(productAddDto);
           
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductAddDto productAddDto)
        {
            if (ModelState.IsValid)
            {
                var url = Jobs.InitUrl(productAddDto.Name);
                var product = new Product
                {
                    
                    Name = productAddDto.Name,
                    Price = productAddDto.Price,
                    Description = productAddDto.Description,
                    Url = url,
                    IsApproved = productAddDto.IsApproved,
                    IsHome = productAddDto.IsHome,
                    ImageUrl = Jobs.UploadImage(productAddDto.ImageFile)
                };
                await _productService.CreateProductAsync(product, productAddDto.SelectedCategoryIds);
                return RedirectToAction("Index");
            }
            var categories = await _categoryService.GetAllAsync();
            productAddDto.Categories = categories;  
            return View(productAddDto);//burayı göndeirken product bilgilirini ve categori listelerini alıcak
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var product = await _productService.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            var productUpdateDto = new ProductUpdateDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                IsApproved = product.IsApproved,
                IsHome = product.IsHome,


            };
            //await _productService.GetProductWithCategories(product, productUpdateDto.SelectedCategoryIds);
            return View(productUpdateDto);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductUpdateDto productUpdateDto, int[] selectedCategoryIds)
        {
            if (ModelState.IsValid)
            {
                var product = await _productService.GetByIdAsync(productUpdateDto.Id);
                if (product == null)
                {
                    return NotFound();
                }
                product.Name = productUpdateDto.Name;
                product.Description = productUpdateDto.Description;
                product.Price=productUpdateDto.Price;
                product.IsHome = productUpdateDto.IsHome;
                product.IsApproved = productUpdateDto.IsApproved;
                product.Url = Jobs.InitUrl(productUpdateDto.Name);
                product.ImageUrl =Jobs.InitUrl(productUpdateDto.ImageUrl);

                _productService.Update(product);
                return RedirectToAction("Index");
            }
            return View(productUpdateDto);
        }


    }
}