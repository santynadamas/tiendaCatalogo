using TiendaCatalogo.Models;
using TiendaCatalogo.Repositories;

namespace TiendaCatalogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProductoRepository repo = new ProductoRepository();
            Console.WriteLine("*** LISTA COMPLETA DE PRODUCTOS ***");
            ImprimirProductos(repo.ObtenerTodos());

            Console.WriteLine("\n*** BUSQUEDA POR ID (2) ***");
            Producto producto = repo.ObtenerPorId(2);
            if (producto != null)
                ImprimirProducto(producto);
            else
                Console.WriteLine("Producto no encontrado.");

            Console.WriteLine("\n*** BUSQUEDA POR ID (99) ***");
            Producto inexistente = repo.ObtenerPorId(99);
            if (inexistente != null)
                ImprimirProducto(inexistente);
            else
                Console.WriteLine("Producto no encontrado.");

            Console.WriteLine("\n*** PRODUCTOS DE CATEGORIA 'Muebles' ***");
            ImprimirProductos(repo.BuscarPorCategoria("Muebles"));

            Console.WriteLine("\n*** AGREGANDO NUEVO PRODUCTO ***");
            repo.Agregar(new Producto
            {
                Id = 5,
                Nombre = "Teclado Mecanico",
                Precio = 220.00m,
                Categoria = "Tecnologia",
                Activo = true
            });

            Console.WriteLine("Lista actualizada:");
            ImprimirProductos(repo.ObtenerTodos());

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }

        static void ImprimirProductos(List<Producto> productos)
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos para mostrar.");
                return;
            }

            foreach (Producto p in productos)
                ImprimirProducto(p);
        }

        static void ImprimirProducto(Producto p)
        {
            Console.WriteLine($"[{p.Id}] {p.Nombre} | {p.Precio:F2} | {p.Categoria} | Activo: {p.Activo}");
        }
    }
}