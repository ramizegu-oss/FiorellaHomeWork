using FiorelloHomeWork.Data;
using FiorelloHomeWork.Services.Interfaces;
using FiorelloHomeWork.ViewModels.Flower;
using LabFront.ViewModels.Product;
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
                Id  = f.Id,
                Name = f.Name,
                Description = f.Description,
                Image = f.Images.FirstOrDefault(i=> i.IsMain).Name,
                Price = f.Price,
                Category = f.Category.Name
            }).ToListAsync();

            return res;
        }

        public async Task<FlowerDetailUIVM> GetFlowerDetailAsync(int id)
        {
            var flower = await _context.Flowers.Include(f => f.Category).Include(f => f.Images).FirstOrDefaultAsync(f=> f.Id == id);

            return new FlowerDetailUIVM
            {
                Title = flower.Name,
                CategoryName = flower.Category.Name,
                Price = flower.Price,
                FlowerImages = flower.Images.Select(m => new FlowerImageUIVM
                {
                    Name = m.Name,
                    IsMane = m.IsMain
                })
            };
        }
    }
}
