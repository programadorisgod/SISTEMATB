using System;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class RepositorioAdministrador : ConexionBasedeDatos
    {
 

        SqlCommand cmd;

        public int Consultarlogin(string Usuario, string Clave)
        {
            int count = 0;
            Conexion.Open();
            cmd = new SqlCommand("ConsultaLogin", Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Clave", Clave);
            try
            {
                 cmd.ExecuteNonQuery();
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                return count;
                throw;
            }
            Conexion.Close();
            return count;
           
        }

        public Administrador Capturar()
        {
            Administrador obj = new Administrador();

            try
            {

                Conexion.Open();
                string Query = "Select Cedula, Nombre from Administrador ";
                cmd = new SqlCommand(Query, Conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    obj = new Administrador()
                    {
                        Cedula = reader["Cedula"].ToString(),
                        Nombre = reader["Nombre"].ToString()
                    };
                }
            }
            catch (Exception)
            {

                obj = new Administrador();
            }
            return obj;
        }

    }
}
