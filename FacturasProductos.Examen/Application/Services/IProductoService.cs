using System.Reflection.PortableExecutable;
using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacturasProductos.Examen.Application.Models;

namespace FacturasProductos.Examen.Application.Services
{
    public interface IProductoService
    {
        Producto Crear(Producto producto);
        Producto Actualizar(int id, Producto producto);
        void Eliminar(int id);

        Producto ObtenerPorId(int id);

        List<Producto> ObtenerTodos();
    }
}