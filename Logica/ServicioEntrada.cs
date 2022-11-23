using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    public class ServicioEntrada
    {
        List<EntradaProducto> ListaEntradas;
        List<VistaEntradaProducto> ListaVista;
        RepositorioEntrada repositorioEntrada = new RepositorioEntrada();

        public ServicioEntrada()
        {
            ListaEntradas = repositorioEntrada.GetEntranceList();
            ListaVista = repositorioEntrada.GetListViewEntrance();
        }

        public List<EntradaProducto> GetAll()
        {
            return ListaEntradas = repositorioEntrada.GetEntranceList();
        }

        public List<VistaEntradaProducto> GetAllOfView()
        {
            return ListaVista = repositorioEntrada.GetListViewEntrance();
        }

        public string Guardar(EntradaProducto entrada)
        {
            string Guardado = string.Empty;
            try
            {
                entrada.MontoTotal = entrada.Cantidad * entrada.PrecioCompra;
                Guardado = repositorioEntrada.AddEntrance(entrada);
                return Guardado;
            }
            catch (Exception)
            {
                return "Se ha prodciono un error, no se guardo la entrada";

            }
        }

        public List<VistaEntradaProducto> Search(string attribute, string sentence)
        {
            return repositorioEntrada.Search(attribute, sentence);
        }
    }
}
