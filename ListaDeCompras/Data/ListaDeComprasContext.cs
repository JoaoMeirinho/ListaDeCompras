using ListaDeCompras.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaDeCompras.Data
{
    public class ListaDeComprasContext : DbContext
    {
        public ListaDeComprasContext(DbContextOptions<ListaDeComprasContext> options) : base(options) 
        {
        }

        public DbSet<Products> Products {  get; set; }
        public DbSet<ListProducts> ListProducts { get; set; }
    }
}
