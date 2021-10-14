using System;

namespace FacturasProductos.Examen.Application.Models
{
    public class Producto : BaseEntity
    {
    
        public string Nombre { get; set; }

        public int FacturaId { get; set; }
        public Factura Factura { get; set; }

        public Producto(int id, string nombre) : base(id)
        {
            Nombre = nombre;
        }

    }
}