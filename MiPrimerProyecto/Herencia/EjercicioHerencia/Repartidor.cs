using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto.Herencia.EjercicioHerencia
{
    public class Repartidor : Empleado
    {
        public string zona { get; set; }

        //implementamos plus de la clase Empleado
        public override double plus()
        {
            if (edad < 35 && zona.Equals("zona 3")) salario = salario + PLUS;
            return salario;
        }
        //esta propiedad no es accesible si instanciamos esta clase con empleado (polimorfismo)
        public double plus2 {
            get {
                if (edad < 35 && zona.Equals("zona 3")) salario = salario + PLUS;
                return salario;
            }
        }
    }
}
