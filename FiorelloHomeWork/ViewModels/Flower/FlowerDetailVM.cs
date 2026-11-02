namespace FiorelloHomeWork.ViewModels.Flower
{
    public class FlowerDetailVM
    {
        public FlowerDetailUIVM Flower { get; set; }
        public IEnumerable<FlowerUIVM> RelatedFlowers { get; set; }
    }
}
