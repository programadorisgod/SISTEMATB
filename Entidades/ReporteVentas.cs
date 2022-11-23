using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ReporteVentas
    {
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public double MontoTotal { get; set; }
        public string NombreProducto { get; set; }
        public int CodigoProducto { get; set; }
        public string FechaRegistro { get; set; }
        public string DescripcionProducto { get; set; }
        public double PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public double MonTotal { get; set; }
        public double SubTotal{ get; set; }
    }
}
