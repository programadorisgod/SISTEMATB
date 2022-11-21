using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioVentas
    {
        Datos.RepositorioVentas repositorioVentas = new Datos.RepositorioVentas();
        Datos.RepositorioCliente repositorioCliente = new Datos.RepositorioCliente();
        public int reducirCantidad(int codigoproducto, int cantidad, out string mensaje)
        {

            return repositorioVentas.ReducirCantidad(codigoproducto, cantidad, out mensaje);
        }

        public int CantidadNormal(int codigoproducto, int cantidad, out string mensaje)
        {
            return repositorioVentas.Cantidadnormal(codigoproducto, cantidad, out mensaje);
        }
        public int Insertar(Entidades.Ventas venta, out string mensaje)
        {
          return repositorioVentas.Insertar(venta, out mensaje);
        }
        public int BuscarporID(string cedula)
        {
            return repositorioCliente.BuscarPorId(cedula);
        }
    }
}
