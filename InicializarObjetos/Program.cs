using System;

namespace InicializarObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializar objetos y colecciones
            Persona persona1 = new Persona
            {
                Nombre = "Juan",
                Edad  = 20,
                Apellido = "Perez"
            };
            
            Console.WriteLine(persona1.ToString());
        }
    }

    struct Persona
    {
        private string nombre;
        private int edad;
        private string apellido;
        
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        
        public override string ToString()
        {
            return string.Format("Nombre:{0} \nedad:{1} \napellidos:{2}", nombre, edad, apellido);
        }
    }
}