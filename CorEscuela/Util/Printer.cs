using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace CorEscuela.Util
{
    //La clase static no permite crear nuevas instancias. funciona como un objeto.
    public static class Printer
    {
        public static void DibujarLinea(int tamaño = 10)
        {
            //rellenar a la izquierda de '=', serán tamaño cantidad de =
            WriteLine("".PadLeft(tamaño, '='));
        }
        public static void WriteTitle(string titulo)
        {
            var tamañoLineas = titulo.Length + 4;
            DibujarLinea(tamañoLineas);
            WriteLine($"| { titulo} |");
            DibujarLinea(tamañoLineas);
        }
        public static void pitido()
        {
            Beep(2000, 1000);
        }
    }
}
