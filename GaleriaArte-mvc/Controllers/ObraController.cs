using GaleriaArte_mvc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GaleriaArte_mvc.Controllers
{
    public class ObraController : Controller
    {
        private GaleriaDbContext _context;
        public ObraController(GaleriaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> DetalleObra(string id)
        {
            var obra = await _context.Obras.FirstOrDefaultAsync(o => o.Id.ToString() == id);
            return View(obra);
        }
    }
}
