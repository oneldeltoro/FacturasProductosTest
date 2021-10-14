using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacturasProductos.Examen.Application.Models;
using Microsoft.EntityFrameworkCore;
using FacturasProductos.Examen.Application.Infrastructure.Context;

namespace FacturasProductos.Examen.Application.Repositorys
{
    public class ProductoRepository : Repository<Producto>, IProductoRepository
    {
        public ProductoRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext){}

        public Task<Producto> GetProductoByIdAsync(int id)
    {
        return GetAll().FirstOrDefaultAsync(x => x.Id == id);
    }
    }
}