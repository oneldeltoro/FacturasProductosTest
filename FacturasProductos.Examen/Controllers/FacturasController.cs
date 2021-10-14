using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacturasProductos.Examen.Dtos;

namespace FacturasProductos.Examen.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacturasController : ControllerBase
    {

        private readonly ILogger<FacturasController> _logger;

        public FacturasController(ILogger<FacturasController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FacturaDto>>> GetAll()
        {
            //var invoices = await _mediator.Send(new GetAllInvoicesQuery());
            return Ok(invoices);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FacturaDto>> Get(int id)
        {
            /*var invoice = await _mediator.Send(new GetInvoiceQuery()
            {
                Id = id
            });*/
            return Ok(invoice);
        }

        [HttpPost]
        public async Task<ActionResult<FacturaDto>> Create(FacturaDto FacturaDto)
        {
            /*var invoice = await _mediator.Send(new AddInvoiceCommand()
            {
                Invoice = FacturaDto
            });*/
            return Ok(invoice);
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<FacturaDto>> Update(int id, FacturaDto FacturaDto)
        {
            /*var invoice = await _mediator.Send(new UpdateInvoiceCommand()
            {
                Id = id,
                Invoice = FacturaDto
            });*/
            return Ok(invoice);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Remove(int id)
        {
            /*await _mediator.Send(new RemoveInvoiceCommand()
            {
                Id = id
            });*/
            return Ok();
        }
    }
}
