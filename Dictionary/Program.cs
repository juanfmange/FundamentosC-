using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            //clave, valor
            Dictionary<string,int> empleados = new Dictionary<string,int>();
            
            
            //Añadiendo clave-valor al diccionario
            //Las claves tienen que ser UNICAS
            empleados.Add("Juan", 23);
            empleados.Add("Maria", 25);
            Console.WriteLine(empleados["Juan"]); //Devuelve el valor de la clave

            foreach (KeyValuePair<string,int> empleado in empleados)
            {
                Console.WriteLine("Clave: " + empleado.Key + " - " + " Valor: " + empleado.Value);
            }
            
            
            //Establecer un valor a una clave
            empleados["Juan"] = 30; //Sobreescribe el valor de la clave si ya existe
            empleados["Pedro"] = 40; //Si la clave no existe, la crea
            
            //Propiedad Add
            empleados.Add("Paco", 50); 
            
            //Propiedad get de item[]
            Console.WriteLine(empleados["Paco"]);
            Console.WriteLine(empleados["Juan"]);
            Console.WriteLine(empleados["Pedro"]);
            
            //Eliminar valor del dictionary
            empleados.Remove("Pedro");
            //verificar si se elimino el elemento
            foreach (KeyValuePair<string,int> empleado in empleados)
            {
                Console.WriteLine("Clave: " + empleado.Key + " - " + " Valor: " + empleado.Value);
            }
            
            //ContainsKey & ContainsValue
            if (empleados.ContainsKey("Juan"))
            {
                Console.WriteLine("La clave Juan existe");
            }
            else
            {
                Console.WriteLine("La clave Juan no existe");
            }
            
            if (empleados.ContainsValue(10))
            {
                Console.WriteLine("El valor 30 existe");
            }
            else
            {
                Console.WriteLine("El valor 10 no existe");
            }
            
        }
    }
}