using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Core.Models;
namespace TodoApi.Infraestructura
{
    public class AplicacionDbContext : DbContext
    {
        public DbSet<Factura> facturas { get; set; }
        public DbSet<Producto> productos { get; set; }
        public AplicacionDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
}
