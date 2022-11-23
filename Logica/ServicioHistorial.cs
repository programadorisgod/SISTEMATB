using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioHistorial
    {
        Datos.RepositorioHistorial repositorioHistorial = new Datos.RepositorioHistorial();
        public Entidades.Ventas Obtener(string fecha, string cedula)
        {
            return repositorioHistorial.Reporte(fecha, cedula);
        }

        public List<DetalleSalida> salidas(int id_salida)
        {
            return repositorioHistorial.ListarDetalleSalidas(id_salida);
        }
        public List<ReporteVentas> reporteVentas(string fechainicio, string fechafinal)
        {
            return repositorioHistorial.GetReporteVentas(fechainicio, fechafinal);
        }
    }
}
