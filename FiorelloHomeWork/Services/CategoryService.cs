using FiorelloHomeWork.Data;
using FiorelloHomeWork.Services.Interfaces;
using FiorelloHomeWork.ViewModels.Category;
using Microsoft.EntityFrameworkCore;

namespace FiorelloHomeWork.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CategoryUIVM>> GetAllUIAsync()
        {
            var res = await _context.Categories.Select(m => new CategoryUIVM
            {
                Name = m.Name
            }).ToListAsync();

            return res;
        }
    }
}
