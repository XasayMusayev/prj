using Microsoft.AspNetCore.Mvc;
using Shopwise.DAL;
using Shopwise.Entites;

namespace Shopwise.Controllers
{
    public class HomeController : Controller
    {
        readonly ShopwiseDbContext _context;
        public HomeController(ShopwiseDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Slider> model = _context.Sliders.ToList();
            
            return View(model);
        }
    }
}
