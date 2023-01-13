using LibPOO.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibPOO.Models
{
    public class Empleado:Persona
    {
        public Empleado(string apellido, string nombre, int DNI, string prmLegajo) : base(apellido, nombre, DNI)
        {
            this.Legajo = prmLegajo;
        }

        public string Legajo { get; set; }

    }
}
