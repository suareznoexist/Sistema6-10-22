using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Computadores
    {

        public int IdComputador { get; set; }
        public Teclados oTeclados { get; set; }
        public Mouses omouses { get; set; }
        public Laboratorios oLabs { get; set; }
        public int MyProperty { get; set; }
        public List<Cases> oCases { get; set; }

    }
}
