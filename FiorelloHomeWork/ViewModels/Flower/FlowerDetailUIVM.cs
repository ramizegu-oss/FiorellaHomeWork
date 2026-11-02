using FiorelloHomeWork.Models;
using FiorelloHomeWork.ViewModels.Category;
using LabFront.ViewModels.Product;

namespace FiorelloHomeWork.ViewModels.Flower
{
    public class FlowerDetailUIVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string CategoryName { get; set; }
        public IEnumerable<FlowerImageUIVM> FlowerImages { get; set; }
    }
}
