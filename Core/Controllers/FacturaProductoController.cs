using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Core.Models;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Infraestructura;
using TodoApi.Core.Interfaz;

namespace TodoApi.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaProductoController : ControllerBase
    {
        private readonly IProductoService _service;

        public FacturaProductoController(IProductoService service)
        {
            _service = service;
            var allList=_service.ObtenerTodos();
            if (allList.Count == 0)
            {
                _service.Crear(0, "Producto1");
                
            }
        }

        [HttpGet]
        public ActionResult<List<Producto>> GetAll()
        {
            return _service.ObtenerTodos();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public ActionResult<Producto> GetById(int id)
        {
            var item = _service.ObtenerPorId(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
}