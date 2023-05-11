using Microsoft.AspNetCore.Mvc;
using CarRelation.Models;
using CarRelation.DataAccessLayer;

namespace CarRelation.Controllers
{
    public class HomeController : Controller
    {
        //private readonly List<Brand> _brands;
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
            //_brands = new List<Brand>
            //{
            //    new Brand { Id = 1, Name="Mercedes"},
            //    new Brand { Id = 2, Name="Dodge"}
            //};
        }

        public IActionResult Index() 
        {
            return View(_context.Brands.ToList()); 
        }
    }
}
