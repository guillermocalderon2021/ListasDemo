using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDemo
{
    class DemoList
    {
        static void main(string[] args)
        {

            List<String> miLista = new List<String>(); //Declarando un objeto de la clase List
            // Agregando elementos a la lista (se agregan al final de la estructura)
            miLista.Add("Guillermo");
            miLista.Add("Diego");
            miLista.Add("Fernando");
            miLista.Add("Marta");
            miLista.Add("Fatima");
            // Eliminando un elemento de la lista
            miLista.Remove("Diego");
            // Eliminando el elemento de la posicion 2
            miLista.RemoveAt(2);
            // Invirtiendo el orden de los elementos de la lista
            miLista.Reverse();
            // Insertando un elemento en la posicion 1 de la lista
            miLista.Insert(1, "Miguel");
           
            // Recorriendo la lista
            foreach (String nombre in miLista)
            {
                Console.WriteLine(nombre);
            }

            Console.WriteLine("Tamaño:" + miLista.Count);
            Console.WriteLine("Fernando esta en la posicion: "+ miLista.IndexOf("Fernando"));
            Console.ReadKey();
        }
    }
}
