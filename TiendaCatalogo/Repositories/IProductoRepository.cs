using System;
using System.Collections.Generic;
using System.Text;
using TiendaCatalogo.Models;

namespace TiendaCatalogo.Repositories
{
    public interface IProductoRepository
    {
        void Agregar(Producto producto);
        List<Producto> ObtenerTodos();
        Producto ObtenerPorId(int id);
        List<Producto> BuscarPorCategoria(string categoria);
    }
}