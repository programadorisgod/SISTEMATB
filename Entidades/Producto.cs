using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public double ValorVenta { get; set; }

        public int Stock { get; set; }

        public Producto(int codigo, string nombre, string descripcion, double valorVenta, int stock)
        {
            Codigo = codigo;
            Nombre = nombre;
            Descripcion = descripcion;
            ValorVenta = valorVenta;
            Stock = stock;
        }

        public Producto()
        {
        }
    }
}