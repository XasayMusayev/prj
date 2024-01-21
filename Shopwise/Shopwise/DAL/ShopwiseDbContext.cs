using Microsoft.EntityFrameworkCore;
using Shopwise.Entites;

namespace Shopwise.DAL
{
    public class ShopwiseDbContext:DbContext
    {
        public ShopwiseDbContext(DbContextOptions<ShopwiseDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
