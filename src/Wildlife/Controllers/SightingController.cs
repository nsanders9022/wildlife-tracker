using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wildlife.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;



// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Wildlife.Controllers
{
    public class SightingController : Controller
    {
        private WildlifeTrackerContext db = new WildlifeTrackerContext();

        public IActionResult Index()
        {
            return View(db.Sighting.Include(sighting => sighting.Species).ToList());
        }
        public IActionResult Details(int id)
        {
            var thisSighting = db.Sighting.FirstOrDefault(sighting => sighting.SightingId == id);
            return View(thisSighting);
        }
    }
}
