using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EntradaProducto
    {
        public String IdEntrada { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string CedulaProveedor { get; set; }

        public string CodigoProducto { get; set; }

        public int Cantidad { get; set; }

        public Double PrecioCompra { get; set; }

        public Double MontoTotal { get; set; }
    }
}