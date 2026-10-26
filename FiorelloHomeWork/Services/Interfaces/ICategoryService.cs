using FiorelloHomeWork.ViewModels.Category;

namespace FiorelloHomeWork.Services.Interfaces
{
    public interface ICategoryService
    {
        public Task<IEnumerable<CategoryUIVM>> GetAllUIAsync();
    }
}
