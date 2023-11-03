using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            decimal r; // Almacena el valor de resta
            decimal num1ar, num2ar;

            do
            {
                Console.WriteLine("Seleccion opcion");
                option = Convert.ToInt32(Console.ReadLine());

            }
            while ((option < 1) || (option > 4));

            switch (option)
            {
                case 1:
                    Sumar();
                    break;
                case 2:
                    r = Restar();
                    Console.WriteLine("El resultado de la resta es: {0}", r);
                    break;
                case 3:
                    num1ar = IngresarNumero("Ingresa el primer numero: ");
                    num2ar = IngresarNumero("Ingresa el segundo numero:");

                    Multiplicar(num1ar, num2ar);
                    break;

                case 4:
                    num1ar = IngresarNumero("Ingresa el primer numero: ");
                    num2ar = IngresarNumero("Ingresa el segundo numero:");

                    r = Dividir(num1ar, num2ar);
                    Console.WriteLine("El resultado es: {0}", r);

                    break;

                default:
                    Console.WriteLine("Revisa bien la opcion");
                    break;
            }
        }


        // [modificador] [tip] [identificador] [parametros]

        static void Sumar()
        {
            decimal num1, num2, resultado;
            //Instrucciones
            Console.WriteLine("Ingresa Num1: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresa Num2: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 + num2;

            Console.WriteLine("El resultado es: {0}", resultado);

        }

        static decimal Restar()
        {
            decimal num1, num2, resultado;
            //Instrucciones
            Console.WriteLine("Ingresa Num1: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingresa Num2: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 - num2;

            //Console.WriteLine("El resultado es: {0}", resultado);
            return resultado;
        }

        static void Multiplicar(decimal num1pa, decimal num2pa)
        {
            decimal resultado;
            resultado = num1pa * num2pa;
            Console.WriteLine("{0} * {1} = {2}", num1pa, num2pa, resultado);

        }

        static decimal Dividir(decimal num1pa, decimal num2pa)
        {

            decimal resultado;

            if (num2pa != 0)
            {
                resultado = num1pa / num2pa;
            }
            else
            {
                Console.WriteLine("No es posible dividir entre 0");
                resultado = 0;
            }

            return resultado;
        }

        static decimal IngresarNumero(string peticion)
        {
            decimal numero;
            Console.Write(peticion);
            numero = Convert.ToDecimal(Console.ReadLine());

            return numero;
        }


    }
}

