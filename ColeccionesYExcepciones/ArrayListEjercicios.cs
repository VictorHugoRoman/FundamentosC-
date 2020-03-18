using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesYExcepciones
{
    public class ArrayListEjercicios
    {
        ArrayList cursos = new ArrayList();
        //cursos.Add("Matematicas"); //no se pueden acceder a los metodos dentro de este ambito
        public ArrayList llenarCursos()
        {
            //ArrayList cursos = new ArrayList();
            cursos.Add("Matematicas");
            cursos.Add("Comunicacion");
            cursos.Add("Lenguaje");
            cursos.Add(50);
            cursos.Add(45.6);

            cursos.Insert(0, "Educacion Fisica");
            return cursos;
        }
        public void imprimirCursos()
        {
            Console.WriteLine("Numero de elementos " + cursos.Count);
            Console.WriteLine("Primer valor " + cursos[0]);
            foreach (var curso in cursos)
            {
                Console.WriteLine(curso);
            }
        }

    }
}
