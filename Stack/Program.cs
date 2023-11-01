using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack
            Stack<double> stack = new Stack<double>();
            
            //Push - Insertar objetos al inicio del stack
            stack.Push(1.2);
            stack.Push(3.1);
            stack.Push(5.2);
            stack.Push(2.6);
            stack.Push(4.3);
            int i = 0;
            foreach (double elemento in stack)
            {
                Console.WriteLine("{0} - {1}", i++, elemento);
            }
            
            //Quitando un elemento (pop)
            Console.WriteLine("\nQuitando un elemento (pop)");
            var eliminado = stack.Pop();
            i = 0;
            
            foreach (double elemento in stack)
            {
                Console.WriteLine("{0} - {1}", i++, elemento);
            }
            
            
            Console.WriteLine("El elemento {0} fue eliminado", eliminado);
            
            // peek - Muestra el primer elemento del stack
            //Despues de usar peek
            Console.WriteLine("\nDespues de usar peek");
            var primerElemento = stack.Peek();
            i = 0;
            
            foreach (double elemento in stack)
            {
                Console.WriteLine("{0} - {1}", i++, elemento);
            }
            
            Console.WriteLine("El primer elemento es {0}", primerElemento);
            
            //Saber si el stack contiene un elemento - contains
            bool contiene;
            double buscarElemento;
            
            Console.Write("Ingresa el elemento a buscar: ");
            buscarElemento = Convert.ToDouble(Console.ReadLine());

            contiene = stack.Contains(buscarElemento);

            if (contiene)
            {
                Console.WriteLine("El objeto {0} si se encuentra en el stack", buscarElemento);
            }
            else
            {
                Console.WriteLine("No se encontro el elemento {0}\n", buscarElemento);
            }
            
            
            
        }
    }
}