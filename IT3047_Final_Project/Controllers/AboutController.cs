using IT3047_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IT3047_Final_Project.Controllers
{
    public class AboutController : Controller
    {
        private readonly MembersContext _context;

        public AboutController(MembersContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var members = _context.Members.ToList();
            return View(members);
        }
        public IActionResult Hobby(string name)
        {
            var hobbies = _context.Hobbies
                .Include(h => h.Member)
                .Where(h => h.Member != null && h.Member.Name.Contains(name))
                .ToList();

            ViewBag.MemberName = name;

            return View(hobbies);
        }

    }
}