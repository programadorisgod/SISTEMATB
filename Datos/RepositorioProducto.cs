using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioProducto : ConexionBasedeDatos
    {

        SqlCommand cmd;
        public string AddProduct(Producto producto)
        {
            Conexion.Open();
            cmd = new SqlCommand("AgregarProducto", Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            cmd.Parameters.AddWithValue("@PrecioVenta", producto.ValorVenta);
            try
            {
                var result = cmd.ExecuteNonQuery();
                Conexion.Close();
                return result == 1 ? "se agregó el producto" : "error al agregar";
            }
            catch (Exception)
            {
                Conexion.Close();
                return "error al agregar ";
            }
        }


        public List<Producto> GetProductList()
        {
            List<Producto> ProductList = new List<Producto>();
            string ssql = String.Format("SELECT * FROM Producto");
            cmd = new SqlCommand(ssql, Conexion);
            Conexion.Open();
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ProductList.Add(new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), double.Parse(reader.GetDecimal(3).ToString()), reader.GetInt32(4)));
            }
            Conexion.Close();

            return ProductList;
        }


        public string EditProduct(Producto producto)
        {
            Conexion.Open();
            cmd = new SqlCommand("EditarProducto", Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@id_cliente ", cliente.id_cliente);
            //cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula);
            //cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            //cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            //cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
            //cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            try
            {
                var result = cmd.ExecuteNonQuery();
                Conexion.Close();
                return result == 1 ? "se edtió el Cliente" : " error al editar ";
            }
            catch (Exception)
            {
                Conexion.Close();
                return "error al editar";
            }


        }

        public int BuscarPorId(string Cedula)
        {
            int count = 0;

            Conexion.Open();
            cmd = new SqlCommand("BuscarID", Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cedula", Cedula);
            try
            {
                cmd.ExecuteNonQuery();
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                Conexion.Close();
                return count;
            }
            Conexion.Close();
            return count;
        }

        public string Elimnar(string Cedula)
        {

            Conexion.Open();
            cmd = new SqlCommand("Eliminar", Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cedula", Cedula);
            try
            {
                var result = cmd.ExecuteNonQuery();
                Conexion.Close();
                return result == 1 ? "se eliminó el Cliente" : "error al eliminar el cliente ";
            }
            catch (Exception)
            {
                Conexion.Close();
                return "error al editar";
            }
        }
    }
}
