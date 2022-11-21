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
        RepositorioEntrada repositorioEntrada = new RepositorioEntrada();

        public ServicioEntrada()
        {
            ListaEntradas = repositorioEntrada.GetEntryList();
        }

        public List<EntradaProducto> GetAll()
        {
            return ListaEntradas = repositorioEntrada.GetEntryList();
        }

        public string Guardar(EntradaProducto entrada)
        {
            string Guardado = string.Empty;
            try
            {
                entrada.MontoTotal = entrada.Cantidad * entrada.PrecioCompra;
                Guardado = repositorioEntrada.AddEntry(entrada);
                return Guardado;
            }
            catch (Exception)
            {
                return "Se ha prodciono un error, no se guardo la entrada";

            }
        }
    }
}
