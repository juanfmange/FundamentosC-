using System;

namespace MatricesDeEstructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos y asignamos instancias a la matriz en una sola sintaxis
            Producto[] televisiones = new Producto[3]
            {
                new Producto{ Nombre = "Samsung" , Precio = 10000, Descripcion = "Televisión de 32 pulgadas" },
                new Producto{ Nombre = "LG" , Precio = 12000, Descripcion = "Televisión de 40 pulgadas" },
                new Producto{ Nombre = "Sony" , Precio = 15000, Descripcion = "Televisión de 50 pulgadas" }
            };

            foreach (Producto elemento in televisiones)
            {
                Console.WriteLine($"Nombre: {elemento.Nombre}\nPrecio: {elemento.Precio}\nDescripción: {elemento.Descripcion}\n");
            }
            
            
            Estudiante estudiante1 = new Estudiante();
            estudiante1.Nombre = "Juan";
            estudiante1.Apellido = "Perez";
            estudiante1.Calificaciones = new Calificacion[3]
            {
                new Calificacion{ Materia = "Matemáticas", Puntaje = 8 },
                new Calificacion{ Materia = "Español", Puntaje = 9 },
                new Calificacion{ Materia = "Inglés", Puntaje = 10 }
            };
            
            //Mostramos los datos del estudiante
            Console.WriteLine($"Nombre: {estudiante1.Nombre}\nApellido: {estudiante1.Apellido}\n");
            foreach (Calificacion elemento in estudiante1.Calificaciones)
            {
                Console.WriteLine($"Materia: {elemento.Materia}\nPuntaje: {elemento.Puntaje}\n");
            }
            {
                
            }
            
            /*
            Producto[] televisiones = new Producto[3];
            
            televisiones[0] = new Producto{ Nombre = "Samsung" , Precio = 10000, Descripcion = "Televisión de 32 pulgadas" };
            televisiones[1] = new Producto{ Nombre = "LG" , Precio = 12000, Descripcion = "Televisión de 40 pulgadas" };
            televisiones[2] = new Producto{ Nombre = "Sony" , Precio = 15000, Descripcion = "Televisión de 50 pulgadas" };
            */
        }
    }
    
    struct Producto
    {
        private string nombre;
        private double precio;
        private string descripcion;
        
        public string Nombre { get => nombre; set => nombre = value; }
        public double Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }

    struct Calificacion
    {
        //Campos
        private string materia;
        private double puntaje;
        
        public string Materia { get => materia; set => materia = value; }
        public double Puntaje { get => puntaje; set => puntaje = value; }
    }
    
    struct Estudiante
    {
        //Campos
        private string nombre;
        private string apellido;
        Calificacion[] calificaciones;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        // Internal se utiliza cuando queremos que uin miembro queremos que sea accesible unicamente dentro del ensamblado 
        internal Calificacion[] Calificaciones { get => calificaciones; set => calificaciones = value; }
    }
}