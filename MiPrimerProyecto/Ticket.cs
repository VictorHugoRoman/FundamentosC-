using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    public class Ticket
    {
        private string Color;
        private double Tamanio;
        private int Tipo;
        private int Cantidad;
        
        //metodos de acceso (color)
        public string getColor(){return Color;}
        public void setColor(string color){this.Color = color;}
        
        //metodos de acceso (tamanio)
        public double getTamanio(){return Tamanio;}
        public void setTamanio(double tamanio){this.Tamanio = tamanio;}

        //Metodos de acceso (Tipo), Validamos para guardar Tipo
        public int getTipo(){return Tipo;}
        public void setTipo(int tipo){
            if (tipo == 1 || tipo == 2 || tipo == 3) this.Tipo = tipo;
            else this.Tipo = 1;
        }

        //Metodos de acceso (Cantidad), Validamos para guardar Cantidad
        public int getCantidad(){return Cantidad;}
        public void setCantidad(int cantidad){
            if (cantidad > 0) this.Cantidad = cantidad;
            else this.Cantidad = 1;
        }

        public double calcularPrecio()
        {
            int tipo = this.Tipo;
            switch (tipo)
            {
                case 1: return 5;
                case 2: return 8;
                case 3: return 10;
                default: return 0;
            }
        }

        public double totalPagar()
        {
            double precio = calcularPrecio();
            return precio * this.Cantidad;
        }


    }
}
