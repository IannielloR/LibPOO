using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPOO.Models
{
    public class Producto
    {
        public Producto(string nombre, double precio) 
        {
            this.Precio = precio;
            this.Nombre = nombre;
        }

        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Categoria Categoria { get; set; }
        public List<DetalleFactura> DetalleFacturas { get;set; }
    }
}
