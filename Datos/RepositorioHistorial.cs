using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using NPOI.POIFS.Crypt.Dsig;

namespace Datos
{
    public class RepositorioHistorial : ConexionBasedeDatos
    {

        public Entidades.Ventas Reporte(string fecha, string cedula)
        {
            Entidades.Ventas reporte = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionBasedeDatos.cadenaConexion))
                {
                    connection.Open();
                    StringBuilder cmd = new StringBuilder();
                    cmd.AppendLine("SELECT cliente.id_cliente, cliente.Nombre, cliente.Cedula,  Venta.Cantidad_productos,Venta.FechaRegistro, Venta.Id_cliente, Venta.Id_venta, Venta.Monto_total");
                    cmd.AppendLine("from Clientes cliente inner join Ventas Venta on cliente.id_cliente=Venta.Id_cliente ");
                    cmd.AppendLine("WHERE Venta.FechaRegistro  = @fecha AND cliente.Cedula = @cedula ");
                    SqlCommand cemd = new SqlCommand(cmd.ToString(), connection);
                    cemd.Parameters.Add(new SqlParameter("@fecha", fecha));
                    cemd.Parameters.Add(new SqlParameter("@cedula", cedula));
                    cemd.CommandType = System.Data.CommandType.Text;
                    var reader = cemd.ExecuteReader();
                    while (reader.Read())
                    {
                        reporte = new Entidades.Ventas ()
                        {
                            IdVenta = Convert.ToInt32(reader["Id_venta"]),
                            NombreCliente = reader["Nombre"].ToString(),
                            CedulaCliente = reader["Cedula"].ToString(),
                            CantidadProductos = Convert.ToInt32(reader["Cantidad_productos"]),
                            FechaRegistro = reader["FechaRegistro"].ToString(),
                            TotalVenta = Convert.ToDouble(reader["Monto_total"].ToString())
                        
                          

                        };

                    }
                }
            }
            catch (Exception)
            {
                reporte = null;
            }
            return reporte;
        }


        public List<DetalleSalida> ListarDetalleSalidas(int id_salida)
        {
            List<DetalleSalida> salidas = new List<DetalleSalida>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionBasedeDatos.cadenaConexion))
                {
                    connection.Open();
                    StringBuilder cmd = new StringBuilder();
                    cmd.AppendLine("SELECT  Producto.Nombre,Producto.Codigo, Producto.Descripcion,DETALLE_VENTAS.Codigo_producto, DETALLE_VENTAS.Cantidad, DETALLE_VENTAS.Subtotal ");
                    cmd.AppendLine("FROM  DETALLE_VENTAS inner join Producto ");
                    cmd.AppendLine("on DETALLE_VENTAS.Codigo_producto = Producto.Codigo");
                    cmd.AppendLine("where Id_venta  = @id_salida ");
                    SqlCommand cemd = new SqlCommand(cmd.ToString(), connection);
                    cemd.Parameters.Add(new SqlParameter("@id_salida", id_salida));
                    cemd.CommandType = System.Data.CommandType.Text;
                    var reader = cemd.ExecuteReader();
                    while (reader.Read()) {
                        salidas.Add(new DetalleSalida()
                        {
                            CodigoProducto = Convert.ToInt32(reader["Codigo_producto"]),
                            Cantidad = Convert.ToInt32(reader["Cantidad"]),
                            Nombreproducto = reader["Nombre"].ToString(),
                            SubTotal = Convert.ToDecimal(reader["Subtotal"])
                           
                        }) ;
                           
                    }
                }
            }
            catch (Exception)
            {
              salidas = new List<DetalleSalida> ();
            }
            return salidas;
        }

        public List<ReporteVentas> GetReporteVentas(string fechainicio, string fechafinal)
        {
            List<ReporteVentas> reporteVentas= new List<ReporteVentas>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConexionBasedeDatos.cadenaConexion))
                {
                    connection.Open();
                    StringBuilder cmd = new StringBuilder();
                    cmd.AppendLine("SELECT VENTAS.Id_venta, VENTAS.FechaRegistro, VENTAS.Cantidad_productos, VENTAS.Monto_total, VENTAS.Id_cliente, ");
                    cmd.AppendLine("DETALLE_VENTAS.Codigo_producto, DETALLE_VENTAS.Id_venta, DETALLE_VENTAS.Subtotal, ");
                    cmd.AppendLine("Clientes.id_cliente, Clientes.Cedula, Clientes.Nombre as Nombre_cliente,");
                    cmd.AppendLine("Producto.Descripcion, Producto.Nombre as Nombre_Producto, Producto.PrecioVenta ");
                    cmd.AppendLine("FROM VENTAS inner join  DETALLE_VENTAS");
                    cmd.AppendLine("ON VENTAS.Id_venta = DETALLE_VENTAS.Id_venta");
                    cmd.AppendLine("JOIN Clientes ");
                    cmd.AppendLine("ON VENTAS.Id_cliente = Clientes.id_cliente");
                    cmd.AppendLine("JOIN Producto");
                    cmd.AppendLine("ON DETALLE_VENTAS.Codigo_producto = Producto.Codigo");
                    cmd.AppendLine("WHERE VENTAS.FechaRegistro  BETWEEN  @fechainicio AND  @fechafinal ");
                    SqlCommand cemd = new SqlCommand(cmd.ToString(), connection);
                    cemd.Parameters.Add(new SqlParameter("@fechainicio", fechainicio));
                    cemd.Parameters.Add(new SqlParameter("@fechafinal", fechafinal));
                    cemd.CommandType = System.Data.CommandType.Text;
                    var rd = cemd.ExecuteReader();
                    while (rd.Read())
                    {
                        reporteVentas.Add(new ReporteVentas()
                        {
                            FechaRegistro = rd["FechaRegistro"].ToString(),
                            DocumentoCliente = rd["Cedula"].ToString(),
                            CodigoProducto = Convert.ToInt32(rd["Codigo_producto"]),
                            NombreCliente = rd["Nombre_cliente"].ToString(),
                            NombreProducto = rd["Nombre_Producto"].ToString(),
                            DescripcionProducto = rd["Descripcion"].ToString(),
                            Cantidad = Convert.ToInt32(rd["Cantidad_productos"]),
                            PrecioVenta = Convert.ToDouble(rd["PrecioVenta"]),
                            SubTotal = Convert.ToDouble(rd["Subtotal"]),
                            MonTotal = Convert.ToDouble(rd["Monto_total"])

                        }) ;
                    }
                }
            }
            catch (Exception ex)
            {

                reporteVentas = new List<ReporteVentas>();
            }
            return reporteVentas;
        }  

    }
}
