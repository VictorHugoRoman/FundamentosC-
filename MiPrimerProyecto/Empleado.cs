using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    class Empleado
    {
        public Empleado()
        {

        }
        private int idEmpleado{ get; set; }
        private string Nombre { get; set; }
        private string apMaterno { get; set; }
        private string apPaterno { get; set; }
        private int MyProperty { get; set; }
        private double sueldo { get; set; }

        public double getSueldo() {
            return this.sueldo;
        }
        private void setSueldo(double sueldo) {
            if (sueldo > 0) this.sueldo = sueldo; else this.sueldo = 0;
        }
    }
}
