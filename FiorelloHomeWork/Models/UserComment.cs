namespace FiorelloHomeWork.Models
{
    public class UserComment : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Flower Flower { get; set; }
        public int FlowerId { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public int RateCount { get; set; }
    }
}
