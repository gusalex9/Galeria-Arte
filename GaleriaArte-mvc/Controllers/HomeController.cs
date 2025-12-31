using System.Diagnostics;
using GaleriaArte_mvc.Data;
using GaleriaArte_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GaleriaArte_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly GaleriaDbContext _context;
        
        public HomeController(GaleriaDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {
            var obras = await _context.Obras
                .Take(6).Include(o => o.Artista)
                .ToListAsync();
            return View(obras);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
