using Microsoft.AspNetCore.Mvc;
using CarRelation.Models;

namespace CarRelation.Controllers
{
    public class ModelController : Controller
    {
        private readonly List<Model> _models;

        public ModelController()
        {
            _models = new List<Model>
            {
                new Model { Id = 1, Name="Mercedes-Maybach GLS 600", BrandId = 1, Cost = "$170.000"},
                new Model { Id = 2, Name="Mercedes-Benz S-Class", BrandId = 1, Cost = "$110.000"},
                new Model { Id = 3, Name="Dodge Charger", BrandId = 2, Cost = "$35.000"},
                new Model { Id = 4, Name="Dodge Challanger", BrandId = 2, Cost = "$30.000"}
            };
        }

        public IActionResult Index(int? id)
        {
            if (id != null)
            {
                if(! _models.Exists(s => s.Id == id))
                {
                    return BadRequest();
                }
                return View(_models.FindAll(s => s.BrandId == id));
            }

            return View();
        }

        public IActionResult Detail(int? id)
        {
            if(id == null) return BadRequest(); 
            Model model = _models.Find(s => s.Id == id);
            if (model == null) return NotFound();
            return View(model);
        }
    }
}
