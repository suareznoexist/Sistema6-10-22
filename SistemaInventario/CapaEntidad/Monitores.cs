using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Monitores
    {
        public int IdMonitor { get; set; }
        public Marca oMarca { get; set; }
        public int ModelNumber { get; set; }
        public string  estado { get; set; }
        
    }
}
