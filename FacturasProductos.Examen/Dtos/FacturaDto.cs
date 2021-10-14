using System;
using System.Collections.Generic;
using FacturasProductos.Examen.Application.Models;

namespace FacturasProductos.Examen.Dtos
{
    public class FacturaDto
    {
        public int Id { get; set; }

        public string Numero_Factura { get; set; }

        public DateTime Fecha { get; set; }

        public string Tipo_Pago { get; set; }

        public string Documento_Cliente { get; set; }

        public string Nombre_Cliente { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Descuento { get; set; }

        public decimal IVA { get; set; }

        public decimal Total_Descuento { get; set; }

        public decimal Total_Impuesto { get; set; }

        public decimal Total { get; set; }

        public List<ProductoDto> Productos;
        
    }
}