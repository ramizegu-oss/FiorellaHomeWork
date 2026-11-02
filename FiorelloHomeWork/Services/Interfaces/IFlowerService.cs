using FiorelloHomeWork.ViewModels.Flower;

namespace FiorelloHomeWork.Services.Interfaces
{
    public interface IFlowerService
    {
        public Task<IEnumerable<FlowerUIVM>> GetAllFlowers();
        public Task<FlowerDetailUIVM> GetFlowerDetailAsync(int id);

    }
}
