using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaNegocios
    
{
    public class CNUser
    {

        private CDUsers obCDUser = new CDUsers();
        public List<Usuarios> listaUsuarios() //retorna la lista
        {
            return obCDUser.listaUsuarios();           
        
        }
    }
}
