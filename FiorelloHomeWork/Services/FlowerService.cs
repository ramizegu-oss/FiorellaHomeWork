using FiorelloHomeWork.Data;
using FiorelloHomeWork.Models;
using FiorelloHomeWork.Services.Interfaces;
using FiorelloHomeWork.ViewModels.Flower;
using FiorelloHomeWork.ViewModels.UserComment;
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

        public async Task<IEnumerable<FlowerSearchUIVM>> GetFindFlowersBySearch(string txt)
        {
            var flowers = await _context.Flowers.Include(m => m.Images).Where(f=> f.Name.Contains(txt)).ToListAsync();

            return flowers.Select(f => new FlowerSearchUIVM
            {
                Id = f.Id,
                Name = f.Name,
                Price = f.Price,
                MainImg = f.Images.FirstOrDefault(f=> f.IsMain).Name
            });
        }

        public async Task<FlowerDetailUIVM> GetFlowerDetailAsync(int id)
        {
            var flower = await _context.Flowers.Include(f=> f.FlowerComments).Include(f => f.Category).Include(f => f.Images).FirstOrDefaultAsync(f=> f.Id == id);

            return new FlowerDetailUIVM
            {
                Title = flower.Name,
                CategoryName = flower.Category.Name,
                Price = flower.Price,
                FlowerImages = flower.Images.Select(m => new FlowerImageUIVM
                {
                    Name = m.Name,
                    IsMane = m.IsMain
                }),
                FlowerComments = flower.FlowerComments.Select(f => new UserCommentUIVM
                {
                    FullName = f.Name + " " + f.LastName,
                    Description = f.Description,
                    RateCount = f.RateCount
                })
            };
        }

        public async Task<IEnumerable<FlowerUIVM>> GetRelatedFlowers(string cate, int id)
        {
            return await _context.Flowers.Include(f => f.Category).Include(f => f.Images).Where(f => f.Category.Name == cate && f.Id != id).Select(f => new FlowerUIVM
            {
                Id = f.Id,
                Name = f.Name,
                Description = f.Description,
                Price = f.Price,
                Image = f.Images.FirstOrDefault(e=> e.IsMain).Name,
                Category  =f.Category.Name
            }).ToListAsync();

            

            
        }
    }
}
