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

        // GET: Members/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}