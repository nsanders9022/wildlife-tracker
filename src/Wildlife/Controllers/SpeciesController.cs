using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wildlife.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Wildlife.Controllers
{
    public class SpeciesController : Controller
    {
        // GET: /<controller>/
        private WildlifeTrackerContext db = new WildlifeTrackerContext();
        public IActionResult Index()
        {
            return View(db.Species.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisSpecies = db.Species.FirstOrDefault(species => species.SpeciesId == id);
            return View(thisSpecies);
        }
    }
}
