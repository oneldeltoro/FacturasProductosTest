using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacturasProductos.Examen.Application.Services;
using FacturasProductos.Examen.Application.Models;
using FacturasProductos.Examen.Application.Infrastructure.Context;
using FacturasProductos.Examen.Application.Repositorys;

namespace FacturasProductos.Examen.Application.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }
        public Producto Crear(Producto producto)
        {
            return _productoRepository.AddAsync(producto).Result;
        }
        public Producto Actualizar(int id, Producto producto)
        {
            var find = ObtenerPorId(id);
            if (find != null)
            {
                return _productoRepository.UpdateAsync(producto).Result;
            }
            else
            {
                return find;
            }

        }
        public void Eliminar(int id)
        {
            var find = ObtenerPorId(id);
             _productoRepository.RemoveAsync(find);
           
        }

        public Producto ObtenerPorId(int id)
        {
            var product = _productoRepository.GetProductoByIdAsync(id);
            return product.Result;
        }

        public List<Producto> ObtenerTodos()
        {
            return _productoRepository.GetAll().ToList();
        }
    }
}