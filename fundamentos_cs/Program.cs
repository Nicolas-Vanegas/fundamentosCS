using System;

namespace fundamentos_cs
{
    class Escuela_9
    {
        public string nombre;
        public string direccion;
        public int anioFundacion;
        public string director;

        public void Timbrar()
        {
            //Beep es un pitido
            Console.Beep(1000, 3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.Read();

            //Clase 8. Clases, objetos, métodos, acciones y atributos.
            //Objeto

            //Es descrito por sus atributos.
            //Sus acciones se representan con métodos(funciones)

            //Clase
            //La clase es la descripción de un objeto.
            //Una plantilla para objetos.

            //Escuela_9.
            //Escuela_9 kennedy = new Escuela_9();

            //kennedy.nombre = "Colegio Kennedy";
            //kennedy.direccion = "Colegio Kennedy";
            //kennedy.anioFundacion = 1985;
            //Console.WriteLine("Nombre de la institución: {0} \n Dirección: {1} \n año de fundación: {2}", kennedy.nombre, kennedy.direccion, kennedy.anioFundacion);

            //kennedy.Timbrar();

        }
    }
}
