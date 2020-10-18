using CorEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.ComTypes;
//Para usar menos console. Cada vez que escribamos un comando de console, solo escribimos el método sin el console
using static System.Console;

namespace CorEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                        /*pais:"Colombia" ,*/ ciudad: "Bogotá"
                        );
            //CON COLECCIONES
            escuela.Cursos = new List<Curso>() {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Mañana }
            };
            escuela.Cursos.Add(new Curso() { Nombre = "102", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso() { Nombre = "202", Jornada = TiposJornada.Tarde });
            escuela.Cursos.Add(new Curso() { Nombre = "302", Jornada = TiposJornada.Tarde });           

            var otraColeccion = new List<Curso>() {
                new Curso() { Nombre = "401", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "502", Jornada = TiposJornada.Mañana }
            };
            //agregar toda una colección
            escuela.Cursos.AddRange(otraColeccion);
            //Limpiar la colección
            //otraColeccion.Clear();

            ImprimirCursosEscuela(escuela);

            //Remove
            Curso tmp = new Curso{Nombre = "101-vacacional", Jornada = TiposJornada.Noche};
            escuela.Cursos.Add(tmp);
            ImprimirCursosEscuela(escuela);
            escuela.Cursos.Remove(tmp);
            ImprimirCursosEscuela(escuela);
            //borrar cosa especifica si no sabemos su index o su nombre de variable. Delegados.
            escuela.Cursos.RemoveAll(delegate(Curso cur) 
                                    {
                                        return cur.Nombre == "301";
                                    });
            //expresión lambda
            escuela.Cursos.RemoveAll((cur) => cur.Nombre == "502" && cur.Jornada == TiposJornada.Mañana);
            ImprimirCursosEscuela(escuela);


            //CON ARREGLOS
            //Lo mismo de abajo escrito distinto
            //escuela.Cursos = new Curso[]
            //{
            //    new Curso() { Nombre = "101" },
            //    new Curso() { Nombre = "201" },
            //    new Curso() { Nombre = "301" },
            //};


            //var arregloCursos = new Curso[3];
            //{
            //    new Curso() { Nombre = "101" };
            //    new Curso() { Nombre = "201" };
            //    new Curso() { Nombre = "301" };
            //}

            //Lo quité porque no es conveniente hacer uno por uno, es mejor meterlos en un arreglo
            //var curso1 = new Curso()
            //{
            //    Nombre = "101"
            //};


        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            WriteLine("====================");
            WriteLine("Cursos de la escuela");
            WriteLine("====================");

            //Si no hay cursos, se sale de acá 
            //if (escuela.Cursos != null && escuela != null)
            //lo mismo de arriba pero más chimba. no se verifican cursos salvo que escuela sea diferente de null
            if (escuela?.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, id: {curso.UniqueId}");
                }
            }
        }

        //método para recorrer el arreglo de los cursos. Aunque ya no usamos arrays
        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            //Con while
            //int contador = 0;
            //while (contador < arregloCursos.Length)
            //{
            //    Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, id: {arregloCursos[contador].UniqueId}");
            //    contador++;
            //}
            //Con do while
            //do
            //{
            //    Console.WriteLine($"Nombre: {arregloCursos[contador].Nombre}, id: {arregloCursos[contador].UniqueId}");
            //    contador++;
            //} while (contador < arregloCursos.Length);
            //Con for
            //for (int i = 0; i < arregloCursos.Length; i++)
            //{
            //    Console.WriteLine($"Nombre: {arregloCursos[i].Nombre}, id: {arregloCursos[i].UniqueId}");
            //}
            //Con foreach
            foreach (var curso in arregloCursos)
            {
                Console.WriteLine($"Nombre: {curso.Nombre}, id: {curso.UniqueId}");
            }
        }
    }
}
//Etapa 3. Arreglos y colecciones.
//Arreglos : más rápidos en memoria. Consumen menos. ideales para apis de bajo nivel.
//EN EL ARREGLO NO SE PUEDEN ADICIONAR NUEVOS ITEMS NI BORRAR, SOLO EDITAR.
//Colecciones. Más fáciles de manipular. Múltiples variantes. Tamaños Flexibles. Perzonalizables.
//Colecciones Simples: Manipulan todo como tipo object. Nadie usa esa mondá.
//Colecciones Genéricas: Más usadas. List<>. No hace boxing y unboxing. Se define sin un cuerpo para que alvergue objetos dependiendo la necesidad.
//Sin tener que meter todo en una caja y sacarlo de la caja.