using System.Reflection;
using FacturasProductos.Examen.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace FacturasProductos.Examen.Application.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
