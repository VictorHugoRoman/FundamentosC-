using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto.Herencia
{
    //Implementamos la clase cliente que hereda de la clase persona, al instanciar el cliente accederemos a persona
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }
        public string direccion { get; set; }
    }
}
