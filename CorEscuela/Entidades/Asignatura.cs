using System;
using System.Collections.Generic;
using System.Text;

namespace CorEscuela.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; private set; }
        public string Nombre { get;  set; }

        //Constructor
        public Asignatura() => UniqueId = Guid.NewGuid().ToString();

    }
}
