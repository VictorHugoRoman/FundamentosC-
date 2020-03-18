using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto.MetodosYClasesAbsatractas
{
    //en esta clase hija implementamos los metodos abstractos de la super clase Estacion
    public class Verano : Estacion
    {
        //implementamos el metodo sensacion de la super clase Estacion con override
        public override void sensacion()
        {
            Console.WriteLine("Calor");
        }



    }
}
