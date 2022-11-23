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
                return result == 1 ? "se agregó el producto" : "error al agregar el Producto";
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
            cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
            cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
            cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
            cmd.Parameters.AddWithValue("@PrecioVenta", producto.ValorVenta);
            try
            {
                var result = cmd.ExecuteNonQuery();
                Conexion.Close();
                return result == 1 ? "se edtió el Producto" : "error al editar el Producto";
            }
            catch (Exception)
            {
                Conexion.Close();
                return "error al editar";
            }
        }

        public string DeleteProduct(Producto producto)
        {
            Conexion.Open();
            cmd = new SqlCommand("EliminarProducto", Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);
            try
            {
                var result = cmd.ExecuteNonQuery();
                Conexion.Close();
                return result > 0 ? "se eliminó el Producto" : "error al eliminar el Producto";
            }
            catch (Exception)
            {
                Conexion.Close();
                return "error al eliminar";
            }
        }

        public List<Producto> Search(string attribute, string sentence)
        {
            List<Producto> ProductList = new List<Producto>();
            try
            {
                string ssql = String.Format("SELECT * FROM Producto WHERE " + attribute + " LIKE '%" + sentence + "%'");
                cmd = new SqlCommand(ssql, Conexion);
                Conexion.Open();
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ProductList.Add(new Producto(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), double.Parse(reader.GetDecimal(3).ToString()), reader.GetInt32(4)));
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                Conexion.Close();
                return ProductList;
            }

            return ProductList;
        }
    }
}
