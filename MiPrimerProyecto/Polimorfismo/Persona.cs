using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto.Polimorfismo
{
    //Super clase q hara enfasis que una persona puede ser empleado y cliente y q todas las personas tienen nombre, apellido materno y paterno
    public class Persona
    {
        public string nombre { get; set; }
        public string apPaterno { get; set; }
        public string apMaterno { get; set; }
    }
}
