using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cases
    {
        public int IdCase { get; set; }
        public int Ram { get; set; }
        public string Procesador { get; set; }
        public double Velocidad { get; set; }
        public int Almacenamiento { get; set; }
        public SistemaOperativo oSistama { get; set; }
        public string estado { get; set; }

        public DateTime FechaCompra { get; set; }
        public DateTime FechaFabricacion { get; set; }

    }
}
