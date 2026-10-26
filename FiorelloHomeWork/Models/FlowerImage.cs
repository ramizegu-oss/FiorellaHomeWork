namespace FiorelloHomeWork.Models
{
    public class FlowerImage : BaseEntity
    {
        public string Name { get; set; }
        public Flower Flower { get; set; }
        public int FlowerId { get; set; }
        public bool IsMain { get; set; }
    }
}
