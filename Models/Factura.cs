using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Factura: BaseEntity
    {
         /// <summary>
        /// Numero Factura
        /// </summary>
        public string Numero_Factura { get;  set; }

        /// <summary>
        /// Fecha
        /// </summary>
        public DateTime Fecha { get;  set; }

        /// <summary>
        /// Tipo de Pago
        /// </summary>
        public string Tipo_Pago { get;  set; }

        /// <summary>
        /// Documento Cliente
        /// </summary>
        public string Documento_Cliente { get;  set; }

        /// <summary>
        /// Nombre Cliente
        /// </summary>
        public string Nombre_Cliente { get;  set; }

        /// <summary>
        /// SubTotal
        /// </summary>
        public decimal SubTotal { get;  set; }

        /// <summary>
        /// Descuento
        /// </summary>
        public decimal Descuento { get;  set; }

        /// <summary>
        /// IVA
        /// </summary>
        public decimal IVA { get;  set; }

        /// <summary>
        /// Total Descuento
        /// </summary>
        public decimal Total_Descuento { get;  set; }
        
        /// <summary>
        /// Total Impuesto
        /// </summary>
        public decimal Total_Impuesto { get;  set; }

        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get;  set; }
    }
}