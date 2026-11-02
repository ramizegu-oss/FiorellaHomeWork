using FiorelloHomeWork.Data;
using FiorelloHomeWork.Services.Interfaces;
using FiorelloHomeWork.ViewModels;
using FiorelloHomeWork.ViewModels.Flower;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace FiorelloHomeWork.Controllers
{
    public class HomeController : Controller
    {
        readonly ICategoryService _service;
        readonly IFlowerService _flowerService;
        readonly ISliderService _sliderService;


        public HomeController(ICategoryService service,IFlowerService flowerService,ISliderService sliderService)
        {
            _service = service;
            _flowerService = flowerService;
            _sliderService = sliderService;
        }
        public async Task<IActionResult> Index()
        {
            var catigories = await _service.GetAllUIAsync();
            var flowers = await _flowerService.GetAllFlowers();
            var sliders = await _sliderService.GetAllAsync();
            

            HomeVM model = new()
            {
                Category = catigories,
                Flower = flowers,
                Slider = sliders
                
            };
            return View(model);
        }

        public async Task<IActionResult> Search(string txt)
        {
            if (string.IsNullOrWhiteSpace(txt))
            {
                return PartialView("Search", Array.Empty<FlowerSearchUIVM>());
            }

            var searchedFlowers = await _flowerService.GetFindFlowersBySearch(txt);
            return PartialView("Search", searchedFlowers);
        }

    }
}
