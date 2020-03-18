using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreEscrituraMetodos
{
    //clase hija que hereda de Fruta
    //Fruta oPera = new Pera();
    public class Pera : Fruta
    {
        //con override sobreescribimos el metodo virtual de la clase padre Fruta, ahora retornará Verde        
        public override void color()
        {
            Console.WriteLine("Verde");
        }

    }
}
