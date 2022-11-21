using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;


namespace Logica
{
    public class ServiciosAdministrador : IserviceAdmin
    {
      Datos.RepositorioAdministrador repositorioAdministrador = new Datos.RepositorioAdministrador();
        public int ConSQL(string user, string password)
        {
            return repositorioAdministrador.Consultarlogin(user, password);
          
        }

        public Administrador Obtener() {
           return repositorioAdministrador.Capturar();
         } 
        
    }
}