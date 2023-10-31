using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables globales
            string elem;
            int option;
            int i;
            List<string> Personas = new List<string>();
            
            //Agregamos objetos en la lista
            
            Personas.Add("Hugo");
            Personas.Add("Paco");
            Personas.Add("Erick");
            
            //Console.WriteLine("El numero de elementos en la lista es: {0}", Personas.Count());
            
            do
            {
                Console.WriteLine("1. Agregar elemento");
                Console.WriteLine("2. Salir");
            
                option = Convert.ToInt32(Console.ReadLine());
            
                if (option == 1)
                {
                    Console.WriteLine("Ingresa un elemento a agregar a la lista");
                    elem = Console.ReadLine();
                    
                    Personas.Add(elem);
                }
                
            } while (option == 1);
            // Mostramos los elementos de la lista
            Console.WriteLine("Lista de elementos: \n");
            // for (i = 0; i < Personas.Count(); i++)
            // {
            //     Console.WriteLine(Personas[i]);
            // }
            //foreach para recorrer una coleccion

            foreach (string elemento in Personas)
            {
                Console.WriteLine(elemento);
            }
            
            
            
            
        }
    }
}