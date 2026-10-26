using FiorelloHomeWork.Data;
using FiorelloHomeWork.Services.Interfaces;
using FiorelloHomeWork.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FiorelloHomeWork.Controllers
{
    public class HomeController : Controller
    {
        readonly ICategoryService _service;
        readonly IFlowerService _flowerService;
        
        public HomeController(ICategoryService service,IFlowerService flowerService)
        {
            _service = service;
            _flowerService = flowerService;
        }
        public async Task<IActionResult> Index()
        {
            var catigories = await _service.GetAllUIAsync();
            var flowers = await _flowerService.GetAllFlowers();

            HomeVM model = new()
            {
                Category = catigories,
                Flower = flowers
            };
            return View(model);
        }
    }
}
