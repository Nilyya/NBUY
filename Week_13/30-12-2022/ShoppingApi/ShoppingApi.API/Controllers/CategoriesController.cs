using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoppingApi.API.Model;
using ShoppingApi.Business.Abstract;

namespace ShoppingApi.API.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;

        public CategoriesController(ICategoryService categoryService, IProductService productService)
        {
            _categoryService = categoryService;
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var categories = await _categoryService.GetAllAsync();
            List<CategoryDto> categoryDtos = new List<CategoryDto>();
            foreach (var category in categories)
            {
                categoryDtos.Add(new CategoryDto
                {
                    Id = category.Id,
                    Name = category.Name,
                    Description = category.Description,
                    Url = category.Url
                });
            }

            return Ok(categoryDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductsByCategory(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            var products = await _productService.GetProductsByCategoryAsync(category.Url);
            List<ProductDto> productDtos = new List<ProductDto>();
            foreach (var product in products)
            {
                productDtos.Add(new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    ImageUrl = product.ImageUrl,
                    Url = product.Url
                });
            }
            return Ok(productDtos);
        }
    }
}