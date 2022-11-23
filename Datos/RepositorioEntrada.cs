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
        public string AddEntry(EntradaProducto entrada)
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

        public List<EntradaProducto> GetEntryList()
        {
            List<EntradaProducto> EntryList = new List<EntradaProducto>();
            string ssql = String.Format("SELECT * FROM Entrada");
            cmd = new SqlCommand(ssql, Conexion);
            Conexion.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                EntryList.Add(new EntradaProducto(reader.GetInt32(0), reader.GetDateTime(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), double.Parse(reader.GetDecimal(5).ToString()), double.Parse(reader.GetDecimal(6).ToString())));
            }
            Conexion.Close();

            return EntryList;
        }

        public List<EntradaProducto> Search(string attribute, string sentence)
        {
            List<EntradaProducto> EntryList = new List<EntradaProducto>();
            try
            {
                string ssql = String.Format("SELECT * FROM Entrada WHERE " + attribute + " LIKE '%" + sentence + "%'");
                cmd = new SqlCommand(ssql, Conexion);
                Conexion.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    EntryList.Add(new EntradaProducto(reader.GetInt32(0), reader.GetDateTime(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), double.Parse(reader.GetDecimal(5).ToString()), double.Parse(reader.GetDecimal(6).ToString())));
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                return EntryList;
            }

            return EntryList;
        }
    }
}
