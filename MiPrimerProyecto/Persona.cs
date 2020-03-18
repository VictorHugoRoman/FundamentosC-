using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    class Persona
    {
        //Lo que queremos almacenar
        private int idEmpleado { get; set; }
        private string Nombre { get; set; }
        public string Nombre2 { get; private set; }
        private string apMaterno { get; set; }
        private string apPaterno { get; set; }        
        private short edad{ get; set; }
        public  double sueldo { get; private set; }

        //Modificadore propiedad nombre ya que estan privates
        public string getNombre() {
            return this.Nombre;
        }
        public void setNombre(string nombre) {
            this.Nombre=nombre;
        }
        //Modificadore propiedad Nombre2, equivale a las instrucciones de Nombre
        public void setNombre2(string nombre){
            this.Nombre2 = nombre;
        }
        //Modificadore propiedad apMaterno
        public string getapMaterno(){
            return this.apMaterno;
        }
        public void setapMaterno(string apMaterno){
            this.apMaterno = apMaterno;
        }
        //Modificadore propiedad edad
        public short getEdad(){
            return this.edad;
        }
        public void setEdad(short edad){
            if (edad >= 0 && edad < 199) this.edad = edad; else this.edad = 0;
        }
        //Modificadore propiedad edad
        public void setSueldo(double sueldo)
        {
            if (sueldo >= 0) this.sueldo= sueldo; else this.sueldo = 0;
        }

        //estos metodos aplican en la instancia del objeto
        public string NombreCompleto() {
            return string.Concat(Nombre, " ", apPaterno, " ", apMaterno);
        }
        public double CalcularSueldoAnual(){
            return sueldo * 12;
        }
        public void aumentarSueldo(double sueldo) {
            this.sueldo += sueldo;
        }
        public void disminuirSueldo(double cantidad){
            this.sueldo -= cantidad;
        }
        //no pertenecen (static) a la instancia del objecto, 
        public static string Saludo(string nombre) {
            //CalcularSueldoAnual(); solo se pueden llamar metodos static dentro de un metodo static
            return string.Concat("Hola Como Estás ", nombre);
        }
    }
}
