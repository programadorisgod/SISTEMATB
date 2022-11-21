using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IserviceStandard<T>
    {
        string Guardar(T anything);
        string Delete(T anything);
        string Edit(T anything, int row);
        List<T> GetAll();
        T GetById(T anything, int row);
    }
}
