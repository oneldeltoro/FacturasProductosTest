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
    public class FacturaService : IFacturaService
    {

        private readonly IFacturaRepository _facturaRepository;

        public FacturaService(IFacturaRepository facturaRepository)
        {
            _facturaRepository = facturaRepository;
        }
        public Factura Crear(Factura factura)
        {
            return _facturaRepository.AddAsync(factura).Result;
        }
        public Factura Actualizar(int id, Factura factura)
        {
            var find = _facturaRepository.GetFacturaByIdAsync(id);
            if (find != null) return _facturaRepository.AddAsync(factura).Result;
            else return find.Result;

        }
        public void Eliminar(int id)
        {
            var find = ObtenerPorId(id);
            _facturaRepository.RemoveAsync(find);
        }

        public Factura ObtenerPorId(int id)
        {
            var factura = _facturaRepository.GetFacturaByIdAsync(id);
            return factura.Result;
        }

        public List<Factura> ObtenerTodos()
        {
            return _facturaRepository.GetAll().ToList();

        }
    }
}