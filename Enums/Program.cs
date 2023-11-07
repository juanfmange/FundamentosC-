using System;
using Enums.Enums;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //clase enum
            //GetNames = permite obtener un arreglo de cadenas con los miembros de la enumeracion
            // GetValues = permite obtener un arreglo de los valores de la enumeracion
            // GetType = permite obtener el tipo de la enumeracion
            //IsDefined = permite saber si un valor pertenece a la enumeracion
            
            
            Semana diaDePago = Semana.Viernes;
            Console.WriteLine(diaDePago);
            
            BonosSueldosEmpleados bonoEmpleado = BonosSueldosEmpleados.PrimerNivel;
            Console.WriteLine((byte)bonoEmpleado);
            
            //Clase Type = representa declaraciones de tipos
            //operador typeof = permite obtener el tipo de un tipo
        }
    }
}

