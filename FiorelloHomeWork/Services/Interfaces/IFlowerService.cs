using FiorelloHomeWork.ViewModels.Flower;

namespace FiorelloHomeWork.Services.Interfaces
{
    public interface IFlowerService
    {
        public Task<IEnumerable<FlowerUIVM>> GetAllFlowers();
        public Task<FlowerDetailUIVM> GetFlowerDetailAsync(int id);
        public Task<IEnumerable<FlowerUIVM>> GetRelatedFlowers(string cate,int id);
        public Task<IEnumerable<FlowerSearchUIVM>> GetFindFlowersBySearch(string txt);

    }
}
