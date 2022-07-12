using Microsoft.AspNetCore.Mvc;
using Places.Models;

namespace Places.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            Place starterPlace = new Place("Add first item to Place List");
            return View(starterPlace);
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
            return View("Index", myPlace);
        }
    }
}
