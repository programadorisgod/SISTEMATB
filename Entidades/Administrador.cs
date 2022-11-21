using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Administrador : Persona
    {
        public String Usuario { get; set; }

        public String Clave { get; set; }
    }
}