using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuarios
    {
        public int IdUser { get; set; }
        public string Nameuser { get; set; }
        public string rol { get; set; }
    }

    public class Permisos
    {
        public int idpermiso { get; set; }
        public rol oRol { get; set; }
        public string menus { get; set; }
    }

    public class rol
    {
        public int IdRol { get; set; }
        public string Rolll { get; set; }


    }
}
