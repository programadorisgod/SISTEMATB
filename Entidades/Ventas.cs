using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Ventas
    {
        public int IdVenta { get; set; }
        public int Idcliente { get; set; }
        public string CedulaCliente { get; set; }

        public string NombreCliente { get; set; }
        public int CantidadProductos { get; set; }

        public double TotalVenta { get; set; }

        public string FechaRegistro { get; set; }

        public List<DetalleSalida> ListaDetalleSalida { get; set; }
    }
}