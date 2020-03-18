using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ejemplo Instancia objetos
             * Cuenta objCuenta = new Cuenta();
             Tipo(clase) nombreObj = new"palabra reservada" nombreConstructor(); //el nombreConstructor por sintaxis es el nombre de la clase
             */
            
            Console.ReadLine();

            //* Ejercicio Herencia
            //Herencia.EjercicioHerencia.Comercial oEmplComercial = new Herencia.EjercicioHerencia.Comercial();
            //Herencia.EjercicioHerencia.Empleado oEmplComercial2 = new Herencia.EjercicioHerencia.Comercial(); //no hacemos accessible las propiedades puras de la clase a instanciar (Comercial)
            //Herencia.EjercicioHerencia.Repartidor oEmplRepartidor = new Herencia.EjercicioHerencia.Repartidor();

            //oEmplComercial.nombre = "Vicotor";
            //oEmplComercial.edad = 29 ;
            //oEmplComercial.salario = 4000;
            //oEmplComercial.comision = 1000;
            //oEmplComercial.plus();
            //Console.WriteLine(string.Concat(oEmplComercial.nombre, " ",oEmplComercial.salario));
            //oEmplRepartidor.nombre = "Hugo";
            //oEmplRepartidor.edad = 29;
            //oEmplRepartidor.salario = 2000;
            //oEmplRepartidor.zona = "zona 3";
            //oEmplRepartidor.plus();
            //Console.WriteLine(string.Concat(oEmplRepartidor.nombre, " ",oEmplRepartidor.salario));

            //* Polimorfismo
            //Polimorfismo.Persona oPersona = new Polimorfismo.Persona();
            //oPersona.nombre = "Victor";
            //oPersona.apPaterno = "Roman";
            //oPersona.apMaterno = "Ruiz";
            // instanciamos cliente y empleado de la clase padre persona aqui aplica el polimorfismo
            //Polimorfismo.Persona oCliente = new Polimorfismo.Cliente();
            //Polimorfismo.Persona oEmpleado = new Polimorfismo.Empleado();           

            //* Abstraccion
            //MetodosYClasesAbsatractas.Estacion oEstacion = new MetodosYClasesAbsatractas.Estacion(); las clases abstraactas no se pueden implementar
            //MetodosYClasesAbsatractas.Invierno oInvieron = new MetodosYClasesAbsatractas.Invierno();
            //oInvieron.sensacion();
            //oInvieron.correr();

            //* ejemplo metodo stattic
            //string saludo = Persona.Saludo("Victor");

            //*ejemplo modificadores de acceso
            //Persona oPersona = new Persona();
            //oPersona.setNombre("Rodrigo");
            //oPersona.setEdad(10);
            //oPersona.setSueldo(1700);
            //string datosoPersona = string.Concat("Nombre: ", oPersona.getNombre(), " Edad: ", oPersona.getEdad(), " Sueldo: ", oPersona.sueldo);

            //*Herencia 
            //Herencia.Cliente cli = new Herencia.Cliente();
            //cli.Nombre = "Victor";
            //cli.direccion = "Natoches";
            //Herencia.Empleado emp = new Herencia.Empleado();
            //emp.Nombre = "Hugo";
            //emp.fechaContrato = DateTime.Now;
            //emp.sueldo = 123.123;

            //* SeobreEscrityura de metodos
            //SobreEscrituraMetodos.Herencia.Fruta oFruta = new SobreEscrituraMetodos.Herencia.Fruta();
            //oFruta.color();
            //SobreEscrituraMetodos.Herencia.Fresa oFresa = new SobreEscrituraMetodos.Herencia.Fresa();
            //oFresa.color();
            //SobreEscrituraMetodos.Herencia.Pera oPera= new SobreEscrituraMetodos.Herencia.Pera();
            //oPera.color();
            //Console.WriteLine();
        }
    }
}
