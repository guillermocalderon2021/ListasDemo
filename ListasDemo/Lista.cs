using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDemo
{
    class Lista
    {
        // Referencia al primer elemento de la lista
        private Nodo primero;
        // Referencia al ultimo elemento de la lista
        private Nodo ultimo;
        // Cantidad de nodos de la lista
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        // { 4, 7, 5, 8}
        // nuevo =8   primero =4  ultimo=8
        // 4 -> 7->5->8>null

        //Este método inserta un nodo al final de la lista
        public void Insertar(int valor)
        {
            // Creamos un nodo con el valor que se recibe como parametro
            Nodo nuevo = new Nodo(valor);
            if (primero==null) // Si no hay ningun nodo en la lista
            {
                primero = nuevo; 
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else // si ya hay algun elemento en la lista
            {
                //Le agregamos la referencia al ultimo nodo
                ultimo.Siguiente = nuevo;
                // El nuevo nodo se convierte en el ultimo
                ultimo = nuevo;
                // El ultimo elemento apunta a null
                ultimo.Siguiente = null;
            }
            cantidad++; //aumentamos el contador de nodos
        }

        //1
        // { 4, 7, 5, 8}
        // nuevo =1   primero =1  ultimo=8
        // 1-> 4 -> 7->5->8>null
        public void InsertarAlFrente(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            if (primero == null) // Si no hay ningun nodo en la lista
            {
                primero = nuevo;
                primero.Siguiente = null;
                ultimo = nuevo;
            }
            else // Si ya hay algun elemento en la lista
            {
                //El elemento nuevo se convirte el primero y apunta hacia el "primero anterior"
                nuevo.Siguiente = primero;
                primero = nuevo;

           
            }
            cantidad++;//aumentamos el contador de nodos
        }

        // Método que elimina el primer elemento de la lista
        public bool EliminarPrimero()
        {
            if (primero == null) // Si la lista está vacia
            {
                return false;
            }
            else
            {
                Nodo auxiliar = new Nodo();
                auxiliar = primero; // Guardamos en "auxiliar" el nodo a eliminar
                primero = primero.Siguiente; // El "siguiente" del primer nodo se convierte en el "primero"
                auxiliar.Siguiente = null; // Rompemos la referencia
                cantidad--; // Disminuimos el contador de nodos
                return true;
            }
        }

        // Método que elimina el ultimo elemento de la lista
        public bool EliminarUltimo()
        {
            if (primero == null) // si la lista está vacía
            {
                return false;
            }
            else
            {
                Nodo auxiliar = new Nodo();
                //Debemos recorrer la lista hasta el penultimo elemento
                auxiliar = primero;
                while (auxiliar.Siguiente != ultimo)
                {
                    auxiliar = auxiliar.Siguiente;
                }
                ultimo = auxiliar; // El penultimo elemento del recorrido se convierte en el último de la lista
                auxiliar.Siguiente = null; //Rompemos la referencia del último elemento
                cantidad--;// Disminuimos el contador de nodos
                return true;
            }
        }

      // Método que recorre e imprime los elementos de la lista
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

        // Este método devuelve el indice de la primera ocurrencia de un elemento
        public int ObtenerIndice(int valor)
        {
            int indice = 0;
            Nodo actual = new Nodo();
            actual = primero;
            while (actual != null)
            {
                // Si el dato del nodo actual coincide con el valor buscado
                if (actual.Dato == valor)
                {
                    // Retornamos el indice
                    return indice;
                }
           
                actual = actual.Siguiente; // Nos desplazamos al siguiente elemento
                indice++; // Aumentamos el indice
            }
            // Si sale del while es porque se recorrio toda la lista y no se encontró el valor
            return -1; // Retornamos -1 para indicar que ese dato no se encuentra en la lista
        }

    }
}
