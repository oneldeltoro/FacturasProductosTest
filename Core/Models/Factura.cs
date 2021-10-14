using System;
using System.Collections.Generic;
using System.Linq;
namespace TodoApi.Core.Models
{
    public class Factura : EntidadBase
    {
        /// <summary>
        /// Numero Factura
        /// </summary>
        public string Numero_Factura { get; set; }

        /// <summary>
        /// Fecha
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Tipo de Pago
        /// </summary>
        public string Tipo_Pago { get; set; }

        /// <summary>
        /// Documento Cliente
        /// </summary>
        public string Documento_Cliente { get; set; }

        /// <summary>
        /// Nombre Cliente
        /// </summary>
        public string Nombre_Cliente { get; set; }

        /// <summary>
        /// SubTotal
        /// </summary>
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Descuento
        /// </summary>
        public decimal Descuento { get; set; }

        /// <summary>
        /// IVA
        /// </summary>
        public decimal IVA { get; set; }

        /// <summary>
        /// Total Descuento
        /// </summary>
        public decimal Total_Descuento { get; set; }

        /// <summary>
        /// Total Impuesto
        /// </summary>
        public decimal Total_Impuesto { get; set; }

        /// <summary>
        /// Total
        /// </summary>
        public decimal Total { get; set; }

        public List<Producto> Productos;

        public Factura(int id) : base(id)
        {
            Productos = new List<Producto>();
        }

        public Factura(string numero, DateTime fecha, string tipoPago, string clienteDoc, string clienteNombre, decimal subTotal, decimal descuento, decimal iva, decimal totalDescuento, decimal totalImpuesto, decimal total, List<Producto> productos)
        {
            Numero_Factura = numero;
            Fecha = fecha;
            Tipo_Pago = tipoPago;
            Documento_Cliente = clienteDoc;
            Nombre_Cliente = clienteNombre;
            SubTotal = subTotal;
            Descuento = descuento;
            IVA = iva;
            Total_Descuento = totalDescuento;
            Total_Impuesto = totalImpuesto;
            Total = total;
            Productos = productos;
        }
        /// <summary>
        /// Adicionar producto a la factura
        /// </summary>
        /// <param name="producto"></param>
        public void addProducto(Producto producto)
        {
            Productos.Add(producto);
        }
    }
}