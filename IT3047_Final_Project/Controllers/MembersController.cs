using Microsoft.AspNetCore.Mvc;
using IT3047_Final_Project.Models;

namespace IT3047_Final_Project.Controllers
{
    public class MembersController : Controller
    {
        private readonly MembersContext _context;

        public MembersController(MembersContext context)
        {
            _context = context;
        }

   
        public IActionResult Index()
        {
            var members = _context.Members.ToList();
            return View(members);
        }

        
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Members member)
        {
            if (ModelState.IsValid)
            {
                _context.Members.Add(member);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        
        public IActionResult Delete(int id)
        {
            var member = _context.Members.FirstOrDefault(m => m.Id == id);
            if (member == null) return NotFound();
            return View(member);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var member = _context.Members.FirstOrDefault(m => m.Id == id);
            if (member != null)
            {
                _context.Members.Remove(member);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}