using FiorelloHomeWork.Services.Interfaces;
using FiorelloHomeWork.ViewModels.Flower;
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
            var relatedFlowers = await _flowerService.GetRelatedFlowers(flowerDetail.CategoryName,flowerDetail.Id);

            var model = new FlowerDetailVM
            {
                Flower = flowerDetail,
                RelatedFlowers = relatedFlowers
            };
            return View(model);
        }
    }
}
