using ListaDeCompras.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListaDeCompras.Controllers
{
    public class ListsController : Controller
    {

        public readonly ListaDeComprasContext _context;

        public ListsController(ListaDeComprasContext context)
        {
            _context = context;
        }
        public Task<IActionResult> Index()
        {
            return View(_context.Lists.ToListAsync());
        }
    }
}
