using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
    public class PlacesController : Controller
    {
        [HttpGet("/places")]
        public ActionResult Index()
        {
            List<Place> allPlaces = Place.GetAll();
            return View(allPlaces);
        }

        [HttpGet("/places/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/places")]
        public ActionResult Create(string cityName)
        {
            Place myPlace = new Place(cityName);
            return RedirectToAction("Index");
        }

        [HttpPost("/places/delete")]
        public ActionResult DeleteAll()
        {
            Place.ClearAll();
            return View();
        }
    }
}
