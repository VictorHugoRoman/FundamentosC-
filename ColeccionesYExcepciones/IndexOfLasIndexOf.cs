using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesYExcepciones
{
    class IndexOfLasIndexOf
    {
        readonly string distrito = "Puente uuuu Piedra";
        public int IndexOf() {
            //distrito.IndexOf("u");//retorna 1, ya que u se encuentra en la sgunda letra
            return distrito.IndexOf("u", 2);//retorna 7 ya q busca despues del indice 2
        }
        public int LastIndexOf()
        {
            return distrito.LastIndexOf("u");//retorna 10, ya que s la ultima u mas cercana al final de la cadena
            //return distrito.IndexOf("u", 2);//retorna 7 ya q busca despues del indice 2
        }

    }
}
