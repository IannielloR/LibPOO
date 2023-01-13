using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPOO.Models
{
    public class DetalleFactura
    {
        public Factura Factura { get; set;}
        public Producto Producto { get; set;}
    }
}
