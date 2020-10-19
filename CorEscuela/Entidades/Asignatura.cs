using System;
using System.Collections.Generic;
using System.Text;

namespace CorEscuela.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; set; }
        public string Nombre { get;  set; }
        public string Evaluaciones { get; set;  }

        //Constructor
        public Asignatura() => UniqueId = Guid.NewGuid().ToString();

    }
}
