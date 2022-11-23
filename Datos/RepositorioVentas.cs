using Entidades;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioVentas : ConexionBasedeDatos
    {
        SqlCommand cmd;
        public int ReducirCantidad(int codigoproducto, int cantidad, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {
                Conexion.Open();
                cmd = new SqlCommand("ReducirStock", Conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", codigoproducto);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                respuesta = cmd.ExecuteNonQuery();
                if (respuesta < 1)
                {
                    mensaje = "No se puede puede vender, no contamos con el stock suficiente, para realizar la venta";
                }
            }
            catch (Exception d)
            {
                mensaje = d.Message;
                respuesta = 0;

            }
            Conexion.Close();
            return respuesta;


        }


        public int Cantidadnormal(int codigoproducto, int cantidad, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {
                Conexion.Open();
                cmd = new SqlCommand("AumentarStock", Conexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", codigoproducto);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                respuesta = cmd.ExecuteNonQuery();
                if (respuesta < 1)
                {
                    mensaje = "No se puede aumentar la cantidad";
                }
            }
            catch (Exception d)
            {
                mensaje = d.Message;
                respuesta = 0;

            }
            Conexion.Close();
            return respuesta;

        }
      
        public int Insertar(Entidades.Ventas venta, out string mensaje)
        {

            mensaje = string.Empty;
            int result = 0;

            using (SqlConnection connection = new SqlConnection(ConexionBasedeDatos.cadenaConexion))
            {
                try
                {
                    connection.Open();
                    StringBuilder cmd = new StringBuilder();
                    cmd.AppendLine("CREATE  TABLE REGISTRO(id INTEGER);");
                    cmd.AppendLine(string.Format("INSERT INTO VENTAS(Id_cliente, Cantidad_productos, Monto_total) values('{0}','{1}','{2}');",
                        venta.Idcliente,
                        venta.CantidadProductos,
                        venta.TotalVenta));
                   cmd.AppendLine("INSERT INTO REGISTRO (id) VALUES (SCOPE_IDENTITY());");

                    foreach (DetalleSalida detalle in venta.ListaDetalleSalida)
                    {
                        cmd.AppendLine(string.Format("INSERT INTO DETALLE_VENTAS(Id_venta,Codigo_producto,Cantidad,Subtotal)values({0},{1},'{2}','{3}');",
                        "(SELECT id FROM REGISTRO)",
                        detalle.CodigoProducto,
                        detalle.Cantidad,
                        detalle.SubTotal));

                    }
                    SqlCommand cemd = new SqlCommand(cmd.ToString(), connection);
                    cemd.CommandType = System.Data.CommandType.Text;
                    result = cemd.ExecuteNonQuery();
                    if (result < 1)
                    {
                   
                        mensaje = "No se pudo registrar la salida de los productos";
                    }
             

                }
                catch (Exception ex)
                {

          
                    result = 0;
                    mensaje = ex.Message;
                }
            }
            return result;

        }

    }
}
