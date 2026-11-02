using FiorelloHomeWork.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloHomeWork.Controllers
{
    public class FlowerDetailController : Controller
    {
        private readonly IFlowerService _flowerService;
        public FlowerDetailController(IFlowerService flowerService)
        {
            _flowerService = flowerService;
        }
        public async Task<IActionResult> Detail(int id)
        {
            var flowerDetail = await _flowerService.GetFlowerDetailAsync(id);
            return View(flowerDetail);
        }
    }
}
