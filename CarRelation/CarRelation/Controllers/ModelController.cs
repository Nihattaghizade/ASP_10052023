using Microsoft.AspNetCore.Mvc;
using CarRelation.Models;
using CarRelation.DataAccessLayer;

namespace CarRelation.Controllers
{
    public class ModelController : Controller
    {
        //private readonly List<Model> _models;
        private readonly AppDbContext _context;

        public ModelController(AppDbContext context)
        {
            _context = context;
            //_models = new List<Model>
            //{
            //    new Model { Id = 1, Name="Mercedes-Maybach GLS 600", BrandId = 1, Cost = "$170.000"},
            //    new Model { Id = 2, Name="Mercedes-Benz S-Class", BrandId = 1, Cost = "$110.000"},
            //    new Model { Id = 3, Name="Dodge Charger", BrandId = 2, Cost = "$35.000"},
            //    new Model { Id = 4, Name="Dodge Challanger", BrandId = 2, Cost = "$30.000"}
            //};
        }

        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                //if(! _context.Models.Any(s => s.Id == id))
                //{
                //    return BadRequest();
                //}
                //if(!_context.Models.Any(s => s.BrandId == id))
                return View(_context.Models.Where(s => s.BrandId == id).ToList());
            }

            return View(_context.Models.ToList());
        }

        public IActionResult Detail(int? id)
        {
            //if(id == null) return BadRequest(); 
             
            //if (!_context.Models.Any(s => s.Id == id)) return NotFound();
            return View(_context.Models.Where(s => s.Id == id).ToList());
        }
    }
}
