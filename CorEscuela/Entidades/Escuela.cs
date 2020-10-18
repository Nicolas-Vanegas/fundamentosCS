using System;
using System.Collections.Generic;
using System.Text;

namespace CorEscuela.Entidades
{
    //No es necesario que el nombre del archivo coincida con el nombre de la clase en CSharp
    public class Escuela
    {
        //Constructor.
        //public Escuela(string nombre, int año)
        //{
        //    this.nombre = nombre;
        //    AñoDeCreación = año;
        //}
        
        //El mismo constructor de arriba pero con igualación por tuplas
        public Escuela(string nombre, int año) => (Nombre, AñoDeCreación) = (nombre, año);

        
        public Escuela(string nombre, int año, 
                       TiposEscuela tipo, 
                       string pais="", string ciudad="")//A país le asigno valor por defecto para que sea un parámetro opcional
        {
            //Asignación de tuplas. múltiples asignaciones de valores al tiempo
            (Nombre, AñoDeCreación) = (nombre, año);
            //Asignación uno a uno
            Pais = pais;
            Ciudad = ciudad;
        }


        //Encapsulamiento: ponerle envoltorio a los atributos para poderle agregar lógica 
        //en el futuro sin tener que cambiar nada más en la función. De esa manera tenemos nombre y lo encapsulamos
        //en la propiedad Nombre
        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();

        string nombre;
        public string Nombre
        {
            //con el get se puede ver la variable nombre desde afuera pero no le puede establecer valores
            get { return nombre; }
            set { nombre = value.ToUpper(); }
        }

        //ShortCut para hacer la funcion con el get y el set
        public int AñoDeCreación { get; set; }
        public string Pais{ get; set; }
        public string Ciudad { get; set; }

        //TiposEscuela la creamos nosotros para que sólamente se puedan escoger las escuelas escritas en ese tipo
        public TiposEscuela TipoEscuela { get; set; }

        //Este atributo de tipo cadena tiene los cursos
        public List<Curso> Cursos { get; set; }

        //override: Sobre escribir a string. Acá usamos el override porque para csharp todo es un objeto y la clase Escuela imprimia en
        //texto, de donde viene la clase, eso lo da el objeto object. Así que lo sobre escribimos.
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Tipo: {TipoEscuela} {System.Environment.NewLine}Pais: {Pais}, Ciudad: {Ciudad}";
        }
        //datos: con el slash podemos agregar caracteres especiales.
        //El System.Enviroment.NewLine es como el \n pero más chimba :D.
    }
}
