using FiorelloHomeWork.Models;
using FiorelloHomeWork.ViewModels.Category;
using LabFront.ViewModels.Product;

namespace FiorelloHomeWork.ViewModels.Flower
{
    public class FlowerDetailUIVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string CategoryName { get; set; }
        public IEnumerable<FlowerImageUIVM> FlowerImages { get; set; }
    }
}
