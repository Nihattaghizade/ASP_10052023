using Microsoft.AspNetCore.Mvc;
using CarRelation.Models;

namespace CarRelation.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Brand> _brands;

        public HomeController()
        {
            _brands = new List<Brand>
            {
                new Brand { Id = 1, Name="Mercedes"},
                new Brand { Id = 2, Name="Dodge"}
            };
        }

        public IActionResult Index() 
        {
            return View(_brands); 
        }
    }
}
