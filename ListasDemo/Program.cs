using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista miLista = new Lista();
            miLista.Insertar(4);
            miLista.Insertar(7);
           // miLista.Insertar(5);
            miLista.Insertar(8);
            miLista.InsertarAlFrente(1);
            miLista.Imprimir();
            miLista.EliminarPrimero();
            miLista.EliminarUltimo();
            Console.WriteLine("Actualizacion....");
            miLista.Imprimir();
            Console.ReadKey();
        }
    }
}
