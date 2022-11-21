using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IserviceProduct<T>
    {
        string Guardar(T producto);
        string Delete(T producto);
        string Edit(T productonuevo, int row);
        List<T> GetAll();
        T GetById(T cliente, int id);
    }
}
