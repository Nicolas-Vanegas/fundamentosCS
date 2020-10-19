using CorEscuela.App;
using CorEscuela.Entidades;
using CorEscuela.Util;
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
            var engine = new EscuelaEngine();
            engine.inicializar();
            Printer.WriteTitle("Bienvenidos a la escuela");
            Printer.pitido();

            ImprimirCursosEscuela(engine.Escuela);
            ImprimirEvaluaciones(engine.Escuela.Alumnos);

        }

        private static void ImprimirEvaluaciones(Alumno alumno)
        {
            Printer.WriteTitle("Evaluaciones");
            //if (escuela.Cursos != null && escuela != null)
            //lo mismo de arriba pero más chimba. no se verifican cursos salvo que escuela sea diferente de null
            if (alumno?.Evaluacion != null)
            {
                foreach (var evaluacion in alumno.Evaluacion)
                {
                    WriteLine($"Nombre: {evaluacion.}, id: {alumno.UniqueId}");
                }
            }
        }
        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.WriteTitle("Cursos de la escuela");
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

    }
}
//Etapa 3. Arreglos y colecciones.
//Arreglos : más rápidos en memoria. Consumen menos. ideales para apis de bajo nivel.
//EN EL ARREGLO NO SE PUEDEN ADICIONAR NUEVOS ITEMS NI BORRAR, SOLO EDITAR.
//Colecciones. Más fáciles de manipular. Múltiples variantes. Tamaños Flexibles. Perzonalizables.
//Colecciones Simples: Manipulan todo como tipo object. Nadie usa esa mondá.
//Colecciones Genéricas: Más usadas. List<>. No hace boxing y unboxing. Se define sin un cuerpo para que alvergue objetos dependiendo la necesidad.
//Sin tener que meter todo en una caja y sacarlo de la caja. 
//VOLVER AL COMMIT DEL FINAL DE LA ETAPA 3 PARA VER TODOS LOS DETALLES ANTES DE LA REFACTORIZACIÓN.

//Etapa 4. Refactorizando y cargando datos de prueba.