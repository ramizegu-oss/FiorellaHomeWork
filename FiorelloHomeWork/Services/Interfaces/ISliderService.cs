using FiorelloHomeWork.ViewModels.Flower;

namespace FiorelloHomeWork.Services.Interfaces
{
    public interface ISliderService
    {
        public Task<IEnumerable<FlowerSliderUIVM>> GetAllAsync();
    }
}
