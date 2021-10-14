using System.Reflection.PortableExecutable;
using System.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacturasProductos.Examen.Application.Models;

namespace FacturasProductos.Examen.Application.Services
{
    public interface IFacturaService
    {
        Factura Crear(Factura factura);

        Factura Actualizar(int id, Factura factura);
        void Eliminar(int id);

        Factura ObtenerPorId(int id);

        List<Factura> ObtenerTodos();
    }
}