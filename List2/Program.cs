using System;

namespace List2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables globales
            int opcion, indice;
            string alumno;
            
            //Instancia de la lista
            List<string> Alumnos = new List<string>();
            do
            {
                Console.Clear();
                Console.WriteLine("1.- Agregar un alumno");
                Console.WriteLine("2.- Eliminar un alumno");
                Console.WriteLine("3.- Mostrar la lista de alumnos");
                Console.WriteLine("4.- Buscar por nombre");
                
                //Escoger opcion
                Console.WriteLine("Escoge una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa el nombre del alumno: ");
                        alumno = Console.ReadLine();
                        Alumnos.Add(alumno);
                        break;
                    
                    case 2:
                        Console.WriteLine("Ingresa el indice del alumno a eliminar: ");
                        indice = Convert.ToInt32(Console.ReadLine());
                        indice--;
                        if (indice >= Alumnos.Count() || indice < 0)
                            Console.WriteLine("El indice no existe");
                        else
                        {
                            string alumnoEliminado = Alumnos[indice];
                            Alumnos.RemoveAt(indice);
                            Console.WriteLine("{0} se ha eliminado correctamente", alumnoEliminado);
                            
                        }
                        
                        Console.WriteLine("\nPresiona una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                    case 3:
                        int i = 1;
                        foreach (string estudiante in Alumnos)
                        {
                            Console.WriteLine("{0} - {1}", i++, estudiante);
                        }
                        Console.WriteLine("\nPresiona una tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        string encontrarAlum;
                        int j; //numero de lista
                        Console.WriteLine("Ingresa el nombre del alumno a buscar: ");
                        alumno = Console.ReadLine();
                        
                        //Verificar si el alumno esta o no en la lista
                        if (Alumnos.IndexOf(alumno) >= 0)
                        {
                            encontrarAlum = Alumnos[Alumnos.IndexOf(alumno)]; //Alumnos[3]
                            j = Alumnos.IndexOf(alumno) + 1; //3
                            Console.WriteLine("El alumno {0} se encuentra en el numero {1} de la lista",encontrarAlum, j);
                            Console.WriteLine("\nPresiona una tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("El alumno no se encuentra en la lista");
                            Console.WriteLine("\nPresiona una tecla para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        break;
                    
                    
                }
                
            } while (opcion >=1 && opcion <= 4);
        }
    }
}