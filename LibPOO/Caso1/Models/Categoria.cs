using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPOO.Models
{
    public class Categoria
    {

        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }
    }
}
