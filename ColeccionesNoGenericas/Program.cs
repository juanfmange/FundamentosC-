using System;

namespace ColeccionesNoGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables locales
            Alumno ValorElemento;
            
            // Instancia de la clase
            GuardaObjetos objetos1 = new GuardaObjetos(3);
            
            //Agregar objetos
            //objetos1.AgregarElemento("Luis");
            //objetos1.AgregarElemento("paco");
            //objetos1.AgregarElemento("Juan");
            Alumno alumno1 = new Alumno(10);
            Alumno alumno2 = new Alumno(7.5);
            Alumno alumno3 = new Alumno(6.8);
            
            //Agregar objetos a la clase GusrdaObjeto
            
            objetos1.AgregarElemento(alumno1);
            objetos1.AgregarElemento(alumno2);
            objetos1.AgregarElemento(alumno3);
            
            
            //Obtener elemento
            ValorElemento = (Alumno)objetos1.ObtenerElementos(2);
            Console.WriteLine(ValorElemento.Calificacion);



        }
    }

    class GuardaObjetos
    {
        //Campos 
        private int i = 0;
        private Object[] matrizElementos;

        //Constructor
        public GuardaObjetos(int elementosPa)
        {
            matrizElementos = new object[elementosPa];
        }   

        // Metodos
        public void AgregarElemento(Object elementoPa)
        {
            matrizElementos[i] = elementoPa;
            i++;
        }

        public Object ObtenerElementos(int elementoPa)
        {
            return matrizElementos[elementoPa];
        }

    }

    class Alumno
    {
        // Campos
        double calificacion;
        //Constructor
        public Alumno(double calificacionPa)
        {
            calificacion = calificacionPa;
        }
        //Propiedades
        public double Calificacion
        {
            get => calificacion;
        }
    }
}