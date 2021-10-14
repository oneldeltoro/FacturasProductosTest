using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacturasProductos.Examen.Dtos;

using FacturasProductos.Examen.Application.Services;
using FacturasProductos.Examen.Application.Models;

namespace FacturasProductos.Examen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacturasController : ControllerBase
    {
        private readonly IFacturaService _facturaServices;

        private readonly ILogger<FacturasController> _logger;

        public FacturasController(ILogger<FacturasController> logger, IFacturaService facturaServices)
        {
            _logger = logger;
            _facturaServices = facturaServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Factura>>> GetAll()
        {
            var facturas = _facturaServices.ObtenerTodos();
            return Ok(facturas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Factura>> Get(int id)
        {
            var factura = _facturaServices.ObtenerPorId(id);
            return Ok(factura);
        }

        [HttpPost]
        public async Task<ActionResult<Factura>> Create(Factura FacturaDto)
        {
            _facturaServices.Crear(FacturaDto);
            return Ok(FacturaDto);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<FacturaDto>> Update(int id, Factura factura)
        {
            var update = _facturaServices.Actualizar(id, factura);
            return Ok(update);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Remove(int id)
        {
            _facturaServices.Eliminar(id);
            return Ok();
        }
    }
}
