using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Core.Dtos
{
    public class FacturaDto
    {
   
        public string NumeroFactura { get; set; }

        public DateTime Fecha { get; set; }

        public string TipoDePago { get; set; }

        public string DocumentoCliente { get; set; }

      
        public string NombreCliente { get; set; }

      
        public decimal SubTotal { get; set; }

        public decimal Descuento { get; set; }

     
        public decimal IVA { get; set; }

      
        public decimal DescuentoTotal { get; set; }

       
        public decimal TotalImpuesto { get; set; }

     
        public decimal Total { get; set; }

     
        public List<ProductoDto> Productos { get; set; }
    }
}