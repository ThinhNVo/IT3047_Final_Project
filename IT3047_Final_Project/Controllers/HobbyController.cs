using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IT3047_Final_Project.Models;

namespace IT3047_Final_Project.Controllers
{
    public class HobbyController : Controller
    {
        private readonly MembersContext _context;

        public HobbyController(MembersContext context)
        {
            _context = context;
        }

        // GET: Hobby
        public IActionResult Index()
        {
            var hobbies = _context.Hobbies.Include(h => h.Member).ToList();
            return View(hobbies);
        }

        // GET: Hobby/Create
        public IActionResult Create()
        {
            ViewBag.Members = new SelectList(_context.Members.ToList(), "Id", "Name");
            return View();
        }

        // POST: Hobby/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Hobby hobby)
        {
            if (ModelState.IsValid)
            {
                _context.Hobbies.Add(hobby);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Members = new SelectList(_context.Members.ToList(), "Id", "Name");
            return View(hobby);
        }

        // GET: Hobby/Delete/5
        public IActionResult Delete(int id)
        {
            var hobby = _context.Hobbies.Include(h => h.Member).FirstOrDefault(h => h.Id == id);
            if (hobby == null) return NotFound();
            return View(hobby);
        }

        // POST: Hobby/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var hobby = _context.Hobbies.FirstOrDefault(h => h.Id == id);
            if (hobby != null)
            {
                _context.Hobbies.Remove(hobby);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}