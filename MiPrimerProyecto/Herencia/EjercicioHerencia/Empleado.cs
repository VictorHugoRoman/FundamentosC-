using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto.Herencia.EjercicioHerencia
{
    public abstract class Empleado
    {
        //ReadOnly te indica es una constante
        public readonly int PLUS = 400;

        public string nombre { get; set; }
        public int edad { get; set; }
        public double salario { get; set; }

        //metodo a implementar
        public abstract double plus();

    }
}
