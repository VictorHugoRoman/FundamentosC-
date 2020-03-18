using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraMetodos
{
    //Super Clase
   public class Fruta
    {
        //con virtual podemos sobreescribir esta funcion en las clases hijas
        public virtual void color()
        {
            Console.WriteLine("Tiene varios colores");
        }
    }
}
