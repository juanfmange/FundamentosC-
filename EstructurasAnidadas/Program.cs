using System;

namespace EstructurasAnidadas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaReproduccion listaReproduccion1 = new ListaReproduccion();
            listaReproduccion1.Nombre = "clasicos";
            
            //Agragrando informacion a las canciones en la estructura lista de reproduccion
            listaReproduccion1.cancion1.Titulo = "amargo adios";
            listaReproduccion1.cancion1.artista1 = "insite";
            listaReproduccion1.cancion1.Duracion = 3;
            
            listaReproduccion1.cancion2.Titulo = "y que";
            listaReproduccion1.cancion2.artista1 = "insite";
            listaReproduccion1.cancion2.Duracion = 4;
            
            Console.WriteLine(listaReproduccion1.ToString());
        }
    }
    
    //Estructura anidada incrustada
    struct EstructuraPrincipal
    {
        struct EstructuraAnidada
        {
            
        }
    }
    
    //Estructura anidada separada
    struct Empleado
    {
        
    }

    struct Empresa
    {
        //Usamos una estructura como miembro de otra, tambien cuenta como estructura anidada
        Empleado empleado1;
    }

    struct Cancion
    {
        //Campos
        private string titulo;
        private string artista;
        private int duracion;
        
        public string Titulo
        {
            get => titulo;
            set => titulo = value;
        }
        public string artista1
        {
            get => artista;
            set => artista = value;
        }
        public int Duracion
        {
            get => duracion;
            set => duracion = value;
        }
        
        //Invalidamos el metodo ToString para mostrar la informacion del struct
        public override string ToString()
        {
            return $"\nTitulo: {titulo}, \nArtista: {artista}, \nDuracion: {duracion}";
        }
        
    }

    struct ListaReproduccion
    {
        private string nombre;
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        
        //Anidamos a la estructurea cancion
        public Cancion cancion1;
        public Cancion cancion2;
        
        public override string ToString()
        {
            return $"Lista de reproduccion {Nombre} \n\nCancion1: {cancion1.ToString()}, \n\nCancion2: {cancion2.ToString()}";
        }
    }
}