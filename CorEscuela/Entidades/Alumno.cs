using System;
using System.Collections.Generic;
using System.Text;

namespace CorEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueId { get;  set; }
        public string Nombre { get;  set; }
        public string Evaluacion { get; set; }
        public TiposJornada Jornada { get;  set; }

        //Constructor
        public Alumno() => UniqueId = Guid.NewGuid().ToString();
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {Evaluacion}";
        }
    }
}
