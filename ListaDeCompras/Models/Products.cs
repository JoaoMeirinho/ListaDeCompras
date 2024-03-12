using ListaDeCompras.Models.Enums;

namespace ListaDeCompras.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public Tag Tag { get; set; }
        public Unity Measure { get; set; }
    }
}
