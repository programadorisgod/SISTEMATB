using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cliente : Persona
    {
        public int id_cliente { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }


        public Cliente()
        {
            
        }

        public Cliente(int id_cliente, string Cedula, string Nombre, string Telefono, string Correo, string Direccion)
        {
            this.id_cliente = id_cliente;
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.Correo = Correo;
            this.Direccion = Direccion;
        }
    }
}