using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto.Herencia
{
    //Implementamos la clase empleado que hereda de la clase persona, al instanciar el empleado accederemos a persona
    public class Empleado : Persona
    {
        public int IdEmpleado { get; set; }
        public double sueldo { get; set; }
        public DateTime fechaContrato{ get; set; }

        //Herencia.Empleado.Anidada nested = new Herencia.Empleado.Anidada(new Herencia.Empleado());
        //nested.parent
        public class Anidada
        {
            public Empleado parent;

            public Anidada()
            {
            }
            public Anidada(Empleado parent2)
            {
                this.parent = parent2;
            }
        }
    }
}
