using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioProveedor
    {
        List<Proveedor> ListaProveedores;
        RepositorioProveedor repositorioProveedor = new RepositorioProveedor();
        public ServicioProveedor()
        {
            ListaProveedores = repositorioProveedor.GetProviderList();
        }
        public List<Proveedor> GetAll()
        {
            return ListaProveedores = repositorioProveedor.GetProviderList();
        }
        public string Guardar(Proveedor proveedor)
        {
            string Guardado = string.Empty;
            try
            {
                if (GetById(proveedor, -1) == null)
                {
                    Guardado = repositorioProveedor.AddProvider(proveedor);
                    return Guardado;
                }
                else
                {
                    return "Ya existe un producto con este codigo";
                }

            }
            catch (Exception)
            {
                return "Se ha prodciono un error, el producto no fue guardado";

            }
        }
        public string Delete(Proveedor proveedor)
        {
            try
            {
                repositorioProveedor.DeleteProvider(proveedor);
                ListaProveedores = GetAll();
                return "El proveedor fue eliminado correctamente";
            }
            catch (Exception)
            {
                return "El proveedor no fue eliminado correctamente";
            }
        }
        public string Edit(Proveedor proveedor, int row, string Cedula)
        {
            var Encontro = GetById(proveedor, row);
            try
            {
                if (Encontro == null)
                {
                    return repositorioProveedor.EditProvider(proveedor, Cedula);
                }
                else
                {
                    return "Ya existe un proveedor con esta cedula";
                }
            }
            catch (Exception)
            {
                return "Proveedor no editado";
            }
        }
        public Proveedor GetById(Proveedor proveedor, int row)
        {
            ListaProveedores = GetAll();

            for (int i = 0; i < ListaProveedores.Count; i++)
            {
                if (ListaProveedores[i].Cedula == proveedor.Cedula && i != row)
                {
                    return ListaProveedores[i];
                }
            }

            return null;
        }

        public List<Proveedor> Search(string attribute, string sentence)
        {
            return repositorioProveedor.Search(attribute, sentence);
        }
    }
}
