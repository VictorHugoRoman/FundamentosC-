using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto.MetodosYClasesAbsatractas
{
    //las clases abstractas sirvern para dar referencia a las clases hijas
    public abstract class Estacion
    {
        //metodo abstracto a implimentar, estos metodos existiran si y solo si la clase es abstracta
        public abstract void sensacion();
        //esta metodo implementado no es observado en las clases hijas, lo es hasta q c instancien las clases hijas
        public void correr()
        {
            Console.WriteLine("correr");
        }
    }
}
