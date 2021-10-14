using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacturasProductos.Examen.Application.Models;
using Microsoft.EntityFrameworkCore;
using FacturasProductos.Examen.Application.Infrastructure.Context;

namespace FacturasProductos.Examen.Application.Repositorys
{
    public class FacturaRepository : Repository<Factura>, IFacturaRepository
    {
        public FacturaRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext){}

        public Task<Factura> GetFacturaByIdAsync(int id)
    {
        return GetAll().FirstOrDefaultAsync(x => x.Id == id);
    }
    }
}