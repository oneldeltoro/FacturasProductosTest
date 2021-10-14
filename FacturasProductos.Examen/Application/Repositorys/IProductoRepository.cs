using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacturasProductos.Examen.Application.Models;

namespace FacturasProductos.Examen.Application.Repositorys
{
    public interface IProductoRepository : IRepository<Producto>
    {
        Task<Producto> GetProductoByIdAsync(int id); 
    }
}