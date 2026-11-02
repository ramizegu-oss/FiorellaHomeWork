
using FiorelloHomeWork.ViewModels.Category;
using FiorelloHomeWork.ViewModels.Flower;

namespace FiorelloHomeWork.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<CategoryUIVM> Category { get; set; }
        public IEnumerable<FlowerUIVM> Flower { get; set; }
        public IEnumerable<FlowerSliderUIVM> Slider { get; set; }
    }
}
