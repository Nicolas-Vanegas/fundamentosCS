using CorEscuela.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CorEscuela.App
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
        }

        public void inicializar()
        {

            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                        ciudad: "Bogotá"
                        );
            CargarCursos();
            CargarAsignaturas();
           
        }

        private void CargarEvaluaciones()
        {
            
        }
        private List<Evaluaciones> GenerarEvaluacionesAlAzar()
        {
            string[] nombresEvaluaciones = { "1", "2", "3", "4", "5" };
            var listaEvaluaciones = from e in nombresEvaluaciones
                                    select new Evaluaciones { Nombre = $"Evaluación {e}" };
            return listaEvaluaciones.ToList();
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            //combinar
            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };
            return listaAlumnos.OrderBy( (al)=> al.UniqueId ).Take(cantidad).ToList();//OrderBy ordenar la lista por uniqueId y despues toma n cantidad
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                var listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{ Nombre= "Matemáticas" },
                    new Asignatura{ Nombre= "Educación Física" },
                    new Asignatura{ Nombre= "Español" },
                    new Asignatura{ Nombre= "Inglés" },
                };
                curso.Asignaturas = listaAsignaturas;
            }
            foreach (var asignatura in Escuela.Cursos)
            {
                asignatura.Evaluaciones = GenerarEvaluacionesAlAzar();
            }
        }
        private void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>() {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Mañana },
                new Curso() { Nombre = "401", Jornada = TiposJornada.Tarde },
                new Curso() { Nombre = "501", Jornada = TiposJornada.Tarde },
            };
            //Instanciamos el generador de números aleatorios. Next genera entero
            Random rnd = new Random();
            foreach (var c in Escuela.Cursos)
            {
                int cantRandom = rnd.Next(5, 20);
                c.Alumnos = GenerarAlumnosAlAzar(cantRandom);
                foreach (var alumno in Escuela.Cursos)
                {
                    alumno.Evaluaciones = new List<Evaluaciones>();
                }
                
            }
        }
    }
}
