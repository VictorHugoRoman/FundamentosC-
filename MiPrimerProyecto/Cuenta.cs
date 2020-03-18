using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
   public class Cuenta
    {
        /*public Cuenta()//constructor default puede estar oculto
        {

        }*/
        private string Titular { get; set; }
        private double Cantidad { get; set; }

        //Propiedad Titular (get y set)
        public string getTitular(){return Titular;}
        public void setTitular(string titular){this.Titular = titular;}
        
        //Propiedad cantidad (get y set)
        public double getCantidad(){return Cantidad;}
        public void setCantidad(double cantidad){
            if (cantidad > 0) this.Cantidad = cantidad;
            else this.Cantidad = 0;
        }
        
        //metodos
        public void Ingresar(double cantidad){
            this.Cantidad = this.Cantidad + cantidad;
        }
        public void Retirar(double cantidad){
            this.Cantidad = this.Cantidad - cantidad;
        }


    }
}
