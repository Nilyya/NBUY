﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingApi.API.Model;
using ShoppingApi.Business.Abstract;
using ShoppingApi.Core;
using ShoppingApi.Entity.Concrete;

namespace ShoppingApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        //Projenizde swagger var ise tüm action metodlarımızın Http Request türü yazılmalıdır HttpGet, HttpPost gibi.

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetAllAsync();
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            var productDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                Url = product.Url,
                SelectedCategoryIds=product
                .ProductCategories
                .Select(pc=>pc.CategoryId).ToArray()
                
            };
            return Ok(productDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductDto productDto)
        {
            if (productDto == null)
            {
                return NotFound();
            }
            var product = new Product
            {
                Name = productDto.Name,
                Price = productDto.Price,
                Description = productDto.Description,
                ImageUrl = productDto.ImageUrl,
                Url = Jobs.InitUrl(productDto.Name),
             
            };
            int[] categories = new int[] { };
            await _productService.CreateProductAsync(product,categories);
            // return Ok(productDto);
            productDto.Id = product.Id;
            productDto.Url = product.Url;
            return CreatedAtAction("GetProduct", new { id = product.Id }, productDto);
        }
    }
}
