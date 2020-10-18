using System;
using System.Collections.Generic;
using System.Text;

namespace CorEscuela.Entidades
{
    public class Curso
    {
        //El set es privado para que el id solo se pueda asignar dentro de la clase.
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }

        public Curso()
        {
            //generamos el id ramdom
            UniqueId = Guid.NewGuid().ToString();
            
        }
    }
}
