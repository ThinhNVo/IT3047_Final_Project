using IT3047_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IT3047_Final_Project.Controllers
{
    public class HobbyController : Controller
    {
        private readonly MembersContext context;

        public HobbyController(MembersContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var hobbies = context.Hobbies
                .OrderBy(h => h.Id)
                .ToList();

            return View(hobbies);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Hobby hobby)
        {
            if (ModelState.IsValid)
            {
                context.Hobbies.Add(hobby);
                context.SaveChanges();
                return RedirectToAction("Index", "Hobby");
            }
            else
            {
                ModelState.AddModelError("", "Please correct all errors and try again.");
                return View(hobby);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var hobby = context.Hobbies.FirstOrDefault(h => h.Id == id);
            if (hobby == null)
            {
                return NotFound();
            }

            return View(hobby);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public RedirectToActionResult Delete(Hobby hobby)
        {
            context.Remove(hobby);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}