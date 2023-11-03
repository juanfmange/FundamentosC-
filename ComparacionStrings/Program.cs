using System;

namespace ComparacionStrings
{
    class Program
    
    {
        static void Main(string[] args)
        {
            //METODO COMPARE
            string cadena1 = "A";
            string cadena2 = "a";
            
            Console.WriteLine(String.Compare(cadena1,cadena2));
            
            
            //Comparacion de cadenas
            Console.WriteLine("Ingresa tu correo: ");
            string correo = Console.ReadLine();
            
            Console.WriteLine("Ingresa de nuevo tu correo: ");
            string correoConfirmado = Console.ReadLine();

            //bool coincideCorreo = Equals(correo, correoConfirmado);
            bool coincideCorreo;
            coincideCorreo = correo.Equals(correoConfirmado, StringComparison.OrdinalIgnoreCase); //Ignora si es mayusculas o minusculas
            

            if (coincideCorreo)
            //if (correo == correoConfirmado )
            {
                Console.WriteLine("El correo coincide");
            }
            else
            {
                Console.WriteLine("El correo no coincide");
            }
        }
    }
}