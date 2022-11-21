using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class EntradaProducto
    {
        public int IdEntrada { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string CedulaProveedor { get; set; }

        public int CodigoProducto { get; set; }

        public int Cantidad { get; set; }

        public Double PrecioCompra { get; set; }

        public Double MontoTotal { get; set; }

        public EntradaProducto(int idEntrada, DateTime fechaRegistro, string cedulaProveedor, int codigoProducto, int cantidad, double precioCompra, double montoTotal)
        {
            IdEntrada = idEntrada;
            FechaRegistro = fechaRegistro;
            CedulaProveedor = cedulaProveedor;
            CodigoProducto = codigoProducto;
            Cantidad = cantidad;
            PrecioCompra = precioCompra;
            MontoTotal = montoTotal;
        }

        public EntradaProducto()
        {
        }
    }
}