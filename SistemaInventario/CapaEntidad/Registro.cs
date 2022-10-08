using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Registro
    {
        public Usuarios oUser { get; set; }
        public int IdRegistro { get; set; }
        public DateTime Fecha { get; set; }
        public Computadores oComputadores { get; set; }
        public string Descripcion { get; set; }
    }
}
