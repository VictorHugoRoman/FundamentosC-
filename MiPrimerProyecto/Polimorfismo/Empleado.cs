using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto.Polimorfismo
{
    //Clase para describir a un empleado, heredadmos a persona sabiendo q un empleado es una persona
    //con esto una persona se podra instanciar de un empleado (polimorfismo) Persona objPersona = new Empleado();
    public class Empleado : Persona
    {
        public double sueldo { get; set; }
        public int diasLaborados { get; set; }
    }
}
