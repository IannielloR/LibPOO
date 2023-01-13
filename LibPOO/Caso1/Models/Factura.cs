using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPOO.Models
{
    public class Factura
    {
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public List<DetalleFactura> DetalleFacturas { get; set;}
    }
}
