using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraMetodos
{
    //Fruta oFresa = new Fresa();
    //clase hija que hereda de Fruta
    public class Fresa : Fruta
    {
        //con override sobreescribimos el metodo virtual de la clase padre Fruta, ahora retornará Rojo
        public override void color()
        {
            Console.WriteLine("Rojo");
        }
    }
}
