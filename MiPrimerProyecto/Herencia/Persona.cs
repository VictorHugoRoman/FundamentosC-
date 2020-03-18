using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto.Herencia
{
    //Super Clase General
    public class Persona
    {
        public string Nombre { get; set; }
        public string Nombre2 { get; set; }
        public string apMaterno { get; set; }
        public string apPaterno { get; set; }
        public int edad { get; set; }

        public string nombreCompleto() { return string.Concat(Nombre, " ", apPaterno, " ", apMaterno); }
        public string nombreCompleto2 { get { return string.Concat(Nombre, " ", apPaterno, " ", apMaterno); } }
    }
}
