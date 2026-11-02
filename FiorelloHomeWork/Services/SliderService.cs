using FiorelloHomeWork.Data;
using FiorelloHomeWork.Services.Interfaces;
using FiorelloHomeWork.ViewModels.Flower;
using Microsoft.EntityFrameworkCore;

namespace FiorelloHomeWork.Services
{
    public class SliderService : ISliderService
    {
        private readonly AppDbContext _context;
        public SliderService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<FlowerSliderUIVM>> GetAllAsync()
        {
            return await _context.FlowerSliders.Select(s=> new FlowerSliderUIVM
            {
                Title = s.Title,
                Description = s.Description,
                FlowerImage = s.FlowerImage
            }).ToListAsync();
        }

       
    }
}
