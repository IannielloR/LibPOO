using LibPOO.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPOO.Models
{
    public class Cliente:Persona
    {
        public Cliente(string apellido, string nombre, int DNI) : base(apellido, nombre, DNI)
        {

        }
        public List<Factura> Facturas { get; set;}
        public Usuario Usuario { get; set;}
    }
}
