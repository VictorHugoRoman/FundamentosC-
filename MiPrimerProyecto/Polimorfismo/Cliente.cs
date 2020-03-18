using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto.Polimorfismo
{
    //Clase para describir a un cliente, heredadmos a persona sabiendo q un cliente es una persona
    //con esto una persona se podra instanciar de un cliente (polimorfismo) Persona objPersona = new Cliente();
    public class Cliente : Persona
    {
        public int IdCliente { get; set; }
        public string gustos { get; set; }
        public string preferencias { get; set; }
    }
}
