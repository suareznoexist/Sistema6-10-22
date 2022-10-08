using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Equipos
    {
        public int IdEquipo { get; set; }
        public string Tipo { get; set; }
        public Laboratorios oIdlabs { get; set; }
        public  string Estado { get; set; }
        public Marca oMarca { get; set; }

        public int modelnumber { get; set; }



    }
}
