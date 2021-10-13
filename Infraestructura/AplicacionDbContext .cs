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
        public AplicacionDbContext(DbContextOptions options) : base(options)    {  }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Factura> facturas { get; set; }
    }
}
