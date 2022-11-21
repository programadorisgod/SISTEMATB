using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Datos
{
    public class ConexionBasedeDatos
    {
        public static string cadenaConexion = "Server=.\\SQLEXPRESS; Database= GESTION_INVENTARIO_TB; Trusted_Connection=True;";
        public SqlConnection Conexion;
        public ConexionBasedeDatos()
        {
            Conexion = new SqlConnection(cadenaConexion);
        }

        public bool Abrir()
        {
            try
            {
                Conexion.Open();
                if (Conexion.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Cerrar()
        {
            try
            {     
                 
                if (Conexion.State == System.Data.ConnectionState.Open)
                {
                    Conexion.Close();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                Conexion.Close();
                throw;
            }

        }
    }
}
