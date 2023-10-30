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
            List<string> Personas = new List<string>();
            
            //Agregamos objetos en la lista
            
            Personas.Add("Hugo");
            Personas.Add("Paco");
            Personas.Add("Erick");
            do
            {
                Console.WriteLine("1.- Agregar elemento");
                Console.WriteLine("2: Salir");

                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Ingresa un elemento a agregar a la lista");
                    elem = Console.ReadLine();
                    
                    Personas.Add(elem);
                }

            } while (option == 1);

            {
                
            }
            
            
        }
    }
}