using DiariesFood.Business.Abstract;
using DiariesFood.Entity.Concrete;
using DiariesFood.Web.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DiariesFood.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoodService _foodManager;

        public HomeController(IFoodService foodManager)
        {
            _foodManager = foodManager;
        }

        public async Task<IActionResult> Index()
        {
            List<Food> foods = await _foodManager.GetHomePageFoodsAsync();
            List<FoodDto> foodDtos = new List<FoodDto>();
            foreach (var food in foods)
            {
                foodDtos.Add(new FoodDto
                {
                    Id = food.Id,
                    Name = food.Name,
                    Clue=food.Clue,
                    Repice=food.Repice,
                    Preparation=food.Preparation,
                    PreparationTime=food.PreparationTime,
                    BakingTime = food.BakingTime,
                    Service=food.Service,
                    ImageUrl = food.ImageUrl,
                    Url = food.Url,

                });
            }
            return View(foodDtos);
        }


    }
}
