using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class VistaEntradaProducto
    {
        public DateTime Fecha { get; set; }

        public string Proveedor { get; set; }

        public string Producto { get; set; }

        public int Cantidad { get; set; }

        public Double Precio { get; set; }

        public Double Total { get; set; }

        public VistaEntradaProducto(DateTime fecha, string proveedor, string producto, int cantidad, double precio, double total)
        {
            Fecha = fecha;
            Proveedor = proveedor;
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
            Total = total;
        }

        public VistaEntradaProducto()
        {
        }
    }
}
