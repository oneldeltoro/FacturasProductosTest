using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Core.Models
{
    public class Producto : EntidadBase
    {

        public String Nombre { get; set; }

        public int Numero_Factura { get; set; }

        public Factura Factura { get; set; }
        public Producto()
        {
        }

        public Producto(int id, string nombre) : base(id)
        {
            Nombre = nombre;
        }
        public Producto(String nombre, int numero_Factura, Factura factura)
        {
            this.Nombre = nombre;
            this.Numero_Factura = numero_Factura;
            this.Factura = factura;

        }
    }
}