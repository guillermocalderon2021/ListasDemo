using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDemo
{
    class Lista
    {
        private Nodo primero;
        private Nodo ultimo;

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        // { 4, 7, 5, 8}
        // nuevo =8   primero =4  ultimo=8
        // 4 -> 7->5->8>null

        public void Insertar(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (primero==null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
                ultimo.Siguiente = null;
            }
        }

        //1
        // { 4, 7, 5, 8}
        // nuevo =1   primero =1  ultimo=8
        // 1-> 4 -> 7->5->8>null


        public void InsertarAlFrente(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else
            {
                nuevo.Siguiente = primero;
                primero = nuevo;

           
            }
        }

        public bool EliminarPrimero()
        {
            if (primero == null)
            {
                return false;
            }
            else
            {
                Nodo auxiliar = new Nodo();
                auxiliar = primero;
                primero = primero.Siguiente;
                auxiliar.Siguiente = null;
                return true;
            }
        }

        public bool EliminarUltimo()
        {
            if (primero == null)
            {
                return false;
            }
            else
            {
                Nodo auxiliar = new Nodo();
                auxiliar = primero;
                // auxiliar=7
                // {4, 7}
                while (auxiliar.Siguiente != ultimo)
                {
                    auxiliar = auxiliar.Siguiente;
                }
                ultimo = auxiliar;
                auxiliar.Siguiente = null;

               // auxiliar = ultimo.Siguiente;
               // auxiliar.Siguiente = null;

                return true;
            }
        }




        public void Imprimir()
        {
            Nodo actual = new Nodo();
            actual = primero;
            while (actual != null)
            {
                Console.WriteLine(actual.Dato);
                actual = actual.Siguiente;
            }
        }

    }
}
