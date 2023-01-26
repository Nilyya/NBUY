using DiariesFood.Business.Abstract;
using DiariesFood.Entity.Concrete;
using DiariesFood.Web.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DiariesFood.Web.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodService _foodManager;

        public FoodController(IFoodService foodManager)
        {
            _foodManager = foodManager;
        }

        public async Task<IActionResult> FoodList(string categoryurl)
        {
            List<Food> foods = await _foodManager.GetFoodsByCategoryAsync(categoryurl);
            List<FoodDto> foodDtos = new List<FoodDto>();
            foreach (var food in foods)
            {
                foodDtos.Add(new FoodDto
                {
                    Id = food.Id,
                    CatId=food.CatId,
                    Name = food.Name,
                    Clue = food.Clue,
                    Repice = food.Repice,
                    Preparation = food.Preparation,
                    PreparationTime = food.PreparationTime,
                    BakingTime = food.BakingTime,
                    Service = food.Service,
                    ImageUrl = food.ImageUrl,
                    Url = food.Url,


                });
            }
            return View(foodDtos);
        }

        public async Task<IActionResult> FoodDetails(string foodurl)
        {
            if (foodurl == null)
            {
                return NotFound();
            }
            var food = await _foodManager.GetFoodDetailsByUrlAsync(foodurl);
            FoodDetailsDto foodDetailsDto = new FoodDetailsDto
            {
                Id = food.Id,
                Name = food.Name,
                Clue=food.Clue,
                Repice=food.Repice,
                Preparation=food.Preparation,
                PreparationTime=food.PreparationTime,
                BakingTime=food.BakingTime,
                Service=food.Service,
                ImageUrl = food.ImageUrl,
                Url = food.Url,               
                Categories = food
                    .FoodCategories
                    .Select(fc => fc.Category)
                    .ToList()
            };
            return View(foodDetailsDto);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}