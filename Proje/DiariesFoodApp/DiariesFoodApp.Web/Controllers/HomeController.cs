using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DiariesFoodApp.Business.Abstract;
using DiariesFoodApp.Entity.Concrete;
using DiariesFoodApp.Web.Models.Dtos;

namespace DiariesFoodApp.Web.Controllers;

public class HomeController : Controller
{
    private readonly IProductService _productManager;

    public HomeController(IProductService productManager)
    {
        _productManager = productManager;
    }

    public async Task<IActionResult> Index()
    {
        List<Product> products = await _productManager.GetHomePageFoodsAsync();
        List<ProductDto> foodDtos = new List<ProductDto>();
        foreach (var product in products)
        {
            productDtos.Add(new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
               Clue=product.Clue,
               Recipe=product.Recipe,
               Preparation=product.Preparation,
               PreparationTime=product.PreparationTime,
               BakingTime=product.BakingTime,
               Service=product.Service,
               ImageUrl=product.ImageUrl,
               Url=product.Url,

            });
        }
        return View(productDtos);
    }


}
