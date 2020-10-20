using System;
using System.Collections.Generic;
using System.Text;

namespace CorEscuela.Entidades
{
    public class Evaluaciones
    {
        public string UniqueId { get; set; }
        public string Nombre { get; set; }
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }

        //Constructor
        public Evaluaciones() => UniqueId = Guid.NewGuid().ToString();
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {Alumno}";
        }
    }
}
