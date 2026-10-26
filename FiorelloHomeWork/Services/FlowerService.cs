using FiorelloHomeWork.Data;
using FiorelloHomeWork.Services.Interfaces;
using FiorelloHomeWork.ViewModels.Flower;
using Microsoft.EntityFrameworkCore;
namespace FiorelloHomeWork.Services
{
    public class FlowerService : IFlowerService
    {
        private readonly AppDbContext _context;
        public FlowerService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<FlowerUIVM>> GetAllFlowers()
        {
            var res = await _context.Flowers.Include(e => e.Images).Include(e=> e.Category).Select(f => new FlowerUIVM
            {
                Name = f.Name,
                Description = f.Description,
                Image = f.Images.FirstOrDefault(i=> i.IsMain).Name,
                Price = f.Price,
                Category = f.Category.Name
            }).ToListAsync();

            return res;
        }
    }
}
