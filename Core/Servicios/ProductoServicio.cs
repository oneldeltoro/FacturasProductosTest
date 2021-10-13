using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Core.Interfaz;
using TodoApi.Core.Models;
using TodoApi.Infraestructura;
namespace TodoApi.Core.Servicios
{
    public class ProductoServicio : IProductoService
    {
        private readonly AplicacionDbContext _dbContext;

        public ProductoServicio(AplicacionDbContext context)
        {
            _dbContext = context;
        }
     public    void Crear(int id, string nombre){
             var product= new Producto(id,nombre);
            if(id == 0) _dbContext.productos.Add(product);
            else _dbContext.productos.Update(product);
        }

      public   void Eliminar(int id){
            var find =  ObtenerPorId(id);
            if(find != null){
                _dbContext.productos.Remove(find);
                _dbContext.SaveChanges();
            }
        }

     public    Producto ObtenerPorId(int id){
            var product = _dbContext.productos.SingleOrDefault(x=> x.Id==id);
            return product;
        }

    public     List<Producto> ObtenerTodos(){
            return _dbContext.productos.ToList();

        }
    }
}