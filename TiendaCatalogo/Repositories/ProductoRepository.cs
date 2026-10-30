using TiendaCatalogo.Models;

namespace TiendaCatalogo.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private List<Producto> _productos;

        public ProductoRepository()
        {
            _productos = new List<Producto>
            {
                new Producto { Id = 1, Nombre = "Laptop Lenovo", Precio = 3500.00m, Categoria = "Tecnologia", Activo = true },
                new Producto { Id = 2, Nombre = "Mouse Logitech", Precio = 85.50m, Categoria = "Tecnologia", Activo = true },
                new Producto { Id = 3, Nombre = "Silla Gamer", Precio = 750.00m, Categoria = "Muebles", Activo = true },
                new Producto { Id = 4, Nombre = "Escritorio", Precio = 1200.00m, Categoria = "Muebles", Activo = false }
            };
        }

        public void Agregar(Producto producto)
        {
            _productos.Add(producto);
        }

        public List<Producto> ObtenerTodos()
        {
            return _productos.ToList();
        }

        public Producto ObtenerPorId(int id)
        {
            return _productos.FirstOrDefault(p => p.Id == id)!;
        }

        public List<Producto> BuscarPorCategoria(string categoria)
        {
            return _productos
                .Where(p => p.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}