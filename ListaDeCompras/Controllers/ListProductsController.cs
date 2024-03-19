using ListaDeCompras.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ListaDeCompras.Controllers
{
    public class ListProductsController : Controller
    {
        private readonly ListaDeComprasContext _context;

        public ListProductsController(ListaDeComprasContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(_context.ListProducts.ToListAsync());
        }
    }
}
