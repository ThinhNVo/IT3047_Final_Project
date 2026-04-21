using Microsoft.AspNetCore.Mvc;
using IT3047_Final_Project.Models;

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
    }
}