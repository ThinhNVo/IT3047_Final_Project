using System.Diagnostics;
using IT3047_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT3047_Final_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GoToHobbies()
        {
            return RedirectToAction("Index", "Hobby");
        }
    }
}
