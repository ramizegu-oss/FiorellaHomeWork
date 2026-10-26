namespace FiorelloHomeWork.Models
{
    public class Flower : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public IEnumerable<FlowerImage> Images { get; set; }
    }
}
