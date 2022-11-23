using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioEntrada : ConexionBasedeDatos
    {
        SqlCommand cmd;
        public string AddEntrance(EntradaProducto entrada)
        {
            Conexion.Open();
            cmd = new SqlCommand("AgregarEntrada", Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cedula", entrada.CedulaProveedor);
            cmd.Parameters.AddWithValue("@Codigo", entrada.CodigoProducto);
            cmd.Parameters.AddWithValue("@Cantidad", entrada.Cantidad);
            cmd.Parameters.AddWithValue("@PrecioCompra", entrada.PrecioCompra);
            cmd.Parameters.AddWithValue("@MontoTotal", entrada.MontoTotal);
            try
            {
                var result = cmd.ExecuteNonQuery();
                Conexion.Close();
                return result == 2 ? "se agregó la Entrada" : "error al agregar la Entrada";
            }
            catch (Exception)
            {
                Conexion.Close();
                return "error al agregar";
            }
        }
        public List<EntradaProducto> GetEntranceList()
        {
            List<EntradaProducto> EntranceList = new List<EntradaProducto>();
            string ssql = String.Format("SELECT * FROM Entrada");
            cmd = new SqlCommand(ssql, Conexion);
            Conexion.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                EntranceList.Add(new EntradaProducto(reader.GetInt32(0), reader.GetDateTime(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), double.Parse(reader.GetDecimal(5).ToString()), double.Parse(reader.GetDecimal(6).ToString())));
            }

            Conexion.Close();
            return EntranceList;
        }

        public List<VistaEntradaProducto> GetListViewEntrance()
        {
            List<VistaEntradaProducto> ListViewEntrance = new List<VistaEntradaProducto>();
            string ssql = String.Format("SELECT entry.FechaRegistro, CONCAT(entry.id_proveedor, '/', (SELECT Nombre FROM Proveedores WHERE id_provedor = entry.id_proveedor)), CONCAT(entry.codigo_producto, '/', (SELECT Nombre FROM Producto WHERE Codigo = entry.codigo_producto)), Cantidad, Precio_compra, Monto_total FROM Entrada entry");
            cmd = new SqlCommand(ssql, Conexion);
            Conexion.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewEntrance.Add(new VistaEntradaProducto(reader.GetDateTime(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), double.Parse(reader.GetDecimal(4).ToString()), double.Parse(reader.GetDecimal(5).ToString())));
            }

            Conexion.Close();
            return ListViewEntrance;
        }

        public List<VistaEntradaProducto> Search(string attribute, string sentence)
        {
            List<VistaEntradaProducto> ListViewEntrance = new List<VistaEntradaProducto>();
            try
            {
                string ssql = String.Format("SELECT entry.FechaRegistro, CONCAT(entry.id_proveedor, '/', (SELECT Nombre FROM Proveedores WHERE id_provedor = entry.id_proveedor)), CONCAT(entry.codigo_producto, '/', (SELECT Nombre FROM Producto WHERE Codigo = entry.codigo_producto)), Cantidad, Precio_compra, Monto_total FROM Entrada entry WHERE " + attribute + " LIKE '%" + sentence + "%'");
                cmd = new SqlCommand(ssql, Conexion);
                Conexion.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewEntrance.Add(new VistaEntradaProducto(reader.GetDateTime(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), double.Parse(reader.GetDecimal(4).ToString()), double.Parse(reader.GetDecimal(5).ToString())));
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                return ListViewEntrance;
            }

            return ListViewEntrance;
        }
    }
}
