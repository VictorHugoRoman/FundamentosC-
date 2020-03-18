using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesYExcepciones
{
    public class ClaseStackEjercicio
    {
        Stack pilas = new Stack();//implementa el metodo ueps(ultimas entradas primeras salidas)
        //pilas.Push("Lunes"); //no se pueden acceder a los metodos dentro de este ambito
        public Stack llenarPila()
        {
            //Stack<string> pilas2 = new Stack<string>(); //pila tipada
            pilas.Push("Lunes");
            pilas.Push("Martes");
            pilas.Push("Miercoles");
            pilas.Push("Jueves");
            pilas.Push("Viernes");
            pilas.Push("Sabado");
            pilas.Push("Domingo");
            pilas.Push(8);
            return pilas;
        }       

        public string[] diasSemana()
        {
            string[] diasSemana = new string[7];
            pilas.CopyTo(diasSemana, 0);
            return diasSemana;
        }
        public void imprimirDiasPilas() {
            //pilas.Pop(); //elimina el primer elemento y lo devuelve
            foreach (string pila in pilas)
            {
                Console.WriteLine(pila);
            }

        }
        public int numElementos() {
            return pilas.Count;
        }
        public void borrarElemntos(){
            pilas.Clear();
        }

    }
}
