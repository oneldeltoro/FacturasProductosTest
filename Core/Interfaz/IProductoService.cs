using System.Reflection.PortableExecutable;
using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Core.Models;
namespace TodoApi.Core.Interfaz
{
    public interface IProductoService
    {
        void Crear(int id, string nombre);

        void Eliminar(int id);

        Producto ObtenerPorId(int id);

        List<Producto> ObtenerTodos();
    }
}