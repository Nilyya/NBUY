using DiariesFood.Business.Abstract;
using DiariesFood.Core;
using DiariesFood.Entity.Concrete;
using DiariesFood.Web.Admin.Models.Dtos;
using DiariesFood.Web.Areas.Admin.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DiariesFood.Web.Admin.Controllers
{
    [Area("Admin")]
    public class FoodController : Controller
    {
        private readonly IFoodService _foodService;
        private readonly ICategoryService _categoryService;

        public FoodController(IFoodService foodService, ICategoryService categoryService)
        {
            _foodService = foodService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var food = await _foodService.GetFoodsWithCategories();
            var foodListDto = food
                .Select(f => new FoodListDto
                {
                    Food = f
                }).ToList();

            ViewBag.SelectedMenu = "Food";
            ViewBag.Title = "Yemek";
            return View(foodListDto);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var categories = await _categoryService.GetAllAsync();
            var foodAddDto = new FoodAddDto
            {
                Categories = categories
            };
            return View(foodAddDto);
        }

        [HttpPost]

        public async Task<IActionResult> Create(FoodAddDto foodAddDto)
        {
            if (ModelState.IsValid)
            {
                var url = Jobs.InitUrl(foodAddDto.Name);
                var food = new Food
                {
                    Name = foodAddDto.Name,
                    Repice=foodAddDto.Repice,
                    Preparation=foodAddDto.Preparation,
                    PreparationTime=foodAddDto.PrepationTime,
                    BakingTime=foodAddDto.BakingTime,
                    Url = url,
                    IsApproved = foodAddDto.IsApproved,
                    IsHome = foodAddDto.IsHome,
                    ImageUrl = Jobs.UploadImage(foodAddDto.ImageFile)
                };
                await _foodService.CreateFoodAsync(food, foodAddDto.SelectedCategoryIds);
                return RedirectToAction("Index");
            }
            var categories = await _categoryService.GetAllAsync();
            foodAddDto.Categories = categories;
            foodAddDto.ImageUrl = foodAddDto.ImageUrl;
            return View(foodAddDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var food = await _foodService.GetFoodWithCategories(id);

            FoodUpdateDto foodUpdateDto = new FoodUpdateDto
            {
                Id = food.Id,
                Name = food.Name,
                Repice = food.Repice,
                Preparation = food.Preparation,                
                BakingTime = food.BakingTime,
                Url = food.Url,
                IsApproved = food.IsApproved,
                IsHome = food.IsHome,

                Categories = await _categoryService.GetAllAsync(),
                SelectedCategoryIds = food.FoodCategories.Select(fc => fc.CategoryId).ToArray()

            };
            return View(foodUpdateDto);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(FoodUpdateDto foodUpdateDto, int[] selectedCategoryIds)
        {
            if (ModelState.IsValid)
            {
                var food = await _foodService.GetByIdAsync(foodUpdateDto.Id);
                if (food == null) { return NotFound(); }

                var url = Jobs.InitUrl(foodUpdateDto.Name);
                var imageUrl = foodUpdateDto.ImageFile != null ? Jobs.UploadImage(foodUpdateDto.ImageFile)
                    : food.ImageUrl;
                food.Name = foodUpdateDto.Name;
                food.Repice = foodUpdateDto.Repice;
                food.Preparation = foodUpdateDto.Preparation;              
                food.BakingTime = foodUpdateDto.BakingTime;
                food.IsHome = foodUpdateDto.IsHome;
                food.IsApproved = foodUpdateDto.IsApproved;
                food.ImageUrl = imageUrl;
                food.Url = url;

                await _foodService.UpdateFoodAsync(food, selectedCategoryIds);
                return RedirectToAction("Index");

            }
            var categories = await _categoryService.GetAllAsync();
            foodUpdateDto.Categories = categories;
            return View(foodUpdateDto);
        }

        public async Task<IActionResult> UpdateIsHome(int id)
        {
            var food = await _foodService.GetByIdAsync(id);
            if (food == null) { return NotFound(); }
            await _foodService.UpdateIsHomeAsync(food);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> UpdateIsApproved(int id)
        {
            var food = await _foodService.GetByIdAsync(id);
            if (food == null) { return NotFound(); }
            await _foodService.UpdateIsApprovedAsync(food);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Delete(int id)
        {
            var food = await _foodService.GetByIdAsync(id);
            if (food == null) { return NotFound(); }
            _foodService.Delete(food);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> SearchFood(SearchQueryDto searchQueryDto)
        {
            List<Food> searchResults = await _foodService.GetSearchResultsAsync(f => f.IsApproved);
            List<FoodListDto> foodDtos = new List<FoodListDto>();
            foreach (var food in searchResults)
            {
                foodDtos.Add(new FoodListDto
                {
                    Food = food
                });
            }
            ViewBag.SelectedMenu = "Food";
            ViewBag.Title = "Yemek Arama Sonuçları";
            return View("Index", foodDtos);
        }
    }
}