using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPOO.Models.Bases
{
    public abstract class Persona
    {
        public Persona(string apellido, string nombre, int DNI) 
        {   
            this.Apellido= apellido;
            this.Nombre = nombre;
            this.DNI = DNI;
                   

        }
        public string Apellido { get; set; }
        public string Nombre { get; set;}
        public int DNI { get; set; }
    }
}
