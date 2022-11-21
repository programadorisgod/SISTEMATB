using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class ServicioProducto : IserviceStandard<Producto>
    {
        List<Producto> ListaProductos;
        RepositorioProducto repositorioProducto = new RepositorioProducto();
        public ServicioProducto()
        {
            ListaProductos = repositorioProducto.GetProductList();
        }
        public List<Producto> GetAll()
        {
            return ListaProductos = repositorioProducto.GetProductList();
        }
        public string Guardar(Producto producto)
        {
            string Guardado = string.Empty;
            try
            {
                if (GetById(producto, -1) == null)
                {
                    Guardado = repositorioProducto.AddProduct(producto);
                    return Guardado;
                }
                else
                {
                    return "Ya existe un producto con este codigo";
                }

            }
            catch (Exception)
            {
                return "Se ha producido un error, el producto no fue guardado";

            }
        }
        public string Delete(Producto producto)
        {
            try
            {
                repositorioProducto.DeleteProduct(producto);
                ListaProductos = GetAll();
                return "El producto fue eliminado correctamente";
            }
            catch (Exception)
            {
                return "El producto no fue eliminado correctamente";
            }
        }
        public string Edit(Producto producto, int row)
        {
            try
            {
                return repositorioProducto.EditProduct(producto);
            }
            catch (Exception)
            {
                return "Producto no editado";
            }
        }
        public Producto GetById(Producto producto, int row)
        {
            ListaProductos = GetAll();

            for (int i = 0; i < ListaProductos.Count; i++)
            {
                if (ListaProductos[i].Codigo == producto.Codigo && i != row)
                {
                    return ListaProductos[i];
                }
            }

            return null;
        }
    }
}
