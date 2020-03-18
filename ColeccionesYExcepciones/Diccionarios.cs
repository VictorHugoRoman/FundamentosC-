using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesYExcepciones
{
    public class Diccionarios
    {
        // 1  (Domingo)
        //2  (Lunes)
        //3 (Martes)
        
        //Dictionary<clave, valor>
        Dictionary<int, string> diccionario = new Dictionary<int, string>();
        //diccionario.Add(1, "Domingo"); //no se pueden acceder a los metodos dentro de este ambito
        public Dictionary<int, string> LLenarDictionary() {
            //Dictionary<int, string> diccionario = new Dictionary<int, string>();
            diccionario.Add(1, "Domingo");
            diccionario.Add(2, "Lunes");
            diccionario.Add(3, "Martes");
            diccionario.Add(4, "Miercoles");
            diccionario.Add(5, "Jueves");
            diccionario.Add(6, "Viernes");
            diccionario[7] = "Sabado";
            diccionario[8] = "Enero";
            return diccionario;
        }

        public void RemoveByIndexDict() {
            //diccionario.Clear();
            diccionario.Remove(8);
        }
        public void imprimirValoresDict() {
            foreach (string val in diccionario.Values)
                Console.WriteLine(val);
            Console.WriteLine("El numero de elementos es " + diccionario.Count);
        }
    }
}
