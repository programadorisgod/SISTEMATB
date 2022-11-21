using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Proveedor : Persona
    {
        public string RazonSocial { get; set; }

        public Proveedor(string Cedula, string Nombre, string Telefono, string RazonSocial)
        {
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.RazonSocial = RazonSocial;
        }

        public Proveedor()
        {
        }
    }
}