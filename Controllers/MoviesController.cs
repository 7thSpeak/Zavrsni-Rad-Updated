using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZavrsniRadETicket.Data;

namespace ZavrsniRadETicket.Controllers
{
    public class MoviesController : Controller
    {
        public readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n => n.Cinema).ToListAsync();
            return View(allMovies);
        }
    }
}
