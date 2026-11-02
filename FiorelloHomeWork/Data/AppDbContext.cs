using FiorelloHomeWork.Models;
using Microsoft.EntityFrameworkCore;

namespace FiorelloHomeWork.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Flower> Flowers { get; set; }
        public DbSet<FlowerImage> FlowerImages { get; set; }
        public DbSet<FlowerSlider> FlowerSliders { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
