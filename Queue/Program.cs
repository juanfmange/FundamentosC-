using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue
            Queue<char> fila = new Queue<char>();
            
            //Agreegando objetos al Queue
            fila.Enqueue('A');
            fila.Enqueue('B');
            fila.Enqueue('C');
            fila.Enqueue('D');

            int i = 0;
            
            //Recorriendo el Queue
            foreach (char elemento in fila)
            {
                Console.WriteLine("Elemento {0}: {1}", ++i, elemento);
            }
            
            //Agregando otro objeto al queue
            Console.WriteLine("Agregando otro elemento al Queue");
            fila.Enqueue('E');
            i = 0;
            foreach (char elemento in fila)
            {
                Console.WriteLine("Elemento {0}: {1}", ++i, elemento);
            }
            
            //Eliminando el primer elemento del Queue
            Console.WriteLine("Eliminando un elemento del Queue");
            fila.Dequeue();
            i = 0;
            foreach (char elemento in fila)
            {
                Console.WriteLine("Elemento {0}: {1}", ++i, elemento);
            }
            // Puedo usar los metodos peek, contains, clear como en los stacks
        }
    }
}